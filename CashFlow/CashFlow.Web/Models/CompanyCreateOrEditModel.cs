using System.ComponentModel.DataAnnotations;

namespace CashFlow.Web.Models
{
    public class CompanyCreateOrEditModel
    {
        public int Id { get; set; }

        [Display(Name = "Razão Social")]
        public string Name { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string FantasyName { get; set; }

        [Display(Name = "CNPJ")]
        public string Register { get; set; }
    }
}