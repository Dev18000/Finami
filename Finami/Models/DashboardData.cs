namespace Finami.Models
{
    public class DashboardData
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal Balance => TotalIncome - TotalExpense;

        public List<CategorySummary> CategorySummaries { get; set; }
    }
}
