
using Dapper;
using DET.Inventory.DataAccess.Interfaces;
using System.Data;

namespace DET.Inventory.DataAccess
{
    public class Cliente : ICliente
    {
        private IConnectionManager _connectionManager;

        public Cliente(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }

        public async Task<Models.Cliente> GuradarCliente(Models.Cliente cliente)
        {
            using var connection = _connectionManager.GetConnection(ConnectionManager.InventoryConnectionString_KEY);

            var result = await connection.QueryAsync<Models.Cliente>
            (
                "sp_cliente_guardar",
                param: new
                {
                    Nombre = cliente.Persona.Nombre,
                    Apellido = cliente.Persona.Apellido,
                    Identificacion = cliente.Persona.Identificacion,
                    Telefono = cliente.Persona.Telefono,
                    Direccion = cliente.Persona.Direccion,
                    Email = cliente.Persona.Email,
                    TipoCliente = cliente.TipoCliente,
                    CodigoCliente = cliente.CodigoCliente,
                    UsuarioCreacion = "system", 
                    Activo = cliente.Activo ?? true
                },
                commandType: CommandType.StoredProcedure
            );

            return result.FirstOrDefault();
        }

        public async Task<List<Models.Cliente>> ListarClientes(Models.Cliente cliente)
        {
            using var connection = _connectionManager.GetConnection(ConnectionManager.InventoryConnectionString_KEY);

            var resultado = await connection.QueryAsync<Models.Cliente, Models.Persona, Models.Cliente>
            (
                "sp_cliente_listar",
                param: new
                {
                    CodigoCliente = cliente.CodigoCliente
                },
                commandType: CommandType.StoredProcedure,
                splitOn: "IdPersona",
                map: (c, p) =>
                {
                    c.Persona = p; //Asignamos la persona al cliente
                    return c;
                }
            );

            return resultado.ToList();
        }
    }
}
