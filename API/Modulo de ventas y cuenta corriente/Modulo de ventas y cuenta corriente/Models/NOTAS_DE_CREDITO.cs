using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class NOTAS_DE_CREDITO
    {
        [Key]
        public int ID_NOTA_CRDITO { get; set; }

        [ForeignKey("ID_FACTURAS")]
        public int ID_FACTURAS { get; set; }

        [ForeignKey("ID_ENCARGADOS")]
        public int ID_ENCARGADOS { get; set; }

        public DateTime FECHA_EMICIO { get; set; }

        public String CONCEPTO { get; set; }

        public String RAZON { get; set; }

        public decimal MONTO { get; set; }

        public decimal IVA { get; set; }

    }
}
