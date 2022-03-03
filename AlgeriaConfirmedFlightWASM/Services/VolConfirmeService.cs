using AlgeriaConfirmedFlight.Shared.Model;
using AlgeriaConfirmedFlight.Shared.ViewModel;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace AlgeriaConfirmedFlightWASM.Services
{
    public class VolConfirmeService : IVolConfirmeService
    {
        private readonly HttpClient client;
        public VolConfirmeService(HttpClient http )
        {
            client = http;
        }

        public async Task<List<Compagnie>> GetAllCompagnies()
        {
            return await client.GetFromJsonAsync<List<Compagnie>>(@"http://www.iasoft.fr/api/VolConfirme/GetCmps");
        }

        public async Task<List<VolComfirme>> GetAllVols()
        {
            try
            {
                return await client.GetFromJsonAsync<List<VolComfirme>>(@"http://www.iasoft.fr/api/VolConfirme/GetAllVols");
            }
            catch (Exception ex)
            {

                return new List<VolComfirme>()
                {
                    new VolComfirme()
                    {
                        VilleDepart="M'SILA"
                    }
                };
            }

        }

    }
}
