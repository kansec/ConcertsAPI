namespace ConcertsAPI.Models.Concerts
{
    public class CreateConcertDto
    {
        public double TicketPrice { get; set; }
        public DateTime Date { get; set; }
        public string EventRules { get; set; }
        //Artist
        public int ArtistId { get; set; }
        //Place
        public int PlaceId { get; set; }
    }
}
