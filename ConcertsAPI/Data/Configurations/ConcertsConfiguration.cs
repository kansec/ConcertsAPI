using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcertsAPI.Data.Configurations
{
    public class ConcertsConfiguration : IEntityTypeConfiguration<Concert>
    {
        public void Configure(EntityTypeBuilder<Concert> builder)
        {
            builder.HasData(
                 new Concert
                 {
                     Id =1,
                     Date = new DateTime(2022,10,20),
                     EventRules= "-There is 18 age limit." +
                     "- Participants / viewers must follow the rules received under COVID-19.",
                     TicketPrice = 240,
                     ArtistId = 1,
                     PlaceId = 1,

                 },
                 new Concert
                 {
                     Id = 2,
                     Date = new DateTime(2022, 9, 20),
                     EventRules = "-There is 18 age limit." +
                     "- Participants / viewers must follow the rules received under COVID-19.",
                     TicketPrice = 100,
                     ArtistId = 1,
                     PlaceId = 2,

                 },
                 new Concert
                 {
                     Id = 3,
                     Date = new DateTime(2022, 5, 5),
                     EventRules = "-There is 18 age limit." +
                     "- Participants / viewers must follow the rules received under COVID-19.",
                     TicketPrice = 150,
                     ArtistId = 2,
                     PlaceId = 1,

                 },
                 new Concert
                 {
                     Id = 4,
                     Date = new DateTime(2022, 12, 3),
                     EventRules = "-There is 18 age limit." +
                     "- Participants / viewers must follow the rules received under COVID-19.",
                     TicketPrice = 1000,
                     ArtistId = 2,
                     PlaceId = 3,

                 },
                 new Concert
                 {
                     Id = 5,
                     Date = new DateTime(2022, 3, 7),
                     EventRules = "-There is 18 age limit." +
                     "- Participants / viewers must follow the rules received under COVID-19.",
                     TicketPrice = 300,
                     ArtistId = 3,
                     PlaceId = 1,

                 },
                 new Concert
                 {
                     Id = 6,
                     Date = new DateTime(2022, 11, 5),
                     EventRules = "-There is 18 age limit." +
                     "- Participants / viewers must follow the rules received under COVID-19.",
                     TicketPrice = 530,
                     ArtistId = 3,
                     PlaceId = 2,

                 }
                );

        }
    }
}
