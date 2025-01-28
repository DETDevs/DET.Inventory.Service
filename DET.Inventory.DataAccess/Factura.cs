
using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.DataAccess
{
    public class Factura : IFactura
    {
        private IConnectionManager _connectionManager;

        public Factura(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }
    }
}
