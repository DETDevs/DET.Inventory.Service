using DAI = DET.Inventory.DataAccess.Interfaces;
using BLI = DET.Inventory.BusinessLogic.Interfaces;

namespace DET.Inventory.BusinessLogic
{
    public class Categoria : BLI.ICategoria
    {
        private readonly DAI.ICategoria _categoria;

        public Categoria(DAI.ICategoria categoriaDA)
        {
            _categoria = categoriaDA;
        }

        public Task<List<Models.Categoria>> ListarCategorias()
        {
            return _categoria.ListarCategorias();
        }
    }
}
