using ConcertsAPI.Data;

namespace ConcertsAPI.Models.Places
{
    public class PlaceDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string AdressDetails { get; set; }

        //Concerts

        public IList<Concert> Concerts { get; set; }

    }
}
