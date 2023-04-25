using MudblazorDemo.CRUD.Data;
using MudblazorDemo.CRUD.Pages;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MudblazorDemo.CRUD.Services
{
    public interface ILocationService
    {
        Task<IEnumerable<Countries>> GetCountriesAsync();
        Task<IEnumerable<States>> GetStatesAsync(int countryId);
        Task<IEnumerable<Cities>> GetCitiesAsync(int stateId);
    }

    public class LocationService : ILocationService
    {
        private readonly HttpClient _httpClient;

        public LocationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Countries>> GetCountriesAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Countries>>("/api/countries");
        }

        public async Task<IEnumerable<States>> GetStatesAsync(int countryId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<States>>($"/api/states?countryId={countryId}");
        }

        public async Task<IEnumerable<Cities>> GetCitiesAsync(int stateId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Cities>>($"/api/cities?stateId={stateId}");
        }
    }

}
