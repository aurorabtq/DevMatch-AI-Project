import subprocess
import sys
 
# Ensure nltk is installed
subprocess.check_call([sys.executable, "-m", "pip", "install", "nltk"])
subprocess.check_call([sys.executable, "-m", "pip", "install", "flask"])

from flask import Flask, request, jsonify
import pandas as pd
import numpy as np
from sklearn.feature_extraction.text import TfidfVectorizer
from sklearn.metrics.pairwise import cosine_similarity
import nltk
from nltk.corpus import stopwords
import re
 
app = Flask(__name__)
 
# Load the dataset
df = pd.read_csv('../datasets/Final_Upwork_Dataset.csv.zip', compression='zip')
 
# Download stopwords
nltk.download('stopwords')
stop_words = set(stopwords.words('english'))
 
# Preprocess text function
def preprocess_text(text):
    if not isinstance(text, str):
        return ""
    text = re.sub(r'\W', ' ', text)  # Remove non-word characters
    text = text.lower()              # Convert to lowercase
    text = ' '.join([word for word in text.split() if word not in stop_words])  # Remove stopwords
    return text
 
# Ensure 'Description' has no NaN values before processing
df['Description'] = df['Description'].fillna("")
df['processed_description'] = df['Description'].apply(preprocess_text)
 
# Function to extract duration in weeks from 'Time_Limitation'
def extract_duration_weeks(time_limit):
    if pd.isna(time_limit):
        return None
    time_limit = time_limit.lower()
    match = re.search(r'(\d+)\s*to\s*(\d+)\s*months', time_limit)
    if match:
        min_weeks = int(match.group(1)) * 4
        max_weeks = int(match.group(2)) * 4
        return (min_weeks, max_weeks)
    if "less than 30 hrs/week" in time_limit:
        return (1, 12)
    if "more than 30 hrs/week" in time_limit:
        return (12, 52)
    return None
 
# Apply duration extraction
df['Duration_Weeks'] = df['Time_Limitation'].apply(extract_duration_weeks)
 
# Process Start_rate and filter out rows with zero value
df['Start_rate'] = pd.to_numeric(df['Start_rate'], errors='coerce').fillna(0)
df = df[df['Start_rate'] > 0]
 
# Precompute TF-IDF matrix for job descriptions (using bi-grams)
vectorizer = TfidfVectorizer(stop_words='english', max_features=5000, ngram_range=(1, 2))
job_vectors = vectorizer.fit_transform(df['processed_description'])
 
def find_top_matches(client_input, df, top_n=50, scaling_factor=10):
    # Prepare client text with extra weight for the title (repeat it)
    client_text = (client_input['title'] + " ") * 2 + client_input['description'] + " " + client_input['skills']
    client_text = preprocess_text(client_text)
    # Transform the client text using the pre-fitted vectorizer
    client_vector = vectorizer.transform([client_text])
    # Compute raw cosine similarity between the client vector and all job vectors
    raw_similarities = cosine_similarity(client_vector, job_vectors).flatten()
    # Multiply by the scaling factor, then clip to ensure values don't exceed 1
    scaled_similarities = np.clip(raw_similarities * scaling_factor, 0, 1)
    # Create a copy of the dataframe and attach the scaled similarity scores
    df_local = df.copy()
    df_local['similarity'] = scaled_similarities
    # Do not filter by experience—focus is on title, description, and skills.
    filtered_df = df_local.copy()
    client_duration = client_input['duration']
    client_budget = client_input['budget']
    # Drop rows with missing Duration_Weeks or Start_rate values
    filtered_df = filtered_df.dropna(subset=['Duration_Weeks', 'Start_rate'])
    # Filter based on the client's desired duration fitting within the job's duration range
    filtered_df = filtered_df[filtered_df['Duration_Weeks'].apply(lambda x: x[0] <= client_duration <= x[1])]
    # Estimate hourly budget (assuming a 40-hour work week)
    total_hours = client_duration * 40  
    estimated_hourly_budget = client_budget / total_hours if total_hours > 0 else 0
    # Calculate budget difference for further ranking
    filtered_df['budget_diff'] = abs(filtered_df['Start_rate'] - estimated_hourly_budget)
    # Create an ordering for experience: Expert first, then Intermediate, then others.
    experience_order = {'expert': 1, 'intermediate': 2, 'beginner': 3}
    # Map the experience levels from the dataset (assumed to be in 'EX_level_demand')
    filtered_df['exp_order'] = filtered_df['EX_level_demand'].str.lower().map(experience_order)
    # If experience is missing or not in the mapping, assign a high order value so they come last.
    filtered_df['exp_order'] = filtered_df['exp_order'].fillna(99)
    # Sort results: first by similarity (descending), then by experience order (ascending), then by budget difference (ascending)
    top_matches = filtered_df.sort_values(by=['similarity', 'exp_order', 'budget_diff'], ascending=[False, True, True]).head(top_n)
    return top_matches
 
@app.route('/api/python', methods=['POST'])
def process_client_input():
    client_input = request.json
    top_matches = find_top_matches(client_input, df)
   
    # Convert the DataFrame to a list of dictionaries
    top_matches_list = top_matches.to_dict(orient='records')
   
    # Map the DataFrame columns to the model properties
    response = [
        {
            "Title": match["Job Title"],
            "Description": match["Description"],
            "Skills": match["EX_level_demand"],
            "Duration": match["Duration_Weeks"],
            "StartRate": match["Start_rate"],
            "Similarity": match["similarity"]
        }
        for match in top_matches_list
    ]
   
    return jsonify(response)
 
if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0', port=5000)
 
