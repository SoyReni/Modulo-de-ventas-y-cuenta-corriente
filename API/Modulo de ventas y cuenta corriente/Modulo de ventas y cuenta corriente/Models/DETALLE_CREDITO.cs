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
        public DETALLE_CREDITO()
        {
            _FACTURAS = new HashSet<FACTURAS>();
        }
        [Key]
        public int ID_DETALLE_CREDITO { get; set; }

        public decimal MONTO_CUOTA { get; set; }

        public int PAGADO { get; set; }
        ICollection<FACTURAS> _FACTURAS { get; set; }

    }
}
