namespace ConcertsAPI.Data
{
    public class Place
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string AdressDetails { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }

        //Concerts

        public IList<Concert> Concerts { get; set; }


    }
}
