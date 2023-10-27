using Microsoft.AspNetCore.Mvc;
using AppContext;
using DiskModel;

namespace Disk.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class DiskController : ControllerBase
    {
    
        private readonly ILogger<DiskController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public DiskController(
            ILogger<DiskController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear Disco
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Diskk diskk)
        {
            _aplicacionContexto.Disk.Add(diskk);
            _aplicacionContexto.SaveChanges();
            return Ok(diskk);
        }
        //READ: Obtener lista de Discos
       
        [Route("")]
        [HttpGet]
        public IEnumerable<Diskk> GetDisks()
        {
            return _aplicacionContexto.Disk.ToList();
        }
        //Update: Modificar Discos
        [Route("disk")]
        [HttpPut]
        public IActionResult PutDisk(
            [FromBody] Diskk diskk)
        {
            _aplicacionContexto.Disk.Update(diskk);
            _aplicacionContexto.SaveChanges();
            return Ok(diskk);
        }
        //Delete: Eliminar Discos
        [Route("disk/{diskId}")]
        [HttpDelete]
        public IActionResult DeleteProfessor(int diskId)
        {
            _aplicacionContexto.Disk.Remove(
                _aplicacionContexto.Disk.ToList()
                .Where(x => x.IdDisk == diskId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges ();
            return Ok(diskId);
        }
    }
}