using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Models
{
    public class ENCARGADOS
    {
        public ENCARGADOS()
        {
            _FACTURAS = new HashSet<FACTURAS>();
            _NOTAS_DE_CREDITO = new HashSet<NOTAS_DE_CREDITO>();
            _VENTAS = new HashSet<VENTAS>();
        }
        [Key]
        public int ID_ENCARGADOS { get; set; }

        public String USUARIO { get; set; }

        public String CONTRASENA { get; set; }

        public String NOMBRE { get; set; }

        public String APELLIDO_ { get; set; }

        public String CI { get; set; }

        public String TELEFONO { get; set; }

        public String CORREO { get; set; }

        public String DIRECCION { get; set; }
        ICollection<FACTURAS> _FACTURAS { get; set; }
        ICollection<NOTAS_DE_CREDITO> _NOTAS_DE_CREDITO { get; set; }
        ICollection<VENTAS> _VENTAS { get; set; }

    }
}
