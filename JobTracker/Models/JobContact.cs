using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class JobContact
    {
        [Key]
        public int JobContactId { get; set; }

        [Required]
        public int JobId { get; set; }
        public Job Job { get; set; }

        [Required]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }

    }
}