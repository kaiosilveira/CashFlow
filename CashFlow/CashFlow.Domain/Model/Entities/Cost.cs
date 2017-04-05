namespace CashFlow.Domain.Model.Entities
{
    public class Cost : Transaction
    {
        public int Id { get; set; }
        public CostType Type { get; set; }
        public int CompanyId { get; set; }
    }
}
