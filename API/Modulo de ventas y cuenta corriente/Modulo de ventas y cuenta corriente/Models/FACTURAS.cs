using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class FACTURAS
    {
        [Key]
        public int ID_FACTURAS { get; set; }

        [ForeignKey("ID_CLIENTE")]
        public int ID_CLIENTE { get; set; }

        [ForeignKey("ID_VENTA")]
        public int ID_VENTA { get; set; }

        [ForeignKey("ID_ENCARGADOS")]
        public int ID_ENCARGADOS { get; set; }

        [ForeignKey("ID_DETALLE_CREDITO")]
        public int ID_DETALLE_CREDITO { get; set; }

        public string ESTADO { get; set; }

        public int TOTAL_ { get; set; }

        public int IVA { get; set; }

        public int SALDO { get; set; }

        public DateTime fecha { get; set; }
    }
}
