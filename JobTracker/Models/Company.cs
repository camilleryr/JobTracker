using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "Please Enter A Shorter Company Name")]
        [Display(Name = "Company Name")]
        public string Name { get; set; }

        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<CompanyContact> Contacts { get; set; }

    }
}
