using System.ComponentModel.DataAnnotations;

namespace LandsApplication.Models
{
    public class Application
    {
        [Key]
        public string ApplicationNo { get; set; }

        [Display(Name = "Forename(s)")]
        [StringLength(50, ErrorMessage = "Name length cannot be more than 50")]
        [Required]
        public string Forenames { get; set; }


        [Display(Name = "Surname")]
        [StringLength(50, ErrorMessage = "Name length cannot be more than 50")]
        public string Surname { get; set; }

        [Display(Name = "Marital Status")]
        [Required]
        [EnumDataType(typeof(MaritalStatus), ErrorMessage = "Marital status value doesnt exist within enum")]
        public MaritalStatus MaritalStatus { get; set; }


        [Display(Name = "Spouse fullname")]
        [StringLength(50, ErrorMessage = "Name length cannot be more than 50")]
        public string? SpouseName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateOfBirth? DateOfBirth { get; set; }

        [Display(Name = "Registration Particulars")]
        [StringLength(50, ErrorMessage = "Registration particulars cannot be more than 50 characters")]
        public RegistrationParticulars RegistrationParticulars { get; set; }


        [Display(Name = "Postal Address")]
        [StringLength(50, ErrorMessage = "Address length cannot be more than 50")]
        public string PostalAddress { get; set; }

        [StringLength(50, ErrorMessage = "Address length cannot be more than 50")]
        [Display(Name = "Physical Address")]
        public string PhysicalAddress { get; set; }

        [Display(Name = "Phone Number")]
        [Phone]
        public int PhoneNumber { get; set; }

        [StringLength(50, ErrorMessage = "Occupation length cannot be more than 50")]
        [Display(Name = "Occupation")]
        public string Occupation { get; set; }

        [StringLength(50, ErrorMessage = "E.C.Number length cannot be more than 50 characters")]
        [Display(Name = "E.C. Number")]
        public string ECNumber { get; set; }

        [Range(1, 9999999)]
        [Display(Name = "Salary")]
        public double Salary { get; set; }

        [StringLength(50, ErrorMessage = "Employer length cannot be more than 50 characters")]
        [Display(Name = "Employer Details")]
        public Employer Employer { get; set; }

        [Display(Name = "Nationality")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        public string Nationality { get; set; }

        [Display(Name = "Country of Residence")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        public string CountryOfResidence { get; set; }

        [Display(Name = "Stand Applied for")]
        [StringLength(100, ErrorMessage = "Cannot be more than 100 characters")]
        public string StandAppliedFor { get; set; }

        [Display(Name = "Is the application for")]
        [Required]
        [EnumDataType(typeof(LeaseTerms), ErrorMessage = "Lease term value does not exist within enum")]
        public LeaseTerms LeaseTerms { get; set; }

        [Display(Name = "Purpose of Stand")]
        [StringLength(100, ErrorMessage = "Cannot be more than 100 characters")]
        public string PurposeOfStand { get; set; }

        [Display(Name = "What value of the buildings is to be erected on the stand")]
        public BuildingValue BuildingValue { get; set; }

        [Display(Name = "If stand is required for industrial/business purposes, give details of type of business")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        public string? TypeOfBusiness { get; set; }

        [Display(Name = "Is a rail siding needed")]
        public bool RailSiding { get; set; }

        [Display(Name = "Give particulars of any other stand owned in Zimbabwe")]
        [StringLength(50, ErrorMessage = "Cannot be more than 50 characters")]
        public string? OtherStandsOwned { get; set; }

        [Display(Name = "Have you or your spouse ever been declared insolvent?")]
        public bool Insolvantion { get; set; }

        [Display(Name = "State how you are to finance the development and/or purchase of the stand")]
        [StringLength(100, ErrorMessage = "Cannot be more than 100 characters")]
        public string FinanceSource { get; set; }


    }
}
