
using DET.Inventory.Models;

namespace DET.Inventory.BusinessLogic.Interfaces
{
    public interface ICategoria
    {
        Task<List<Categoria>> ListarCategorias();
    }
}
