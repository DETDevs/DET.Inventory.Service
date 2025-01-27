
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
    }
}
