using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiLazyGato.Context;
using apiLazyGato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace apiLazyGato.Services
{
    public class Organizador : INterfazOrganizador
    {
        private readonly AppDbContext _context;


        public Organizador(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }


        public Tickets GetTicket(decimal id)
        {
            var ticket = _context.tickets.Where(t => t.id == id).FirstOrDefault();
            ticket.Comentarios = _context.comentarios.Where(c => c.id_ticket == ticket.id).ToList();
            return ticket; 
        }

        public void DeleteComment(Comentarios c)
        {
            _context.comentarios.Remove(c);
        }


        public void DeleteTicket(Tickets t)
        {
            var comments = _context.comentarios.Where(c => c.id_ticket == t.id).ToList();
            foreach (var comment in comments)
                _context.comentarios.Remove(comment);
            _context.tickets.Remove(t);
        }

        public void InsertComment(Comentarios c)
        {
            _context.comentarios.Add(c);
        }

        public void InsertTicket(Tickets ticket)
        {
            _context.tickets.Add(ticket);
        }

        public void UpdateComment(Comentarios c)
        {
            _context.comentarios.Update(c);
        }


        public void UpdateTicket(Tickets t)
        {
            _context.tickets.Update(t);
        }    

        public void Save()
        {
            _context.SaveChanges();
        }

        public Comentarios GetComment (decimal id)
        {
            return (Comentarios)_context.comentarios.Where(t => t.id == id);
        }

        public IEnumerable<Tickets> GetTicketsForTitulo(decimal id, string titulo)
        {
            var tickets = _context.tickets.Where(t => t.titulo == titulo).ToList();
            return tickets; 
        }

        public IEnumerable<Tickets> GetTicketsForResponsable(decimal id, string resp)
        {
            var tickets = _context.tickets.Where(t => t.responsable == resp).ToList();
            return tickets;
        }

        public IEnumerable<Tickets> GetTicketsForPrioridad(decimal idTablero, string prioridad)
        {
            var tickets = _context.tickets.Where(t => t.prioridad == prioridad).ToList();
            return tickets;
        }

        public IEnumerable<Tickets> GetTicketForEstado(decimal idTablero, string estado)
        {
            var tickets = _context.tickets.Where(t => t.estado == estado).ToList();
            return tickets;
        }

        public IEnumerable<Tickets> GetTickets()
        {
            var tickets = _context.tickets.ToList();
            foreach(Tickets ticket in tickets)
            {
                ticket.Comentarios = _context.comentarios.Where(c => c.id_ticket == ticket.id).ToList();
            }
            return tickets; 
        }
    }
}
