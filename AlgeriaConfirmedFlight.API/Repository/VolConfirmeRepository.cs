using AlgeriaConfirmedFlight.API.Model;
using AlgeriaConfirmedFlight.Shared.Model;
using AlgeriaConfirmedFlight.Shared.ViewModel;

namespace AlgeriaConfirmedFlight.API.Repository
{
    public class VolConfirmeRepository : IVolConfirmeRepository
    {
        private readonly AppDbContext db;
        public VolConfirmeRepository(AppDbContext appDb)
        {
            this.db = appDb;
        }
        public Task<VolComfirme> CreateVolConfirme(VolComfirme volComfirme)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteVolConfirme(Guid volId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VolConfirmeViewModel> GetAllVolConfirmes()
        {
            try
            {
                var vols = db.VolComfirme.Select(x=> new VolConfirmeViewModel
                {
                    Id= x.Id,
                    Compagnie = db.Compagnie.SingleOrDefault(c=> c.Id == x.Compagnie),
                    DateFin = x.DateFin,
                    JourDeVol = x.JourDeVol,
                    VilleArrivee = x.VilleArrivee,
                    VilleDepart = x.VilleDepart
                } ) ;
              
                return vols; 
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Task<VolComfirme> UpdateVolConfirme(Guid volId, VolComfirme volComfirme)
        {
            throw new NotImplementedException();
        }
    }
}
