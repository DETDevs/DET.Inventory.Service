using DET.Inventory.BusinessLogic.Interfaces;
using DET.Inventory.Models;
using Microsoft.AspNetCore.Mvc;

namespace DET.Inventory.Service.Controllers
{
    [ApiController]
    [Route("api/[Controller]/[Action]")]
    public class ProveedorController : Controller
    {
        public readonly ILogger<ProveedorController> _logger;
        public readonly IProveedor _proveedor;

        public ProveedorController(ILogger<ProveedorController> logger, IProveedor proveedor)
        {
            this._logger = logger;
            this._proveedor = proveedor;
        }

        [HttpPost]
        public async Task<IActionResult> ListarProveedores([FromBody] Proveedor proveedor)
        {
            try
            {
                var result = await _proveedor.ListarProveedores(proveedor);
                return Ok(result);
            } 
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Mesaage = "Ocurrió un error inesperado.",
                    Detalle = ex.Message
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> GuardarProveedor([FromBody] Proveedor proveedor)
        {
            try
            {
                var result = await _proveedor.GuardarProveeedor(proveedor);
                return Ok(result);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = "Ocurrio un error inesperado",
                    Detalle = ex.Message
                });
            }
        }
    }
}
