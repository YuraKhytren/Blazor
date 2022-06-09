using System.Text;
using System.Text.Json;
using Task13Blazor.Models;
using Task13Blazor.Services.Interfaces;


namespace Task13Blazor.Services
{
    public class FinanceTypeService : IServices<FinanceTypeModel>
    {
       private readonly HttpClient _httpClient;
        public FinanceTypeService(HttpClient client) 
        {
            _httpClient = client;   
        }
        public async Task CreateAsync(FinanceTypeModel model)
        {
            var jsonModel = JsonSerializer.Serialize(model);
            HttpContent content = new StringContent(jsonModel, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("api/FinanceTypes", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/FinanceTypes/{id}");
        }

        public async Task<IEnumerable<FinanceTypeModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync($"api/FinanceTypes");
            var content = responseMessage.Content;
            var list = await content.ReadFromJsonAsync<IEnumerable<FinanceTypeModel>>();

            return list;
        }

        public async Task<FinanceTypeModel> GetByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"api/FinanceTypes/{id}");
            var content = responseMessage.Content;
            var model = await content.ReadFromJsonAsync<FinanceTypeModel>();
            

            return model;
        }

        public async Task UpdateAsync(FinanceTypeModel model)
        {
            var jsonModel = JsonSerializer.Serialize(model);
            HttpContent content = new StringContent(jsonModel, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/FinanceTypes", content);
        }
    }
}
