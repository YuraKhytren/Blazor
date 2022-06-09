using Microsoft.AspNetCore.Components;
using Task13Blazor.Models;
using Task13Blazor.Services.Interfaces;

namespace Task13Blazor.Pages.MoneyOperationPages
{
    public partial class CreateMoneyOperation : ComponentBase
    {
        [Inject] IServices<MoneyOperationModel> _db { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        [Parameter] public int FinanceTypeId { get; set; }
        MoneyOperationModel model = new ();
        async Task Create()
        {
            model.FinanceTypeId = FinanceTypeId;
            
            await _db.CreateAsync(model);
            NavigationManager.NavigateTo($"/MoneyOperation/{FinanceTypeId}");

        }
    }
}
