using AlgeriaConfirmedFlight.API.Model;
using AlgeriaConfirmedFlight.Model;

namespace AlgeriaConfirmedFlight.API.Repository
{
    public class CompagnieRepository : ICompagnieRepository
    {
        private readonly AppDbContext db;
        public CompagnieRepository(AppDbContext appDb)
        {
            this.db = appDb;
        }

        public IEnumerable<Compagnie> GetCompagnies()
        {
            return db.Compagnie;
        }
    }
}
