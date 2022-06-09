using Microsoft.AspNetCore.Components;
using Task13Blazor.Models;
using Task13Blazor.Services.Interfaces;

namespace Task13Blazor.PageComponent
{
    public partial class FinanceTypeListTable : ComponentBase
    {
        [Inject]
        public IServices<FinanceTypeModel> _db { get; set; }
        

        IEnumerable<FinanceTypeModel> financeTypes;


        protected override async Task OnInitializedAsync()
        {
            financeTypes = await _db.GetAllAsync();
        }

        async Task Delete(int id)
        {
          await  _db.DeleteAsync(id);
         
        }
    }
}
