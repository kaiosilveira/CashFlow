using CashFlow.Domain.Model.Enumerators;
using CashFlow.NetFramework.Providers;
using System.Data;
using System.Data.SqlClient;

namespace CashFlow.DataAccess.Factories
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection(ConnectionStrings connectionString)
        {
            var con = new SqlConnection(ConfigurationProvider.GetConnectionString(connectionString));
            con.Open();
            return con;
        }
    }
}
