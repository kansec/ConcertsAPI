using ConcertsAPI.Data;

namespace ConcertsAPI.Models.Places
{
    public class GetPlaceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string AdressDetails { get; set; }

        
    }
}
