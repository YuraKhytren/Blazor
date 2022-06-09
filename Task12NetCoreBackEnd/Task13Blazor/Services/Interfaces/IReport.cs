using Task13Blazor.Models;

namespace Task13Blazor.Services.Interfaces
{
    public interface IReport
    {
        Task<Report> GetByDateAsync(DateTime date);
        Task<Report> GetBetweenDatesAsync(DateTime startDate, DateTime endDate);
    }
}
