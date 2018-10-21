using CuentasReporte.BLL;
using CuentasReporte.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasReporte.UI
{
    public partial class Cuenta : Form
    {
        private RepositorioBase<CuentasDetalle> repositorio;
        public Cuenta()
        {
          
            InitializeComponent();
            LlenarComboBox();
        }

        public void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripcioncomboBox.Text = string.Empty;
            MontonumericUpDown1.Value = 0;

        }

        public void LlenarComboBox()
        {
            RepositorioBase<TiposCuentas> repositorio = new RepositorioBase<TiposCuentas>();
            DescripcioncomboBox.DataSource = repositorio.GetList(x => true);
            DescripcioncomboBox.ValueMember = "Descripcion";
        }
        public CuentasDetalle LlenarClase()
        {
            CuentasDetalle cuentas = new CuentasDetalle();
            cuentas.CuentaID = Convert.ToInt32(IDnumericUpDown.Value);
            cuentas.Descripcion = DescripcioncomboBox.Text;
            cuentas.Monto = Convert.ToDouble(MontonumericUpDown1.Value);

            return cuentas;
        }

        public void LlenarCampo(CuentasDetalle cuentas)
        {
            IDnumericUpDown.Value = cuentas.CuentaID;
            DescripcioncomboBox.Text = cuentas.Descripcion;
            MontonumericUpDown1.Value = Convert.ToDecimal(cuentas.Monto);
        }

        private bool ExiteEnLaBD()
        {
            repositorio = new RepositorioBase<CuentasDetalle>();
            CuentasDetalle cuentas = repositorio.Buscar((int)IDnumericUpDown.Value);
            return (cuentas != null);
        }

        public bool Validar()
        {
            bool paso = true;
            if(string.IsNullOrWhiteSpace(DescripcioncomboBox.Text))
            {
                errorProvider.SetError(DescripcioncomboBox, "LLenar Campo");
                paso = false;
            }

            if(MontonumericUpDown1.Value == 0)
            {
                errorProvider.SetError(MontonumericUpDown1, "Llenar campo");
                paso = false;
            }

            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<CuentasDetalle>();
            CuentasDetalle cuentas;
            bool paso = false;

            cuentas = LlenarClase();
            if (!Validar())
                return;
            if (IDnumericUpDown.Value >= 0)
                paso = repositorio.Guardar(cuentas);
            else
            {
                if (!ExiteEnLaBD())
                    MessageBox.Show("No existe No es Modificable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            paso = repositorio.Modificar(cuentas);
            if(paso)
            {
                MessageBox.Show("Guardado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("NO Guardado", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;

            repositorio = new RepositorioBase<CuentasDetalle>();
            int.TryParse(IDnumericUpDown.Text, out id);
            if(!ExiteEnLaBD())
            {
                errorProvider.SetError(IDnumericUpDown, "No exite!!");
                IDnumericUpDown.Focus();
                return;
            }
            if(repositorio.Eliminar(id))
            {
                MessageBox.Show("Eliminar");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se Elimino");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<CuentasDetalle>();
            CuentasDetalle cuentas = new CuentasDetalle();
            int.TryParse(IDnumericUpDown.Text, out id);
            cuentas = repositorio.Buscar(id);

            if (cuentas != null)
            {
                MessageBox.Show("Cuenta Encontrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No encontrado");

        }

        private void Tcuentasbutton_Click(object sender, EventArgs e)
        {
            TipoDeCuentas tp = new TipoDeCuentas();
            tp.Show();
        }
    }
}
