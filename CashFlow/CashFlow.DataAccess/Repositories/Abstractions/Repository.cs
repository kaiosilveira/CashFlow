using CashFlow.DataAccess.Factories;
using CashFlow.Domain.Model.Enumerators;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CashFlow.DataAccess.Repositories.Abstractions
{
    public abstract class Repository
    {
        protected T QuerySingle<T>(string sql, object parameters)
        {
            using (var con = new ConnectionFactory().GetConnection(ConnectionStrings.CashFlow))
            {
                return con.QuerySingle<T>(sql, parameters);
            }
        }

        protected async Task<T> QuerySingleAsync<T>(string sql, object parameters)
        {
            using (var con = new ConnectionFactory().GetConnection(ConnectionStrings.CashFlow))
            {
                return await con.QuerySingleAsync<T>(sql, parameters);
            }
        }

        protected IEnumerable<T> Query<T>(string sql, object parameters)
        {
            using (var con = new ConnectionFactory().GetConnection(ConnectionStrings.CashFlow))
            {
                return con.Query<T>(sql, parameters);
            }
        }

        protected async Task<IEnumerable<T>> QueryAsync<T>(string sql, object parameters)
        {
            using (var con = new ConnectionFactory().GetConnection(ConnectionStrings.CashFlow))
            {
                return await con.QueryAsync<T>(sql, parameters);
            }
        }

        protected void Execute(string sql, object parameters)
        {
            using (var con = new ConnectionFactory().GetConnection(ConnectionStrings.CashFlow))
            {
                con.Execute(sql, parameters);
            }
        }

        protected async Task ExecuteAsync(string sql, object parameters)
        {
            using (var con = new ConnectionFactory().GetConnection(ConnectionStrings.CashFlow))
            {
                await con.ExecuteAsync(sql, parameters);
            }
        }
    }
}
