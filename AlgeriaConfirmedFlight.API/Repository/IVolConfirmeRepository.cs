using AlgeriaConfirmedFlight.API.ViewModel;
using AlgeriaConfirmedFlight.Model;

namespace AlgeriaConfirmedFlight.API.Repository
{
    public interface IVolConfirmeRepository
    {
        public Task<VolComfirme> CreateVolConfirme(VolComfirme volComfirme);
        public Task<VolComfirme> UpdateVolConfirme(Guid volId, VolComfirme volComfirme);
        //public Task<VolComfirme> GetHotelRoom(int roomId, string checkInDate = null, string checkOutDate = null);
        public IEnumerable<VolConfirmeViewModel> GetAllVolConfirmes();
        public Task<int> DeleteVolConfirme(Guid volId);
    }
}
