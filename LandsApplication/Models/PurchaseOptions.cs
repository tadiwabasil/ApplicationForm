using System.ComponentModel.DataAnnotations;

namespace LandsApplication.Models
{

    public class PurchaseOption
    {
        [Display(Name = "Registration Number")]
        [Key]
        public string RegistrationNo { get; set; }

        [Display(Name = "Township")]
        public string Township { get; set; }

        [Display(Name = "Lessor")]
        public string Lessor { get; set; }

        [Display(Name = "Lessee")]
        public string Lessee { get; set; }

        [Display(Name = "Property Description")]
        public string PropertyDetails { get; set; }

        [Display(Name = "District")]
        public string District { get; set; }

        [Display(Name = "Annexed period")]
        public string AnnexedPeriod { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Rent Amount")]
        public double RentAmount { get; set; }

        [Display(Name = "Date of First Payment")]
        [DataType(DataType.Date)]
        public DateTime DateofRent { get; set; }

        [Display(Name = "Date of Subsequent")]
        [DataType(DataType.Date)]
        public DateTime SubsequentDate { get; set; }

        [Display(Name = "Building Clause")]
        public double BuildingClause { get; set; }

        [Display(Name = "Purchase Price")]
        public double PurchasePrice { get; set; }

        [Display(Name = "Total Purchase Price")]
        public double TotalPurchasePrice { get; }
    }
}
