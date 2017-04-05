using CashFlow.Domain.Model.Entities;
using System.Collections.Generic;

namespace CashFlow.Web.Models
{
    public class CompanyModel
    {
        public CompanyModel()
        {
            this.Companies = new List<Company>();
        }

        public IList<Company> Companies { get; set; }
    }
}