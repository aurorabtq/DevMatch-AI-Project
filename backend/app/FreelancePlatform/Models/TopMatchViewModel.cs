using System.Collections.Generic;

namespace FreelancePlatform.Models
{
    public class TopMatchViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public List<int> Duration { get; set; }
        public decimal StartRate { get; set; }
        public decimal Similarity { get; set; }
    }
}
