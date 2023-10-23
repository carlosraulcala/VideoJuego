using Microsoft.AspNetCore.Mvc;
using ProyectoVideoJuegos;
using ProyectoVideoJuegos.Models;
using ProyectoWebApp.Context;

namespace ProyectoWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoJuegosController : ControllerBase
    {

        private readonly ILogger<VideoJuegosController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public VideoJuegosController(
            ILogger<VideoJuegosController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] VideoJuegos videoJuegos)
        {
            _aplicacionContexto.VideoJuegos.Add(videoJuegos);
            _aplicacionContexto.SaveChanges();
            return Ok(videoJuegos);
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.VideoJuegos.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] VideoJuegos videoJuegos)
        {
            _aplicacionContexto.VideoJuegos.Update(videoJuegos);
            _aplicacionContexto.SaveChanges();
            return Ok(videoJuegos);
        }
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int videoJuegosId)
        {
            _aplicacionContexto.VideoJuegos.Remove(
                _aplicacionContexto.VideoJuegos.ToList()
                .Where(x => x.idVideoJuego == videoJuegosId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(videoJuegosId);
        }
    }
}
