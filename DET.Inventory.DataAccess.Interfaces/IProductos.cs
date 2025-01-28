using DET.Inventory.Models;

namespace DET.Inventory.DataAccess.Interfaces
{
    public interface IProductos
    {
        Task<List<Productos>> ListarProductos();
    }
}
