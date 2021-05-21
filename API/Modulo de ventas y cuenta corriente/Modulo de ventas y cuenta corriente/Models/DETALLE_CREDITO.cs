using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class DETALLE_CREDITO
    {
        [Key]
        public int ID_DETALLE_CREDITO { get; set; }

        [ForeignKey ("ID_CREDITO")]
        public int ID_CREDITO { get; set; }

        public int MONTO_CUOTA { get; set; }

        public char PAGADO { get; set; }

    }
}
