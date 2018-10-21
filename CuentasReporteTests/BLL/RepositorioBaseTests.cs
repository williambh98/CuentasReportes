using Microsoft.VisualStudio.TestTools.UnitTesting;
using CuentasReporte.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuentasReporte.Entidades;

namespace CuentasReporte.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            TiposCuentas cuentas = new TiposCuentas();
            cuentas.TipoID = 1002;
            cuentas.Descripcion = "William";
            RepositorioBase<TiposCuentas> repositorio;
            repositorio = new RepositorioBase<TiposCuentas>();
            Assert.IsTrue(repositorio.Guardar(cuentas));
        }
    }
}