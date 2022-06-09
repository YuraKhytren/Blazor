
using System.Text;
using System.Text.Json;
using Task13Blazor.Models;
using Task13Blazor.Services.Interfaces;

namespace Task13Blazor.Services
{
    public class MoneyOperationService : IServices<MoneyOperationModel>
    {
        private readonly HttpClient _httpClient;
        public MoneyOperationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task CreateAsync(MoneyOperationModel model)
        {
            var jsonModel = JsonSerializer.Serialize(model);
            HttpContent content = new StringContent(jsonModel, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("api/MoneyOperations", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/MoneyOperations/{id}");
        }

        public async Task<IEnumerable<MoneyOperationModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync("api/MoneyOperations");
            var content = responseMessage.Content;
            var list = await content.ReadFromJsonAsync<IEnumerable<MoneyOperationModel>>();

            return list;
        }

        public async Task<MoneyOperationModel> GetByIdAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"api/MoneyOperations/{id}");
            var content = responseMessage.Content;
            var model = await content.ReadFromJsonAsync<MoneyOperationModel>();   

            return model;
        }

        public async Task UpdateAsync(MoneyOperationModel model)
        {
            var jsonModel = JsonSerializer.Serialize(model);
            HttpContent content = new StringContent(jsonModel, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/MoneyOperations", content);
        }
    }
}
