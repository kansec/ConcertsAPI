using ConcertsAPI.Contracts;
using ConcertsAPI.Data;

namespace ConcertsAPI.Repositories
{
    public class PlacesRepository : GenericRepository<Place>, IPlacesRepository
    {
        public PlacesRepository(ConcertsDbContext context) : base(context)
        {
        }
    }
}
