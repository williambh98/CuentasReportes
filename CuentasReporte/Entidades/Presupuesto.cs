using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasReporte.Entidades
{
    public class Presupuesto
    {
        [Key]
        public int presupuestoid { get; set; }
        public string Descripcion { get; set; }
        public string tipo { get; set; }
        public float Monto { get; set; }
        public DateTime Fecha { get; set; }

        public virtual List<CuentasDetalle> Cuentas { get; set; }
        public Presupuesto()
        {
            presupuestoid = 0;
            Descripcion = string.Empty;
            tipo = string.Empty;
            Monto = 0;
            Fecha = DateTime.Now;
            Cuentas = new List<CuentasDetalle>();

        }


    }
}
