using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class VENTAS_DETALLES
    {
        [Key]
        public int ID_VENTAS_DETALLES { get; set; }

        [ForeignKey("ID_PRODUCTO")]
        public int ID_PRODUCTO { get; set; }

        [ForeignKey("ID_VENTA")]
        public int ID_VENTA { get; set; }

        public int CANTIDAD { get; set; }

        public decimal PRECIO_UNITARIO { get; set; }

        public decimal SUBTOTAL { get; set; }
    }
}
