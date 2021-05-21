using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class PRODUCTO
    {
        [Key]
        public int ID_PRODUCTO { get; set; }

        public string CODIGO { get; set; }

        public string NOMBRE { get; set; }

        public string DESCRIPCION { get; set; }

        public int PRECIO { get; set; }
    }
}
