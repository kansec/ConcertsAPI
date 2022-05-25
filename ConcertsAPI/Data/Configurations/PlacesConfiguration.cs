using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcertsAPI.Data.Configurations
{
    public class PlacesConfiguration : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.HasData(
                new Place
                {
                    Id = 1,
                    Name = "Vodafone Arena",
                    Country = "Turkey",
                    City = "Istanbul",
                    AdressDetails = "Visnezade, Dolmabahce No:1, 34357",
                    ContactEmail = "management@vodafonearena.com",
                    ContactPhoneNumber = "12412422"
                },
                new Place
                {
                    Id = 2,
                    Name = "The O2 Arena",
                    Country = "UK",
                    City = "London",
                    AdressDetails = "Peninsula Square, London SE10 0DX",
                    ContactEmail = "management@o2arena.com",
                    ContactPhoneNumber = "12892422"
                },
                new Place
                {
                    Id = 3,
                    Name = "Nippon Budokann",
                    Country = "Japan",
                    City = "Tokyo",
                    AdressDetails = "2-3 Kitanomarukoen, Chiyoda City, Tokyo 102-8321",
                    ContactEmail = "management@nipponbudokann.com",
                    ContactPhoneNumber = "398923221"
                }

            );
        }
    }
}
