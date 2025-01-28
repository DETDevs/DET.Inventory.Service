
using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.DataAccess
{
    public class DetalleCompra : IDetalleCompra
    {
        private IConnectionManager _connectionManager;

        public DetalleCompra(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }
    }
}
