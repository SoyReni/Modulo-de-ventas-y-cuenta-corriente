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

        public string CONCEPTO { get; set; }

        public string RAZON { get; set; }

        public int MONTO { get; set; }

        public int IVA { get; set; }

    }
}
