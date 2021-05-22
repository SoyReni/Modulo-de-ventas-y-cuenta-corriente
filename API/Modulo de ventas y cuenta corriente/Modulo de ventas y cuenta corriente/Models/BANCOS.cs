using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class BANCOS
    {
        public BANCOS()
        {
            _DETALLES_DE_PAGO = new HashSet<DETALLES_DE_PAGO>();
        }

        [Key]
        public int ID_BANCO { get; set; }

        public string NOMBRE { get; set; }

        ICollection <DETALLES_DE_PAGO> _DETALLES_DE_PAGO { get; set; }
    }
}
