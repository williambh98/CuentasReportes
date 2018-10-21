using CuentasReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasReporte.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<CuentasDetalle> cuentas { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<TiposCuentas> Tcuentas { get; set; }


        public Contexto() : base("ConStr")
        {

        }

    }
}
