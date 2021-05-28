using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class PRODUCTO
    {
        public PRODUCTO()
        {
            _STOCK = new HashSet<STOCK>();
            _VENTAS_DETALLES = new HashSet<VENTAS_DETALLES>();
        }

        [Key]
        public int ID_PRODUCTO { get; set; }

        public string CODIGO { get; set; }

        public string NOMBRE { get; set; }

        public string DESCRIPCION { get; set; }

        public decimal PRECIO { get; set; }

        ICollection<STOCK> _STOCK { get; set; }
        ICollection<VENTAS_DETALLES> _VENTAS_DETALLES{ get; set; }
    }
}
