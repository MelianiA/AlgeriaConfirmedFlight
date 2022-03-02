using AlgeriaConfirmedFlight.API.Repository;
using AlgeriaConfirmedFlight.API.ViewModel;
using AlgeriaConfirmedFlight.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlgeriaConfirmedFlight.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolConfirmeController : Controller
    {
        private readonly IVolConfirmeRepository volConfirmeRepository;
        public VolConfirmeController(IVolConfirmeRepository vol )
        {
            volConfirmeRepository = vol;
        }

        // GET: VolConfirmeController
        public IEnumerable<VolConfirmeViewModel> Index()
        {
            return volConfirmeRepository.GetAllVolConfirmes().ToList();
        }
      
    }
}
