
using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.DataAccess
{
    public class MovimientoInventario : IMovimientoInventario
    {
        private IConnectionManager _connectionManager;

        public MovimientoInventario(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }
    }
}
