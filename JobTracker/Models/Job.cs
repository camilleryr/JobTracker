using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "Please Enter A Shorter Job Title")]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Please Enter A Shorter Job Description")]
        [Display(Name = "Job Description")]
        public string JobDesc { get; set; }

        [Required]
        [Display(Name = "Job Status")]
        public int StatusId { get; set; }
        public Status Status { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public virtual ICollection<JobContact> Contacts { get; set; }

    }
}