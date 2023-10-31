using System.ComponentModel.DataAnnotations;

namespace LandsApplication.Models
{
    public class AgreementLease
    {
        [Display(Name = "Lease Number")]
        [Key]
        public string LeaseNumber { get; set; }

        [Display(Name = "Property Description")]
        public string PropertyDetails { get; set; }

        [Display(Name = "Situate")]
        public string Situate { get; set; }

        [Display(Name = "Lessor")]
        public string Lessor { get; set; }

        [Display(Name = "Lessee")]
        public string Lessee { get; set; }

        [Display(Name = "Municipality")]
        public string Municipality { get; set; }

        [Display(Name = "Ministry")]
        public string Ministry { get; set; }

        [Display(Name = "PropertySize")]
        public string PropertySize { get; set; }

        [Display(Name = "Rent Amount")]
        public double RentAmount { get; set; }

        [Display(Name = "Rent Revaluation Period")]
        public string RentRevaluatuionPeriod { get; set; }

        [Display(Name = "Rental Purpose")]
        public string RentalPurpose { get; set; }




    }
}
