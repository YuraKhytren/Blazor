using Microsoft.AspNetCore.Components;
using Task13Blazor.Models;
using Task13Blazor.Services.Interfaces;

namespace Task13Blazor.PageComponent
{
    public partial class ReportListTable : ComponentBase
    {
        [Parameter] public Report Report { get; set; }
    }
}