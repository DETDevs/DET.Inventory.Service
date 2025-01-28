
using Dapper;
using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.DataAccess
{
    public class Categoria : ICategoria
    {
        private IConnectionManager _connectionManager;

        public Categoria(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }

        public async Task<List<Models.Categoria>> ListarCategorias()
        {
            using var connection = this._connectionManager.GetConnection(ConnectionManager.InventoryConnectionString_KEY);

            var result = await connection.QueryAsync<Models.Categoria>("SELECT * FROM Categoria");

            return result.ToList();
        }
    }
}
