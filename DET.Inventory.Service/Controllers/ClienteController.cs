using DET.Inventory.BusinessLogic.Interfaces;
using DET.Inventory.Models;
using Microsoft.AspNetCore.Mvc;

namespace DET.Inventory.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly ICliente _cliente;

        public ClienteController(ILogger<ClienteController> logger, ICliente cliente)
        {
            _logger = logger;
            _cliente = cliente;
        }

        [HttpPost]
        public async Task<ActionResult> ListarClientes([FromBody] Cliente cliente)
        {
            try
            {
                var result = await _cliente.ListarClientes(cliente);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al listar clientes");
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = "Ocurrió un error inesperado.",
                    Detalle = ex.Message
                });
            }
        }

        [HttpPost]
        public async Task<ActionResult> GuardarCliente([FromBody] Cliente cliente)
        {
            try
            {
                var resutl = await _cliente.GuardarCliente(cliente);
                return Ok(resutl);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al guardar el cliente");
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = "Ocurrió un error inesperado.",
                    Detalle = ex.Message
                });
            }
        }
    }
}
