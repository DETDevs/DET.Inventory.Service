
using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.DataAccess
{
    public class HistoricoPrecio : IHistoricoPrecio
    {
        private IConnectionManager _connectionManager;

        public HistoricoPrecio(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }
    }
}
