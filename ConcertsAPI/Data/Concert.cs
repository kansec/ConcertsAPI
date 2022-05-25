using System.ComponentModel.DataAnnotations.Schema;

namespace ConcertsAPI.Data
{
    public class Concert
    {
        public int Id { get; set; }
        public double TicketPrice { get; set; }
        public DateTime Date { get; set; }
        public string EventRules { get; set; }

        //Artist
        [ForeignKey(nameof(ArtistId))]
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        //Place
        [ForeignKey(nameof(PlaceId))]
        public int PlaceId { get; set; }
        public Place Place { get; set; }

    }
}
