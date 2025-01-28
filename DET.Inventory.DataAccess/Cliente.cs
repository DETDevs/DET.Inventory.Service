
using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.DataAccess
{
    public class Cliente : ICliente
    {
        private IConnectionManager _connectionManager;

        public Cliente(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }
    }
}
