using JobTracker.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace JobTracker.Models
{
    public class ContactJoin
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

        public ICollection<Company> Company { get; set; }

        public ICollection<Job> Job { get; set; }

        public ContactJoin(ApplicationDbContext context)
        {
            Company = context.Company.Select(x => x).ToList();
            Job = context.Job.Select(x => x).ToList();
        }


    }
}