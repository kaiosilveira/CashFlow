using CashFlow.Domain.Model.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CashFlow.Web.Models
{
    public class CompanyDetailsModel
    {
        public int Id { get; set; }

        [Display(Name = "Razão Social")]
        public string Name { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string FantasyName { get; set; }
        
        [Display(Name = "CNPJ")]
        public string Register { get; set; }

        public IList<Project> Projects { get; set; }

        public IList<Cost> Costs { get; set; }

        public IList<Income> Incomes { get; set; }
    }
}