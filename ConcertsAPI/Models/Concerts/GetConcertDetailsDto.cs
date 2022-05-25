using ConcertsAPI.Data;

namespace ConcertsAPI.Models.Concerts
{
    public class GetConcertDetailsDto
    {
        public double TicketPrice { get; set; }
        public DateTime Date { get; set; }
        public string EventRules { get; set; }

        //Artist
        public Artist Artist { get; set; }

        //Place
        public Place Place { get; set; }

    }
}
