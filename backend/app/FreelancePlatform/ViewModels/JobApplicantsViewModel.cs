using FreelancePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancePlatform.ViewModels
{
    public class JobApplicantsViewModel
    {
        public Job Job { get; set; }

        public List<Applicant> Applicants { get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}
