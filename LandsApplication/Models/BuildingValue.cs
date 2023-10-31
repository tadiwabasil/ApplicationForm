using System.ComponentModel.DataAnnotations;

namespace LandsApplication.Models
{
    public class BuildingValue
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "After the first 2 years $")]
        [Range(1, 999999999)]
        public double FirstTwoYears { get; set; }

        [Display(Name = "Thereafter $")]
        [Range(1, 999999999)]
        public double Thereafter { get; set; }

        public List<Application> Applications { get; set; }
    }
}
