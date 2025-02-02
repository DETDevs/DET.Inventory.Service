using DAI = DET.Inventory.DataAccess.Interfaces;
using BLI = DET.Inventory.BusinessLogic.Interfaces;
using System.Globalization;

namespace DET.Inventory.BusinessLogic
{
    public class Proveedor : BLI.IProveedor
    {
        public readonly DAI.IProveedor _proveedor;

        public Proveedor(DAI.IProveedor proveedor)
        {
            _proveedor = proveedor;
        }

        public Task<Models.Proveedor> GuardarProveeedor(Models.Proveedor proveedor)
        {
            return _proveedor.GuardarProveedor(proveedor);
        }

        public Task<List<Models.Proveedor>> ListarProveedores(Models.Proveedor proveedor)
        {
            return _proveedor.ListarProveedores(proveedor);
        }
    }
}
