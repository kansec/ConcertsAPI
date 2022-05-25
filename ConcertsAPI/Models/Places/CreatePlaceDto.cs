namespace ConcertsAPI.Models.Places
{
    public class CreatePlaceDto
    {
        public string Name { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string AdressDetails { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }


    }
}
