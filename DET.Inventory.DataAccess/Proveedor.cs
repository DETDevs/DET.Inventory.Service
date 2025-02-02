
using Dapper;
using DET.Inventory.DataAccess.Interfaces;
using System.Data;

namespace DET.Inventory.DataAccess
{
    public class Proveedor : IProveedor
    {
        private IConnectionManager _connectionManager;

        public Proveedor(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }

        public async Task<Models.Proveedor> GuardarProveedor(Models.Proveedor proveedor)
        {
            using var connection = _connectionManager.GetConnection(ConnectionManager.InventoryConnectionString_KEY);

            var result = await connection.QueryAsync<Models.Proveedor>
            (
                "sp_proveedor_guardar",
                 param: new
                 {
                     Nombre = proveedor.Persona.Nombre,
                     Apellido = proveedor.Persona.Apellido,
                     Identificacion = proveedor.Persona.Identificacion,
                     Telefono = proveedor.Persona.Telefono,
                     Direccion = proveedor.Persona.Direccion,
                     Email = proveedor.Persona.Email,
                     Codigo = proveedor.CodigoProveedor,
                     NombreEmpresa = proveedor.NombreEmpresa,
                     UsuarioCreacion = "system",
                     Activo = proveedor.Activo ?? true
                 }
            );

            return result.FirstOrDefault();
        }

        public async Task<List<Models.Proveedor>> ListarProveedores(Models.Proveedor proveedor)
        {
            using var connection = _connectionManager.GetConnection(ConnectionManager.InventoryConnectionString_KEY);

            var result = await connection.QueryAsync<Models.Proveedor, Models.Persona, Models.Proveedor>
            (
                "sp_proveedor_listar",
                param: new
                {
                    CodigoProveedor = proveedor.CodigoProveedor
                },
                commandType: CommandType.StoredProcedure,
                splitOn: "IdPersona",
                map: (prov, p) =>
                {
                    prov.Persona = p;
                    return prov;
                }
            );

            return result.ToList();
        }
    }
}
