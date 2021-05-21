using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class VENTAS
    {
        [Key]
        public int ID_VENTA { get; set; }

        [ForeignKey("ID_ENCARGADO")]
        public int ID_ENCARGADO { get; set; }

        [ForeignKey("ID_CLIENTE")]
        public int ID_CLIENTE { get; set; }

        [ForeignKey("ID_FACTURAS")]
        public int ID_FACTURAS { get; set; }

        public DateTime FECHA { get; set; }

        public string ESTADO { get; set; }

        public int TOTAL { get; set; }

        public int IVA { get; set; }
    }
}
