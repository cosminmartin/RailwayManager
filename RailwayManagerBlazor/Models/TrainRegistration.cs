using System.ComponentModel.DataAnnotations;

namespace RailwayManagerBlazor.Models
{
    public class TrainRegistration
    {
        [Required]
        [Display(Name = "Iași-Bacău")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Iași")]
        public string DepartureStation { get; set; }

        [Required]
        [Display(Name = "Bacău")]
        public string ArrivalStation { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; } = DateTime.Today;

        [Required]
        public DateTime ArrivalDate { get; set; } = DateTime.Today;

        [Required]
        public DateTime Duration { get; set; } = DateTime.Today;

        [Required]
        [Display(Name = "Activ")]
        public string Status { get; set; }
    }
}
