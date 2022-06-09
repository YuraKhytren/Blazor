using Microsoft.AspNetCore.Components;
using Task13Blazor.Models;
using Task13Blazor.Services.Interfaces;

namespace Task13Blazor.Pages.FinanceTypePages
{
    public partial class CreateFinanceType : ComponentBase
    {
        [Inject] IServices<FinanceTypeModel> _db { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        FinanceTypeModel model = new();
        async Task Create()
        {
           await _db.CreateAsync(model);
            NavigationManager.NavigateTo("/");

        }
    }
}
