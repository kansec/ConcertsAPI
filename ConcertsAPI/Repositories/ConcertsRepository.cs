using ConcertsAPI.Contracts;
using ConcertsAPI.Data;

namespace ConcertsAPI.Repositories
{
    public class ConcertsRepository :  GenericRepository<Concert>, IConcertsRepository
    {

        public ConcertsRepository(ConcertsDbContext context) : base(context)
        {

        }
    }
}
