using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Domain.Model.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public bool Paid { get; set; }
        public decimal Price { get; set; }
        public ProjectStatus Status { get; set; }
        public List<Income> Incomes { get; set; }
        public List<Cost> Costs { get; set; }
    }
}
