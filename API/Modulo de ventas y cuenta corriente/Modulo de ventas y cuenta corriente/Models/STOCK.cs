using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class STOCK
    {
        [Key]
        public int ID_stock { get; set; }

        [ForeignKey("ID_PRODUCTO")]
        public int ID_PRODUCTO { get; set; }

        public int CANTIDAD { get; set; }

        public int DEPOSITO { get; set; }

    }
}
