namespace ConcertsAPI.Models.Artists
{
    public class CreateArtistDto
    {
        public string ArtistName { get; set; }
        public string ManagerName { get; set; }
        public string ManagerLastName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string Nationality { get; set; }


    }
}
