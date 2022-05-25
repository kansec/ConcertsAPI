using ConcertsAPI.Data;

namespace ConcertsAPI.Models.Concerts
{
    public class GetConcertsDto
    {
        public double TicketPrice { get; set; }
        public DateTime Date { get; set; }

        //Artist
        public Artist Artist { get; set; }

        //Place
        public Place Place { get; set; }

    }
}
