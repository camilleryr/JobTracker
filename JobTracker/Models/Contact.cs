using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "Please Enter A Shorter Name")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNum { get; set; }

        public ICollection<CompanyContact> CompanyContacts { get; set; }
        public ICollection<JobContact> JobContacts { get; set; }


    }
}