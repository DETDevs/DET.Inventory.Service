using Microsoft.Extensions.DependencyInjection;

namespace DET.Inventory.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddInventoryServices(this IServiceCollection services)
        {
            services.AddSingleton<DataAccess.Interfaces.IConnectionManager, DataAccess.ConnectionManager>();

            services.AddSingleton<DataAccess.Interfaces.IProductos, DataAccess.Productos>();
            services.AddSingleton<BusinessLogic.Interfaces.IProductos, BusinessLogic.Productos>();

            services.AddSingleton<DataAccess.Interfaces.ICategoria, DataAccess.Categoria>();
            services.AddSingleton<BusinessLogic.Interfaces.ICategoria, BusinessLogic.Categoria>();

            services.AddSingleton<DataAccess.Interfaces.ICliente, DataAccess.Cliente>();
            services.AddSingleton<BusinessLogic.Interfaces.ICliente, BusinessLogic.Cliente>();

            services.AddSingleton<DataAccess.Interfaces.ICompra, DataAccess.Compra>();
            services.AddSingleton<BusinessLogic.Interfaces.ICompra, BusinessLogic.Compra>();

            services.AddSingleton<DataAccess.Interfaces.IDetalleCompra, DataAccess.DetalleCompra>();
            services.AddSingleton<BusinessLogic.Interfaces.IDetalleCompra, BusinessLogic.DetalleCompra>();

            services.AddSingleton<DataAccess.Interfaces.IDetalleFactura, DataAccess.DetalleFactura>();
            services.AddSingleton<BusinessLogic.Interfaces.IDetalleFactura, BusinessLogic.DetalleFactura>();

            services.AddSingleton<DataAccess.Interfaces.IFactura, DataAccess.Factura>();
            services.AddSingleton<BusinessLogic.Interfaces.IFactura, BusinessLogic.Factura>();

            services.AddSingleton<DataAccess.Interfaces.IHistoricoPrecio, DataAccess.HistoricoPrecio>();
            services.AddSingleton<BusinessLogic.Interfaces.IHistoricoPrecio, BusinessLogic.HistoricoPrecio>();

            services.AddSingleton<DataAccess.Interfaces.IMovimientoInventario, DataAccess.MovimientoInventario>();
            services.AddSingleton<BusinessLogic.Interfaces.IMovimientoInventario, BusinessLogic.MovimientoInventario>();

            services.AddSingleton<DataAccess.Interfaces.IPersona, DataAccess.Persona>();
            services.AddSingleton<BusinessLogic.Interfaces.IPersona, BusinessLogic.Persona>();

            services.AddSingleton<DataAccess.Interfaces.IProveedor, DataAccess.Proveedor>();
            services.AddSingleton<BusinessLogic.Interfaces.IProveedor, BusinessLogic.Proveedor>();

        }
    }
}
