using Microsoft.AspNetCore.Mvc;
using ProyectoVideoJuegos;
using ProyectoVideoJuegos.Models;
using ProyectoWebApp.Context;

namespace ProyectoWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        private readonly ILogger<UsuarioController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public UsuarioController(
            ILogger<UsuarioController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Usuario usuario)
        {
            _aplicacionContexto.Usuarios.Add(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Usuarios.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Usuario usuario)
        {
            _aplicacionContexto.Usuarios.Update(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);
        }
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int usuarioId)
        {
            _aplicacionContexto.Usuarios.Remove(
                _aplicacionContexto.Usuarios.ToList()
                .Where(x => x.idUsuario == usuarioId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(usuarioId);
        }
    }
}
