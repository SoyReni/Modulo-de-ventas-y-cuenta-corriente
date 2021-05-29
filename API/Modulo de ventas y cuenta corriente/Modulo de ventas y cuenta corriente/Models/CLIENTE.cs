using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class CLIENTE
    {
        public CLIENTE() {
            _FACTURAS = new HashSet<FACTURAS>();
            _PAGOS = new HashSet<PAGOS>();
            _VENTAS = new HashSet<VENTAS>();
        }

        [Key]
        public int ID_CLIENTE { get; set; }

        public String RUC { get; set; }

        public String NOMBRE_ { get; set; }

        public String APELLIDO { get; set; }

        public String TELEFONO { get; set;  }

        public String CORREO { get; set; }

        public decimal CREDITO { get; set; }
        ICollection<FACTURAS> _FACTURAS { get; set; }
        ICollection<PAGOS> _PAGOS { get; set; }
        ICollection<VENTAS> _VENTAS { get; set; }
    }
}
