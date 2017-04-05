using CashFlow.DataAccess.Repositories.Abstractions;
using CashFlow.Domain.Contracts.Interfaces;
using CashFlow.Domain.Model.Entities;
using System;
using System.Collections.Generic;

namespace CashFlow.DataAccess.Repositories
{
    public class CompanyRepository : Repository, ICompanyRepository
    {
        public int Create(Company company)
        {
            string sql = @"insert into company(name, register) values (@name, @register) select @@ROWCOUNT";
            var parameters = new { @name = company.Name, @register = company.Register };
            return base.QuerySingle<int>(sql, parameters);
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Company Get(int id)
        {
            var sql = @"select c.id, c.name, c.fantasy_name, c.register from company as c where c.id = @id";
            return base.QuerySingle<Company>(sql, new { @id = id });
        }

        public IEnumerable<Company> List()
        {
            return base.Query<Company>("select id, name, register from company", null);
        }

        public int Update(Company company)
        {
            string sql = @"update company(Name, Register)
                            set name = @name,
                            register = @register
                            where id = @id  

                            select @@ROWCOUNT";

            var parameters = new { @id = company.Id, @name = company.Name, @register = company.Register };
            return base.QuerySingle<int>(sql, parameters);
        }
    }
}
