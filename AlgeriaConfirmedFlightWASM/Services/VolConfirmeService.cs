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
            return await client.GetFromJsonAsync<List<Compagnie>>(@"VolConfirme/GetCmps");
        }

        public async Task<List<VolComfirme>> GetAllVols()
        {
            try
            {
                return await client.GetFromJsonAsync<List<VolComfirme>>(@"VolConfirme/GetAllVols");
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

        public async Task<HttpResponseMessage> AjouterVolConirme(VolComfirme vol)
        {
            var response = await client.PostAsJsonAsync("VolConfirme/createvol", vol);
            return response;
        }

        public async Task<HttpResponseMessage> ModifierVolConirme(VolComfirme vol)
        {
            var response = await client.PostAsJsonAsync("VolConfirme/UpdateVol", vol);
            return response;
        }

        public async Task<HttpResponseMessage> SupprimerVolConirme(Guid id)
        {
            var response = await client.PostAsJsonAsync("VolConfirme/SupprimeVol", id);
            return response;
        }
    }
}
