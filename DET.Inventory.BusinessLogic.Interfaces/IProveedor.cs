
using DET.Inventory.Models;

namespace DET.Inventory.BusinessLogic.Interfaces
{
    public interface IProveedor
    {
        Task<List<Proveedor>> ListarProveedores(Proveedor proveedor);
        Task<Proveedor> GuardarProveeedor(Proveedor proveedor);
    }
}
