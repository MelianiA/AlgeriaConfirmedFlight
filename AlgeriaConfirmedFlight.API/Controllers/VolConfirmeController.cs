using AlgeriaConfirmedFlight.API.Repository;
using AlgeriaConfirmedFlight.Shared.Model;
using AlgeriaConfirmedFlight.Shared.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AlgeriaConfirmedFlight.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VolConfirmeController : Controller
    {
        private readonly IVolConfirmeRepository volConfirmeRepository;
        public VolConfirmeController(IVolConfirmeRepository vol)
        {
            volConfirmeRepository = vol;
        }

        // GET: VolConfirmeController
        [HttpGet]
        [Route("GetAllVols")]
        public async Task<IEnumerable<VolComfirme>> Index()
        {
            return volConfirmeRepository.GetAllVolConfirmes().ToList();
        }

        [HttpGet]
        [Route("GetCmps")]
        public async Task<IEnumerable<Compagnie>> GetCmps()
        {
            return volConfirmeRepository.GetCompagnies().ToList();
        }

        [HttpPost]
        [Route("createvol")]
        public Guid? CreateVol(VolComfirme vol)
        {
            var ok = volConfirmeRepository.CreateVolConfirme(vol);
            if (ok.Result)
            {
                return vol.Id;
            }
            else
            {
                return null;
            }
        }

        [HttpPost]
        [Route("UpdateVol")]
        public Guid? UpdateVol(VolComfirme vol)
        {
            var ok = volConfirmeRepository.UpdateVolConfirme(vol);
            if (ok.Result)
            {
                return vol.Id;
            }
            else
            {
                return null;
            }
        }

        [HttpPost]
        [Route("SupprimeVol")]
        public Guid? SupprimeVol([FromBody] Guid volId)
        {
            var ok = volConfirmeRepository.DeleteVolConfirme(volId);
            if (ok.Result)
            {
                return volId;
            }
            else
            {
                return null;
            }
        }

    }
}
