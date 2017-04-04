using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Domain.Model.Entities
{
    class Cost : Transaction
    {
        public int Id { get; set; }
        public CostType Type { get; set; }
    }
}
