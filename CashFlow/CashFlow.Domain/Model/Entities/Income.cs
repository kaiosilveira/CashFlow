namespace CashFlow.Domain.Model.Entities
{
    public class Income : Transaction
    {
        public int Id { get; set; }
        public IncomeType Type { get; set; }
        public int CompanyId { get; set; }
    }
}
