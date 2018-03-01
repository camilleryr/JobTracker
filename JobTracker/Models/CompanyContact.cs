using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class CompanyContact
    {
        [Key]
        public int CompanyContactId { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [Required]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }

    }
}