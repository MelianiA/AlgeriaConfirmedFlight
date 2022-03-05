using AlgeriaConfirmedFlight.Shared.Model;
using AlgeriaConfirmedFlight.Shared.ViewModel;

namespace AlgeriaConfirmedFlight.API.Repository
{
    public interface IVolConfirmeRepository
    {
        public Task<bool> CreateVolConfirme(VolComfirme volComfirme);
        public Task<bool> UpdateVolConfirme(VolComfirme volComfirme);
        public IEnumerable<VolComfirme> GetAllVolConfirmes();
        public IEnumerable<Compagnie> GetCompagnies();
        public Task<bool> DeleteVolConfirme(Guid volId);
    }
}
