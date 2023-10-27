using Microsoft.AspNetCore.Mvc;
using SegundoExamen.Context;
using SegundoExamen.Models;

namespace SegundoExamen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscosController : ControllerBase
    {

        private readonly ILogger<DiscosController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public DiscosController(
            ILogger<DiscosController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear discos
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Disco disco)
        {
            _aplicacionContexto.Disco.Add(disco);
            _aplicacionContexto.SaveChanges();
            return Ok(disco);
        }
        //READ: Obtener lista de discos
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Disco.ToList());

        }
        //Update: Modificar discos
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Disco disco)
        {
            _aplicacionContexto.Disco.Update(disco);
            _aplicacionContexto.SaveChanges();
            return Ok(disco);
        }
        //Delete: Eliminar discos
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int discosID)
        {
            _aplicacionContexto.Disco.Remove(
                _aplicacionContexto.Disco.ToList()
                .Where(x => x.idDisco == discosID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(discosID);
        }
    }
}
