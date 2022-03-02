using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlgeriaConfirmedFlight.Model
{
    public class VolComfirme
    {
        [Key]
        public Guid Id { get; set; }  
        public Guid Compagnie { get; set; }
        public string VilleDepart { get; set; }
        public string VilleArrivee { get; set; }
        public DateTime DateFin { get; set; }
        public string JourDeVol { get; set; }
    }
}