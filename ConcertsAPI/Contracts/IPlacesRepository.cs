using ConcertsAPI.Data;

namespace ConcertsAPI.Contracts
{
    public interface IPlacesRepository : IGenericRepository<Place>
    {
        public  Place GetPlaceDetails(int id);

    }
}
