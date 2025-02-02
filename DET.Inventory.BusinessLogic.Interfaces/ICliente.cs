
using DET.Inventory.Models;

namespace DET.Inventory.BusinessLogic.Interfaces
{
    public interface ICliente
    {
        Task<List<Cliente>> ListarClientes(Cliente cliente);
        Task<Cliente> GuardarCliente(Cliente cliente);
    }
}
