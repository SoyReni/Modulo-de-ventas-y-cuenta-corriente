using Microsoft.EntityFrameworkCore;
using Modulo_de_ventas_y_cuenta_corriente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_de_ventas_y_cuenta_corriente.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<BANCOS> BANCOS { get; set; }

        public DbSet<CLIENTE> CLIENTE { get; set; }

        public DbSet<DETALLE_CREDITO> DETALLE_CREDITO { get; set; }

        public DbSet<DETALLES_DE_PAGO> DETALLES_DE_PAGO { get; set; }

        public DbSet<DETALLES_FACTURA> DETALLES_FACTURA { get; set; }

        public DbSet<ENCARGADOS> ENCARGADOS { get; set; }

        public DbSet<FACTURAS> FACTURAS { get; set; }

        public DbSet<FORMAS_DE_PAGO> FORMAS_DE_PAGO { get; set; }

        public DbSet<NOTAS_DE_CREDITO> NOTAS_DE_CREDITO { get; set; }

        public DbSet<PAGOS> PAGOS { get; set; }

        public DbSet<PRODUCTO> PRODUCTO { get; set; }

        public DbSet<STOCK> STOCK { get; set; }
 
        public DbSet<TARJETA> TARJETA { get; set; }

        public DbSet<VENTAS> VENTAS { get; set; }

        public DbSet<VENTAS_DETALLES> VENTAS_DETALLES { get; set; }
        }
}
