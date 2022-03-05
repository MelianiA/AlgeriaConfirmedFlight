using AlgeriaConfirmedFlight.Shared.Model;
using AlgeriaConfirmedFlight.Shared.ViewModel;

namespace AlgeriaConfirmedFlightWASM.Services
{
    public interface IVolConfirmeService
    {
        Task<List<VolComfirme>> GetAllVols();
        Task<List<Compagnie>> GetAllCompagnies();
        Task<HttpResponseMessage> AjouterVolConirme(VolComfirme vol);
        Task<HttpResponseMessage> ModifierVolConirme(VolComfirme vol);
        Task<HttpResponseMessage> SupprimerVolConirme(Guid id);
    }
}
