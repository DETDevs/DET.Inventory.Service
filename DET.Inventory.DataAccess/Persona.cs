
using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.DataAccess
{
    public class Persona : IPersona
    {
        private IConnectionManager _connectionManager;

        public Persona(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }
    }
}
