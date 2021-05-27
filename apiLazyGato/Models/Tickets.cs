using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiLazyGato.Models
{
    public class Tickets
    {
        public Tickets()
        {
            Comentarios = new HashSet<Comentarios>();
        }

        [Key]
        public decimal id { get; set; }

        public String titulo { get; set; }

        public String descripcion { get; set; }

        public String responsable { get; set; }

        public DateTime fecha_creacion { get; set; }

        public String prioridad { get; set; } 

        public String creador { get; set; }

        public String estado { get; set; }

        public DateTime fecha_cierre { get; set; }

        public String resultado { get; set; }
        public ICollection<Comentarios> Comentarios { get; set; }
    }
}
