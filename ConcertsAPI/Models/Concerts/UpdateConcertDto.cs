namespace ConcertsAPI.Models.Concerts
{
    public class UpdateConcertDto
    {
        public int Id { get; set; }
        public double TicketPrice { get; set; }
        public DateTime Date { get; set; }
        public string EventRules { get; set; }
        //Artist
        public int ArtistId { get; set; }
        //Place
        public int PlaceId { get; set; }

    }
}
