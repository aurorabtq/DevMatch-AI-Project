using System;

namespace FreelancePlatform.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }

        public string ClientId { get; set; }
        public ApplicationUser Client { get; set; }

        public string FreelancerId { get; set; }
        public ApplicationUser Freelancer { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? SignedAt { get; set; }

        public string Terms { get; set; }
        public string Status { get; set; } //Draft, Signed, Completed
    }

}
