using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasReporte.Entidades
{
    public class CuentasDetalle
    {
       [Key]
       public int CuentaID { get; set; }
       public string Descripcion { get; set; }
       public int tipoid { get; set; }
       public double Monto { get; set; }

        public  CuentasDetalle()
        {
            CuentaID = 0;
            Descripcion = string.Empty;
            tipoid = 0;
            Monto = 0;
        }

        public CuentasDetalle(int CuentaID, string Descripcion, int tipoid, double Monto)
        {

            this.CuentaID = CuentaID;
            this.Descripcion = Descripcion;
            this.tipoid = tipoid;
            this.Monto = Monto;

        }

    }
}
