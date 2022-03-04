using AlgeriaConfirmedFlight.Shared.Model;

namespace AlgeriaConfirmedFlightWASM.StaticCode
{
    public static class StaticsElements
    {
        public static string CodeSecret { get; set; } = "";
        public static List<Compagnie> CmpsBase { get; set; } = new List<Compagnie>();

        public static bool SecretValide()
        {
            return CodeSecret.Equals("abc",StringComparison.OrdinalIgnoreCase);
        }


    }
}
