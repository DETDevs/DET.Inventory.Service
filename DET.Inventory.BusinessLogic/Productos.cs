using DET.Inventory.DataAccess.Interfaces;

namespace DET.Inventory.BusinessLogic
{
    public class Productos : DET.Inventory.BusinessLogic.Interfaces.IProductos
    {
        private readonly IProductos _productosDA;

        public Productos(IProductos productosDA)
        {
            _productosDA = productosDA;
        }

        public async Task<List<Models.Productos>> ListarProductos()
        {
            return await _productosDA.ListarProductos();
        }
    }
}
