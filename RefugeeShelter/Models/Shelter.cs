using System.ComponentModel.DataAnnotations;

namespace RefugeeShelter.Models
{
    public class Shelter
    {
        public int ShelterId { get; set; }
        [Required]
        public string ShelterName { get; set; } = "";
        public string? Description { get; set; }
        [Required]
        public string City { get; set; } = "";
        [Required]
        public string Address { get; set; } = "";
        [Required]
        [RegularExpression(@"^[0-9]{2}-[0-9]{3}$")]
        public string ZipCode { get; set; } = "";
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        public string? Base64Image { get; set; }
    }
}
