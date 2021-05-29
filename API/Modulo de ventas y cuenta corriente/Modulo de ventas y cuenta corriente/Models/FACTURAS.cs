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
        public FACTURAS() {
            _DETALLES_FACTURA = new HashSet<DETALLES_FACTURA>();
            _NOTAS_DE_CREDITO = new HashSet<NOTAS_DE_CREDITO>();
            _VENTAS = new HashSet<VENTAS>();
        }
        
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

        public String ESTADO { get; set; }

        public decimal TOTAL_ { get; set; }

        public decimal IVA { get; set; }

        public decimal SALDO { get; set; }

        public DateTime fecha { get; set; }

        ICollection<DETALLES_FACTURA> _DETALLES_FACTURA { get; set; }
        ICollection<NOTAS_DE_CREDITO> _NOTAS_DE_CREDITO { get; set; }
        ICollection<VENTAS> _VENTAS { get; set; }

    }
}
