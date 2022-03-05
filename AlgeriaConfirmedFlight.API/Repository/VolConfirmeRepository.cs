using AlgeriaConfirmedFlight.API.Model;
using AlgeriaConfirmedFlight.Shared.Model;
using AlgeriaConfirmedFlight.Shared.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace AlgeriaConfirmedFlight.API.Repository
{
    public class VolConfirmeRepository : IVolConfirmeRepository
    {
        private readonly AppDbContext db;
        public VolConfirmeRepository(AppDbContext appDb)
        {
            this.db = appDb;
        }
        public async Task<bool> CreateVolConfirme(VolComfirme volComfirme)
        {
            try
            {
                db.Add(volComfirme);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public async Task<bool> DeleteVolConfirme(Guid volId)
        {
            try
            {
                var vol = db.VolComfirme.SingleOrDefault(v => v.Id == volId);
                if (vol != null)
                {
                    db.VolComfirme.Remove(vol);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<VolComfirme> GetAllVolConfirmes()
        {
            try
            {
                var vols = db.VolComfirme.Select(x => new VolComfirme
                {
                    Id = x.Id,
                    Compagnie = x.Compagnie,
                    DateFin = x.DateFin,
                    JourDeVol = x.JourDeVol,
                    VilleArrivee = x.VilleArrivee,
                    VilleDepart = x.VilleDepart
                });

                return vols;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<Compagnie> GetCompagnies()
        {
            return db.Compagnie;
        }

        public async Task<bool> UpdateVolConfirme(VolComfirme volComfirme)
        {
            try
            {
                var vol = db.VolComfirme.Attach(volComfirme);
                vol.State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
