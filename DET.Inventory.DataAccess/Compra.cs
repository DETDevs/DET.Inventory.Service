
using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.DataAccess
{
    public class Compra : ICompra
    {
        private IConnectionManager _connectionManager;

        public Compra(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }
    }
}
