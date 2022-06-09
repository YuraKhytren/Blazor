namespace Task13Blazor.Models
{
    public class Report
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalOutcome { get; set; }
        public List<MoneyOperationModel> Operations { get; set; }
    }
}
