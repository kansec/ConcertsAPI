using ConcertsAPI.Data;

namespace ConcertsAPI.Models.Artists
{
    public class ArtistDetailsDto
    {
        public class Artist
        {
            public int Id { get; set; }
            public string ArtistName { get; set; }
            public string Nationality { get; set; }

            //Concerts
            public IList<Concert> Concerts { get; set; }


        }
    }
}
