using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriaController : ControllerBase, ISubCategoriaController
    {
        private ISubCategoriaFlujo _subCategoriFlujo;
        private ILogger<SubCategoriaController> _logger;

        public SubCategoriaController(ISubCategoriaFlujo subCategoriaFLujo, ILogger<SubCategoriaController> logger)
        {
            _subCategoriFlujo = subCategoriaFLujo;
            _logger = logger;
        }
        #region Operaciones
        [HttpGet("{IdCategoria}")]
        public async Task<IActionResult> Obtener(Guid IdCategoria)
        {
            var resultado = await _subCategoriFlujo.Obtener(IdCategoria);
            if (!resultado.Any())
                return NoContent();
            return Ok(resultado);
        }
        #endregion Operaciones

    }
}
