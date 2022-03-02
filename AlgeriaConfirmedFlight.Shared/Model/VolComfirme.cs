using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgeriaConfirmedFlight.Shared.Model
{
    public class VolComfirme
    {
        public Guid Id { get; set; }
        public Guid Compagnie { get; set; }
        public string VilleDepart { get; set; }
        public string VilleArrivee { get; set; }
        public DateTime DateFin { get; set; }
        public string JourDeVol { get; set; }
    }
}
