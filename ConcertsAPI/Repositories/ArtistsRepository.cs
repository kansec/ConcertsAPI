using ConcertsAPI.Contracts;
using ConcertsAPI.Data;

namespace ConcertsAPI.Repositories
{
    public class ArtistsRepository : GenericRepository<Artist>, IArtistsRepository
    {
        public ArtistsRepository(ConcertsDbContext context) : base(context)
        {
        }
    }
}
