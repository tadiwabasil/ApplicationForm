using System.ComponentModel.DataAnnotations;

namespace LandsApplication.Models
{

    public class RegistrationParticulars
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Applicant National ID Number")]

        [StringLength(20, ErrorMessage = "Registration particulars cannot be more than 20 characters")]
        public string? Applicant { get; set; }

        [Display(Name = "Spouse National ID Number")]

        [StringLength(20, ErrorMessage = "Registration particulars cannot be more than 20 characters")]
        public string? Spouse { get; set; }

        [Display(Name = "Certificate of Incorporation Number (If Company)")]

        [StringLength(20, ErrorMessage = "Registration particulars cannot be more than 20 characters")]
        public string? CertificateOfIncorporation { get; set; }

        public List<Application> Applications { get; set; }
    }
}
