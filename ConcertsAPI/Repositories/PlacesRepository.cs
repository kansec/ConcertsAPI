using ConcertsAPI.Contracts;
using ConcertsAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ConcertsAPI.Repositories
{
    public class PlacesRepository : GenericRepository<Place>, IPlacesRepository
    {
        private readonly ConcertsDbContext _concertsDbContext;
        public PlacesRepository(ConcertsDbContext context) : base(context)
        {
            _concertsDbContext = context;
        }

        public async Task<Place> GetPlaceDetails(int id)
        {
            var result =  _concertsDbContext.Places.Include(n => n.Concerts).Where(n => n.Id == id);



        }
    }
}
