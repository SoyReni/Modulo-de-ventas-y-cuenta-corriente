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

        public string RUC { get; set; }

        public string NOMBRE { get; set; }

        public string APELLIDO { get; set; }

        public string CORREO { get; set; }

        public decimal CREDITO { get; set; }
        ICollection<FACTURAS> _FACTURAS { get; set; }

        ICollection<PAGOS> _PAGOS { get; set; }
        ICollection<VENTAS> _VENTAS { get; set; }
    }
}
