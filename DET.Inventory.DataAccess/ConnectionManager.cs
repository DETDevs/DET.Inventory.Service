using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.DataAccess
{
    public class ConnectionManager : IConnectionManager
    {
        public const string InventoryConnectionString_KEY = "InventoryConnectionString_DB";
        private readonly IConfiguration configuration;

        public ConnectionManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IDbConnection GetConnection(string key)
        {
            return new SqlConnection(ConfigurationExtensions.GetConnectionString(configuration, $"{InventoryConnectionString_KEY}"));
        }
    }
}
