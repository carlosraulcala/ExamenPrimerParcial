using Microsoft.AspNetCore.Mvc;
using SegundoExamen.Context;
using SegundoExamen.Models;

namespace SegundoExamen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicasController : ControllerBase
    {

        private readonly ILogger<MusicasController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public MusicasController(
            ILogger<MusicasController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear musicas
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Musica musica)
        {
            _aplicacionContexto.Musica.Add(musica);
            _aplicacionContexto.SaveChanges();
            return Ok(musica);
        }
        //READ: Obtener lista de musicas
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Musica.ToList());

        }
        //Update: Modificar musicas
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Musica musica)
        {
            _aplicacionContexto.Musica.Update(musica);
            _aplicacionContexto.SaveChanges();
            return Ok(musica);
        }
        //Delete: Eliminar musicas
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int musicaID)
        {
            _aplicacionContexto.Musica.Remove(
                _aplicacionContexto.Musica.ToList()
                .Where(x => x.idMusica == musicaID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(musicaID);
        }
    }
}
