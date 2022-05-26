using ConcertsAPI.Data;

namespace ConcertsAPI.Models.Concerts
{
    public class GetConcertsDto
    {
        public int Id { get; set; }
        public double TicketPrice { get; set; }
        public DateTime Date { get; set; }
        public string EventRules { get; set; }

        //Artist
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        //Place
        public int PlaceId { get; set; }
        public Place Place { get; set; }


    }
}
