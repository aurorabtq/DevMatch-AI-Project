using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancePlatform.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public Job Job { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
