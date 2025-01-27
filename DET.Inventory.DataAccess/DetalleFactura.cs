
using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.DataAccess
{
    public class DetalleFactura : IDetalleFactura
    {
        private IConnectionManager _connectionManager;

        public DetalleFactura(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }
    }
}
