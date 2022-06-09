using Microsoft.AspNetCore.Components;
using Task13Blazor.Models;
using Task13Blazor.Services.Interfaces;

namespace Task13Blazor.Pages.ReportPages
{
    public partial class DayReport
    {
        [Inject] IReport _db { get; set; }
        public DateTime DateFrom { get; set; }
        
        Report report;
        bool showTable = false;
      
        async Task GetReport()
        {
            report = await _db.GetByDateAsync(DateFrom);
            showTable = true;
        }
    }
}

