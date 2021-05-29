using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class DETALLES_DE_PAGO
    {
        [Key]
        public int ID_DETALLES_PAGOS { get; set; }

        [ForeignKey("ID_PAGO")]
        public int ID_PAGO { get; set; }

        [ForeignKey("ID_FORMAS_PAGO")]
        public int ID_FORMAS_PAGO { get; set; }

        [ForeignKey("ID_TARJETA")]
        public int ID_TARJETA { get; set; }

        [ForeignKey("ID_BANCO")]
        public int ID_BANCO { get; set; }

        public decimal MONTO { get; set; }

        public decimal VUELTO { get; set; }

        public String NUMERO { get; set; }

    }
}
