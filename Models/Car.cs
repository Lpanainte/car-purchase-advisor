using System.ComponentModel.DataAnnotations;

namespace CarPurchaseAdvisor.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string? Brand { get; set; }

        [Required]
        public string? Model { get; set; }

        [Range(2020, 2030)]
        public int Year { get; set; }

        [Range(1, 100000000)]
        public decimal Price { get; set; }

        [Required]
        public string? FuelType { get; set; }

        public string? CarType { get; set; }

        [Range(1, 3000)]
        public int Horsepower { get; set; }

        public bool IsElectric { get; set; }

        public int? ElectricRangeKm { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}