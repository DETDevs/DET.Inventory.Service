using DET.Inventory.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DET.Inventory.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ILogger<CategoriaController> _logger;
        private readonly ICategoria _categoria;

        public CategoriaController(ILogger<CategoriaController> logger, ICategoria categoria)
        {
            _logger = logger;
            _categoria = categoria;
        }

        [HttpGet]
        public async Task<IActionResult> ListarCategorias()
        {
            try
            {
                var resul = await _categoria.ListarCategorias();
                return Ok(resul);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al listar categorias");
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = "Ocurrió un error inesperado.",
                    Detalle = ex.Message
                });
            }
        }
    }
}
