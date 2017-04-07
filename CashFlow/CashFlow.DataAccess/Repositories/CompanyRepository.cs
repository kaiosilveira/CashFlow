﻿using CashFlow.DataAccess.Repositories.Abstractions;
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
            string query = @"insert into company(name, register) values (@name, @register) select @@ROWCOUNT";
            var parameters = new { @name = company.Name, @register = company.Register };
            return base.PerformSingle<int>(query, parameters);
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Company Get(int id)
        {
            var query = @"select c.id, c.name, c.fantasy_name, c.register from company as c where c.id = @id";
            return base.PerformSingle<Company>(query, new { @id = id });
        }

        public IEnumerable<Company> List()
        {
            return base.Perform<Company>("select id, name, register from company", null);
        }

        public int Update(Company company)
        {
            string query = @"update company(Name, Register)
                            set name = @name,
                            register = @register
                            where id = @id  

                            select @@ROWCOUNT";

            var parameters = new { @id = company.Id, @name = company.Name, @register = company.Register };
            return base.PerformSingle<int>(query, parameters);
        }
    }
}
