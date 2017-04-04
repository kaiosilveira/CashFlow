using CashFlow.Domain.Model.Enumerators;
using System.Configuration;

namespace CashFlow.NetFramework.Providers
{
    public static class ConfigurationProvider
    {
        public static string GetConnectionString(ConnectionStrings connectionString)
        {
            return ConfigurationManager.ConnectionStrings[connectionString.ToString()].ConnectionString;
        }
    }
}
