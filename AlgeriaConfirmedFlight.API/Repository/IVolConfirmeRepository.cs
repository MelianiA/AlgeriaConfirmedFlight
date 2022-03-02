using AlgeriaConfirmedFlight.Shared.Model;
using AlgeriaConfirmedFlight.Shared.ViewModel;

namespace AlgeriaConfirmedFlight.API.Repository
{
    public interface IVolConfirmeRepository
    {
        public Task<VolComfirme> CreateVolConfirme(VolComfirme volComfirme);
        public Task<VolComfirme> UpdateVolConfirme(Guid volId, VolComfirme volComfirme);
        //public Task<VolComfirme> GetHotelRoom(int roomId, string checkInDate = null, string checkOutDate = null);
        public IEnumerable<VolComfirme> GetAllVolConfirmes();
        public IEnumerable<Compagnie> GetCompagnies();
        public Task<int> DeleteVolConfirme(Guid volId);
    }
}
