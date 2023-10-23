using Microsoft.AspNetCore.Mvc;
using ProyectoVideoJuegos;
using ProyectoVideoJuegos.Models;
using ProyectoWebApp.Context;

namespace ProyectoWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {

        private readonly ILogger<EmailController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EmailController(
            ILogger<EmailController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Email email)
        {
            _aplicacionContexto.Emails.Add(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Emails.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Email email)
        {
            _aplicacionContexto.Emails.Update(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);
        }
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int emailId)
        {
            _aplicacionContexto.Emails.Remove(
                _aplicacionContexto.Emails.ToList()
                .Where(x => x.idEmail == emailId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(emailId);
        }
    }
}
