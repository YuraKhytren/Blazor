using System.ComponentModel.DataAnnotations;

namespace Task13Blazor.Models
{
    public class FinanceTypeModel : BaseModel
    {
       
        public string Name { get; set; }
       
        public bool Income { get; set; }
    }
}
