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
    public partial class TipoDeCuentas : Form
    {
        RepositorioBase<TiposCuentas> repositorio;
        public TipoDeCuentas()
        {
            InitializeComponent();
        }

        public void LImpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
        }

        public TiposCuentas LlenarClase()
        {
            TiposCuentas tcuenta = new TiposCuentas();
            tcuenta.TipoID = Convert.ToInt32(IDnumericUpDown.Value);
            tcuenta.Descripcion = DescripciontextBox.Text;
            return tcuenta;
        }

        public void Llenarcampo(TiposCuentas Tcuentas)
        {
            IDnumericUpDown.Value = Tcuentas.TipoID;
            DescripciontextBox.Text = Tcuentas.Descripcion;
           
        }

        private bool ExisteEnLaBD()
        {
            repositorio = new RepositorioBase<TiposCuentas>();
            TiposCuentas tiposDeCuentas = repositorio.Buscar((int)IDnumericUpDown.Value);
            return (tiposDeCuentas != null);

        }

        public bool Validar()
        {
            bool paso = true;

            if(string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "Llenar campo");
                paso = false;
                
            }
            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LImpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<TiposCuentas>();

            TiposCuentas tiposDeCuentas;
            bool paso = false;
            tiposDeCuentas = LlenarClase();
            if (!Validar())
                return;

            if (IDnumericUpDown.Value >= 0)
            {

                paso = repositorio.Guardar(tiposDeCuentas);

            }
            else
            {
                if (!ExisteEnLaBD())
                {
                    MessageBox.Show("No exite ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(tiposDeCuentas);
            }
            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LImpiar();
            }
            else
                MessageBox.Show(" No Guardo !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<TiposCuentas>();
            int.TryParse(IDnumericUpDown.Text, out id);
            if (!ExisteEnLaBD())
            {
                errorProvider.SetError(IDnumericUpDown, "No encontrado");
                IDnumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Elimino con Exito!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LImpiar();
            }
            else
            {
                MessageBox.Show("No exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<TiposCuentas>();
            TiposCuentas tiposDeCuentas = new TiposCuentas();
            int.TryParse(IDnumericUpDown.Text, out id);
            tiposDeCuentas = repositorio.Buscar(id);

            if (tiposDeCuentas != null)
            {
                MessageBox.Show("Econtado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Llenarcampo(tiposDeCuentas);
            }
            else
            {
                MessageBox.Show("No encontrado!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
