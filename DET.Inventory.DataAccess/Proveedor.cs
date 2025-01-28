
using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.DataAccess
{
    public class Proveedor : IProveedor
    {
        private IConnectionManager _connectionManager;

        public Proveedor(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }
    }
}
