using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class TARJETA
    {
        [Key]
        public int ID_TARJETA { get; set; }

        public string MARCA { get; set; }

        public string TIPO { get; set; }

    }
}
