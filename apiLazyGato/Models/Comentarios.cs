using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiLazyGato.Models
{
    public class Comentarios
    {
        [Key]
        public decimal id { get; set; }

        public decimal id_ticket { get; set; }
        [ForeignKey("id_ticket")]
        public virtual Tickets ticket { get; set; }

        [Required]
        public String usuario { get; set; }

        [Required]
        public DateTime fecha { get; set; }

        [Required]
        public String comentario { get; set; }

    }
}
