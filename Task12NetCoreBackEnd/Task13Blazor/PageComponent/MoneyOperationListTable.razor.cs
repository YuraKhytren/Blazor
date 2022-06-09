using Microsoft.AspNetCore.Components;
using Task13Blazor.Models;
using Task13Blazor.Services.Interfaces;

namespace Task13Blazor.PageComponent
{
    public partial class MoneyOperationListTable : ComponentBase
    {
        [Inject] IServices<MoneyOperationModel> _db { get; set; }
        [Parameter] public int FinTypeId { get; set; }
        IEnumerable<MoneyOperationModel> moneyOperationModels { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var list =  await _db.GetAllAsync();
            moneyOperationModels = list.Where(c => c.FinanceTypeId == FinTypeId);
        }

        async Task Delete(int id) 
        {
            _db.DeleteAsync(id);
        }
    }
}
