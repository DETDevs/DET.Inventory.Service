using DET.Inventory.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DET.Inventory.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductosController : ControllerBase
    {
        private readonly ILogger<ProductosController> _logger;
        private readonly IProductos productosBL;

        public ProductosController(ILogger<ProductosController> logger, IProductos productosBL)
        {
            _logger = logger;
            this.productosBL = productosBL;
        }

        [HttpGet]
        public async Task<IActionResult> ListarProductos()
        {
            try
            {
                var resul = await productosBL.ListarProductos();
                return Ok(resul);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error al listar productos");
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = "Ocurrió un error inesperado.",
                    Detalle = ex.Message
                });
            }
        }
    }
}
