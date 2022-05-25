namespace ConcertsAPI.Data
{
    public class Artist
    {
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public string ManagerName { get; set; }
        public string ManagerLastName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string Nationality { get; set; }

        //Concerts
        public IList<Concert> Concerts { get; set; }


    }
}
