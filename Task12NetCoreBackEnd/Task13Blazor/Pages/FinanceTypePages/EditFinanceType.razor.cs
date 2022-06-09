using Microsoft.AspNetCore.Components;
using Task13Blazor.Models;
using Task13Blazor.Services.Interfaces;

namespace Task13Blazor.Pages.FinanceTypePages
{
    public partial class EditFinanceType : ComponentBase
    {
        [Inject]
        public IServices<FinanceTypeModel> _db { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        [Parameter] public int TypeId { get; set; }

        FinanceTypeModel model = new();

        protected override async Task OnInitializedAsync()
        {
            model = await _db.GetByIdAsync(TypeId);
        }

       async Task Update() 
        {
            await _db.UpdateAsync(model);
            NavigationManager.NavigateTo("/");
        }
    }
}
