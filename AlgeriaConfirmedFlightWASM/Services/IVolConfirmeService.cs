using AlgeriaConfirmedFlight.Shared.Model;
using AlgeriaConfirmedFlight.Shared.ViewModel;

namespace AlgeriaConfirmedFlightWASM.Services
{
    public interface IVolConfirmeService
    {
        Task<List<VolComfirme>> GetAllVols();
        Task<List<Compagnie>> GetAllCompagnies();
    }
}
