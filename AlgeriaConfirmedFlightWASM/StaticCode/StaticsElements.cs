namespace AlgeriaConfirmedFlightWASM.StaticCode
{
    public class StaticsElements
    {
        public static string CodeSecret { get; set; } = "";

        public static bool SecretValide()
        {
            return CodeSecret.Equals("abc",StringComparison.OrdinalIgnoreCase);
        }


    }
}
