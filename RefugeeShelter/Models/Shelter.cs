namespace RefugeeShelter.Models
{
    public class Shelter
    {
        public int ShelterId { get; set; }
        public string ShelterName { get; set; } = "";
        public string? Description { get; set; }
        public string City { get; set; } = "";
        public string Address { get; set; } = "";
        public string ZipCode { get; set; } = "00-000";
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Base64Image { get; set; }
    }
}
