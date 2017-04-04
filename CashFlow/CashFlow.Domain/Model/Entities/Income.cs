using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Domain.Model.Entities
{
    class Income : Transaction
    {
        public int Id { get; set; }
        public IncomeType Type { get; set; }
    }
}
