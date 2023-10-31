using System.ComponentModel.DataAnnotations;

namespace LandsApplication.Models
{
    public class DateOfBirth
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Applicant D.O.B")]
        [DataType(DataType.Date)]
        public DateTime? Applicant { get; set; }

        [Display(Name = "Spouse D.O.B")]
        [DataType(DataType.Date)]
        public DateTime? Spouse { get; set; }

        [Display(Name = "Registration Date (If company)")]
        [DataType(DataType.Date)]
        public DateTime? RegistrationDate { get; set; }

        public List<Application> Applications { get; set; }
    }
}
