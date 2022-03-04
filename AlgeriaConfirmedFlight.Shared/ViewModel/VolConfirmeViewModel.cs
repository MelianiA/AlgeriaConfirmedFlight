using AlgeriaConfirmedFlight.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgeriaConfirmedFlight.Shared.ViewModel
{
    public class VolConfirmeViewModel
    {
        public Guid Id { get; set; }
        public Compagnie Compagnie { get; set; }
        public string VilleDepart { get; set; }
        public string VilleArrivee { get; set; }
        public DateTime? DateFin { get; set; }
        public string JourDeVol { get; set; }
    }
}
