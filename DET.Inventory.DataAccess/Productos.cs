using DET.Inventory.DataAccess.Interfaces;
using Dapper;

namespace DET.Inventory.DataAccess
{
    public class Productos : IProductos
    {
        private IConnectionManager _connectionManager;

        public Productos(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }

        public async Task<List<Models.Productos>> ListarProductos()
        {
            using var connection = this._connectionManager.GetConnection(ConnectionManager.InventoryConnectionString_KEY);

            var result = await connection.QueryAsync<Models.Productos>("SELECT * FROM Product");

            return result.ToList();
        }
    }
}
