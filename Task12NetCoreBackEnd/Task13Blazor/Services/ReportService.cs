using Task13Blazor.Models;
using Task13Blazor.Services.Interfaces;

namespace Task13Blazor.Services
{
    public class ReportService : IReport
    {
        private readonly HttpClient _httpClient;
        public ReportService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Report> GetBetweenDatesAsync(DateTime startDate, DateTime endDate)
        {
            var responseMessage = await _httpClient.GetAsync($"api/Report/{startDate}&{endDate}");
            var content = responseMessage.Content;
            var model = await content.ReadFromJsonAsync<Report>();


            return model;
        }

        public async Task<Report> GetByDateAsync(DateTime date)
        {
            var stringDate = date.ToString("dd.MM.yyyy");
            var responseMessage = await _httpClient.GetAsync($"api/Report/{stringDate}");
            var content = responseMessage.Content;
            var model = await content.ReadFromJsonAsync<Report>();


            return model;
        }
    }
}
