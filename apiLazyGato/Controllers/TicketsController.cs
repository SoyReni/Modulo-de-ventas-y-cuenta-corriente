using apiLazyGato.Context;
using apiLazyGato.Models;
using apiLazyGato.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiLazyGato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly INterfazOrganizador _iorg;

        public TicketsController(AppDbContext context, INterfazOrganizador iorg)
        {
            _iorg = iorg;
        }

        // GET: api/<TicketsController>
        [HttpGet]
        public IActionResult GetTickets()
        {
            try
            {
                return Ok(_iorg.GetTickets()); 
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // POST: api/<TicketsController>/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostTicket([FromBody] Tickets ticket)
        {
            try
            {
                _iorg.InsertTicket(ticket);
                _iorg.Save();
                return Ok(ticket);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        // DELETE: api/<TicketsController>/Delete/5
        [HttpDelete ("{id}")]
        public ActionResult DeleteTicket(decimal id)
        {
            try
            {
                var ticket = _iorg.GetTicket(id);
                if (ticket != null)
                {
                    _iorg.DeleteTicket(ticket);
                    _iorg.Save();
                    return Ok(id);
                } else
                {
                    return BadRequest();
                }
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
