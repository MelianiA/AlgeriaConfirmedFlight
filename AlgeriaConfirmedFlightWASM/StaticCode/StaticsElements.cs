using AlgeriaConfirmedFlight.Shared.Model;
using Microsoft.AspNetCore.Components;

namespace AlgeriaConfirmedFlightWASM.StaticCode
{
    public class StaticsElements : ComponentBase
    {
        public static string CodeSecret { get; set; } = "";
        public static List<Compagnie> CmpsBase { get; set; } = new List<Compagnie>();

        public static bool SecretValide()
        {
            return CodeSecret.Equals("abc", StringComparison.OrdinalIgnoreCase);
        }


    }
}
