using CashFlow.DataAccess.Factories;
using CashFlow.Domain.Model.Enumerators;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Linq;

namespace CashFlow.DataAccess.Repositories.Abstractions
{
    public abstract class Repository
    {
        private TReturn Disptach<TReturn>(Func<IDbConnection, TReturn> query)
        {
            using (var con = new ConnectionFactory().GetConnection(ConnectionStrings.CashFlow))
            {
                return query(con);
            }
        }

        private async Task<TReturn> Disptach<TReturn>(Func<IDbConnection, Task<TReturn>> query)
        {
            using (var con = new ConnectionFactory().GetConnection(ConnectionStrings.CashFlow))
            {
                return await query(con);
            }
        }

        protected IEnumerable<T> Perform<T>(string query, object parameters)
        {
            return this.Disptach<IEnumerable<T>>((con) =>
            {
                return con.Query<T>(query, parameters);
            });
        }

        protected Task<IEnumerable<T>> PerformAsync<T>(string query, object parameters)
        {
            return this.Disptach<IEnumerable<T>>(async (con) =>
            {
                return await con.QueryAsync<T>(query, parameters);
            });
        }

        protected T PerformSingle<T>(string query, object parameters)
        {
            return this.Disptach<T>((con) =>
            {
                return con.QuerySingle<T>(query, parameters);
            });
        }

        protected Task<T> PerformSingleAsync<T>(string query, object parameters)
        {
            return this.Disptach<T>(async (con) =>
            {
                return await con.QuerySingleAsync<T>(query, parameters);
            });
        }
    }
}
