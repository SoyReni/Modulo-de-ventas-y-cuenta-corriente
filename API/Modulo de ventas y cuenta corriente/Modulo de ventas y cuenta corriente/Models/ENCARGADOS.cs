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

        public string USUARIO { get; set; }

        public string CONTRASENA { get; set; }

        public string NOMBRE { get; set; }

        public string APELLIDO_ { get; set; }

        public int CI { get; set; }

        public string TELEFONO { get; set; }

        public string CORREO { get; set; }

        public string DIRECCION { get; set; }
        ICollection<FACTURAS> _FACTURAS { get; set; }
        ICollection<NOTAS_DE_CREDITO> _NOTAS_DE_CREDITO { get; set; }
        ICollection<VENTAS> _VENTAS { get; set; }

    }
}
