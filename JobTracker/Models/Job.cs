using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Position { get; set; }

        public double Salary { get; set; }

        public string Location { get; set; }

        [Display(Name = "Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [Display(Name = "Contact")]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
