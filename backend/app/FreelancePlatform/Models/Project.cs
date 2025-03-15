using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancePlatform.Models
{
 
    public class Project
    {
        public string ProjectID { get; set; }

        public string UserId { get; set; }

        public string Title { get; set; }

        public string Client { get; set; }
        [Required]
        public int Year { get; set; }

        public ApplicationUser User { get; set; }

        [DataType(DataType.Upload)]
        public byte[] Img { get; set; }
    }
}
