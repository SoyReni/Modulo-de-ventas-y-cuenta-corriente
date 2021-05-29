using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class DETALLES_FACTURA
    {
        [Key]
        public int ID_DETALLE_FACTURA { get; set; }

        [ForeignKey("ID_VENTA")]
        public int ID_VENTA { get; set; }

        [ForeignKey("ID_FACTURAS")]
        public int ID_FACTURAS { get; set; }

        public decimal IVA { get; set; }

        public String ESTADO { get; set; }

        public int CANT_CUOTAS { get; set; }
    }
}
