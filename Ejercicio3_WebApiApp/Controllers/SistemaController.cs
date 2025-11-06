using Ejercicio1_Models;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio3_WebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemaController : ControllerBase
    {
        static Sistema miEmpresa = new Sistema();
        [HttpPost("DescargarCamion")]
        public ActionResult PostDescargarCamion(IFormFile manifiesto)
        {
            Stream s = manifiesto.OpenReadStream();
            miEmpresa.Descargar(s);
            return Ok("Paquetes importados correctamente.");
        }
        // GET: api/<SistemaController>
        [HttpGet("CamionesCargados")]
        public ActionResult<string[]> Get()
        {
            string[] camiones = miEmpresa.CamionesCargados();
            if (camiones.Length == 0)
                return NotFound("No hay camiones cargados.");

            return Ok(camiones);
        }

    }
}
