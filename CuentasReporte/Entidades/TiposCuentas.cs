using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasReporte.Entidades
{
    public class TiposCuentas
    {
        [Key]
        public int TipoID { get; set; }
        public string Descripcion { get; set; }

        public TiposCuentas()
        {
            TipoID = 0;
            Descripcion = string.Empty;
        }
    }
}
