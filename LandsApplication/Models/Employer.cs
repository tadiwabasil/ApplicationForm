using System.ComponentModel.DataAnnotations;

namespace LandsApplication.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        [Display(Name = " Employer fullname")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        [Display(Name = "Employer Address")]
        public string Address { get; set; }

        public List<Application> Applications { get; set; }
    }
}
