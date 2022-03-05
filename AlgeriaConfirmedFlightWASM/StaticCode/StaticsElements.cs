using AlgeriaConfirmedFlight.Shared.Model;
using Microsoft.AspNetCore.Components;

namespace AlgeriaConfirmedFlightWASM.StaticCode
{
    public class StaticsElements 
    {
        public static string CodeSecret { get; set; } = "";
        public static List<Compagnie> CmpsBase { get; set; } = new List<Compagnie>();
        public static List<VolComfirme> VolsBase { get; set; } = new List<VolComfirme>();


        public static bool SecretValide()
        {
            return CodeSecret.Equals("123vivabladi", StringComparison.OrdinalIgnoreCase);
        }


    }
}
