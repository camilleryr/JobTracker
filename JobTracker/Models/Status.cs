using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "Please Enter A Shorter Job Status")]
        [Display(Name = "Job Status")]
        public string JobStatus { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}