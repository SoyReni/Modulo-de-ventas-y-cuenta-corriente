using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiLazyGato.Models;

namespace apiLazyGato.Services
{
    public interface INterfazOrganizador
    {

        Tickets GetTicket(decimal id);

        IEnumerable<Tickets> GetTickets();
        void InsertTicket(Tickets ticket);

        void DeleteTicket(Tickets t);

        void UpdateTicket(Tickets t);

        Comentarios GetComment(decimal id);

        void InsertComment(Comentarios c);
        void UpdateComment(Comentarios c);
        void DeleteComment(Comentarios c);

        IEnumerable<Tickets> GetTicketsForTitulo(decimal id, String titulo);

        IEnumerable<Tickets> GetTicketsForResponsable(decimal id, String resp);

        IEnumerable<Tickets> GetTicketsForPrioridad(decimal id, String prioridad);

        IEnumerable<Tickets> GetTicketForEstado(decimal id, String estado);
        void Save();

    }
}
