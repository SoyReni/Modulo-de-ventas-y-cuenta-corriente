using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class PAGOS
    {
        [Key]
        public int ID_PAGO { get; set; }

        [ForeignKey("ID_CLIENTE")]
        public int ID_CLIENTE { get; set; }

        [ForeignKey("ID_VENTA")]
        public int ID_VENTA { get; set; }

        public DateTime FECHA { get; set; }

        public int TOTAL { get; set; }
    }
}
