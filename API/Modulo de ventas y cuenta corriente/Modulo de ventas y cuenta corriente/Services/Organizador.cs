using Modulo_de_ventas_y_cuenta_corriente.Context;
using Modulo_de_ventas_y_cuenta_corriente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Services
{
    public class Organizador
    {
        private readonly AppDBContext _context; 

        public Organizador(AppDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); 
        }

        public IEnumerable<CLIENTE> GetCLIENTES()
        {
            var clientes = _context.CLIENTE.ToList();
            return clientes; 
        }

    }
}
