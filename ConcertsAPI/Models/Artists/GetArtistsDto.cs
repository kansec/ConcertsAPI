using ConcertsAPI.Data;

namespace ConcertsAPI.Models.Artists
{
    public class GetArtistsDto
    {
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public string Nationality { get; set; }

    }
}
