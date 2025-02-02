using DAI = DET.Inventory.DataAccess.Interfaces;
using BLI = DET.Inventory.BusinessLogic.Interfaces;

namespace DET.Inventory.BusinessLogic
{
    public class Cliente : BLI.ICliente
    {
        private readonly DAI.ICliente _cliente;

        public Cliente(DAI.ICliente cliente)
        {
            _cliente = cliente;
        }

        public Task<Models.Cliente> GuardarCliente(Models.Cliente cliente)
        {
            return _cliente.GuradarCliente(cliente);
        }

        public Task<List<Models.Cliente>> ListarClientes(Models.Cliente cliente)
        {
            return _cliente.ListarClientes(cliente);
        }
    }
}
