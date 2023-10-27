using Microsoft.AspNetCore.Mvc;
using AppContext;
using MusicModel;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicController : ControllerBase
    {
    
        private readonly ILogger<MusicController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public MusicController(
            ILogger<MusicController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear Musica
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Music music)
        {
            _aplicacionContexto.Music.Add(music);
            _aplicacionContexto.SaveChanges();
            return Ok(music);
        }
        //READ: Obtener lista de Musicas
        
        [Route("")]
        [HttpGet]
        public IEnumerable<Music> GetMusics()
        {
            return _aplicacionContexto.Music.ToList();
        }
        //Update: Modificar Musicas
        [Route("music")]
        [HttpPut]
        public IActionResult PutMusic(
            [FromBody] Music music)
        {
            _aplicacionContexto.Music.Update(music);
            _aplicacionContexto.SaveChanges();
            return Ok(music);
        }
        //Delete: Eliminar Musicas
        [Route("music/{musicId}")]
        [HttpDelete]
        public IActionResult DeleteMusic(int musicId)
        {
            _aplicacionContexto.Music.Remove(
                _aplicacionContexto.Music.ToList()
                .Where(x => x.IdMusic == musicId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges ();
            return Ok(musicId);
        }
    }
}