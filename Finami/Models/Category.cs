namespace Finami.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; } // for chart
        public TransactionType Type { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
