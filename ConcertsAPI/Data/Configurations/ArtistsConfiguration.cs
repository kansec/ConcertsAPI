using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcertsAPI.Data.Configurations
{
    public class ArtistsConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasData(
                new Artist
                {
                    Id = 1,
                    ArtistName = "Nirvana",
                    Nationality = "American",
                    ManagerName = "Danny",
                    ManagerLastName = "Goldberg",
                    ContactEmail = "dannyg@nirvana.com",
                    ContactPhoneNumber = "4647478"
                },
                new Artist
                {
                    Id = 2,
                    ArtistName = "Kat Frankie",
                    Nationality = "Australian",
                    ManagerName = "Carol",
                    ManagerLastName = "Jordan",
                    ContactEmail = "carolj@manager.com",
                    ContactPhoneNumber = "31638268"
                },
                new Artist
                {
                    Id = 3,
                    ArtistName = "Tarkan",
                    Nationality = "Turkish",
                    ManagerName = "Benjamin",
                    ManagerLastName = "Kaya",
                    ContactEmail = "benjamink@tarkan.com",
                    ContactPhoneNumber = "5646467"
                }
            );

           
        }
    }
}
