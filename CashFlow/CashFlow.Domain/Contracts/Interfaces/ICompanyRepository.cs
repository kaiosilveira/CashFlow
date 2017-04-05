using CashFlow.Domain.Model.Entities;
using System.Collections.Generic;

namespace CashFlow.Domain.Contracts.Interfaces
{
    public interface ICompanyRepository
    {
        Company Get(int id);

        IEnumerable<Company> List();

        int Update(Company company);

        int Create(Company company);

        int Delete(int id);
    }
}
