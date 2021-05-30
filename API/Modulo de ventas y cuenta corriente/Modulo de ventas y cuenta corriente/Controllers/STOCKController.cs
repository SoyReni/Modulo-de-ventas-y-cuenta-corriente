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
    public class STOCKController : ControllerBase
    {
        private readonly Organizador _iorg; 

        public STOCKController (AppDBContext context, Organizador iorg)
        {
            _iorg = iorg; 
        }

        // GET: api/<STOCKController>
        [HttpGet]
        public IActionResult GetStock()
        {
            try
            {
                return Ok(_iorg.GetSTOCK());
            } catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        // GET api/<STOCKController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
