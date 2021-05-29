using Microsoft.AspNetCore.Mvc;
using Modulo_de_ventas_y_cuenta_corriente.Context;
using Modulo_de_ventas_y_cuenta_corriente.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modulo_de_ventas_y_cuenta_corriente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class USUARIOSController : ControllerBase
    {
        private readonly Organizador _iorg;

        public USUARIOSController(AppDBContext context, Organizador iorg)
        {
            _iorg = iorg; 
        }
        // GET: api/<USUARIOSController>
        [HttpGet]
        public IActionResult GetCLIENTES()
        {
            try
            {
                return Ok(_iorg.GetCLIENTES());
            } catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        // GET api/<USUARIOSController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<USUARIOSController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<USUARIOSController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<USUARIOSController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
