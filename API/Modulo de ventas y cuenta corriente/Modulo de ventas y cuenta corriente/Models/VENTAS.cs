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
        public VENTAS()
        {
            _DETALLES_FACTURA = new HashSet<DETALLES_FACTURA>();
            _FACTURAS = new HashSet<FACTURAS>();
            _PAGOS = new HashSet<PAGOS>();
            _VENTAS_DETALLES = new HashSet<VENTAS_DETALLES>();
        }

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

        public decimal TOTAL { get; set; }

        public decimal IVA { get; set; }

        ICollection<DETALLES_FACTURA> _DETALLES_FACTURA { get; set; }
        ICollection<FACTURAS> _FACTURAS { get; set; }
        ICollection <PAGOS> _PAGOS { get; set; }
        ICollection<VENTAS_DETALLES> _VENTAS_DETALLES{ get; set; }
    }
}
