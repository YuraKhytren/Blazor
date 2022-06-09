namespace Task13Blazor.Models
{
    public class MoneyOperationModel : BaseModel
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Money { get; set; }
        public int FinanceTypeId { get; set; }
        public FinanceTypeModel FinanceType { get; set; } 

    }
}
