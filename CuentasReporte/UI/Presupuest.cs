using CuentasReporte.BLL;
using CuentasReporte.DAL;
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
    public partial class Presupuest : Form
    {
        RepositorioBase<Presupuesto> repositorio;
        public List<CuentasDetalle>Detalle { get; set; }
        public Presupuest()
        {
            InitializeComponent();
            this.Detalle = new List<CuentasDetalle>();
            LlenarComboBox();
        }

        public void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            MontonumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;


        }
        public void LlenarComboBox()
        {
            RepositorioBase<CuentasDetalle> repositorio = new RepositorioBase<CuentasDetalle>();
            TipoCuentascomboBox.DataSource = repositorio.GetList(x => true);
            TipoCuentascomboBox.ValueMember = "CuentaID";
            TipoCuentascomboBox.DisplayMember = "Descripcion";


        }

        private void LlenaCampo(Presupuesto presupuesto)
        {
            IDnumericUpDown.Value = presupuesto.presupuestoid;
            DescripciontextBox.Text = presupuesto.Descripcion;
            MontonumericUpDown.Value = Convert.ToDecimal(presupuesto.Monto);
            this.Detalle = presupuesto.Cuentas;
            CargarGrid();
        }

        private Presupuesto LlenaClase()
        {
            Presupuesto presupuesto = new Presupuesto()
            {
                presupuestoid = Convert.ToInt32(IDnumericUpDown.Value),
                Descripcion = DescripciontextBox.Text,
                Monto = Convert.ToSingle(MontonumericUpDown.Value),
                Fecha = FechadateTimePicker.Value,
                
            };
            presupuesto.Cuentas = this.Detalle;
            return presupuesto;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            repositorio = new RepositorioBase<Presupuesto>();
            Presupuesto presupuesto = new Presupuesto();
            int.TryParse(IDnumericUpDown.Text, out id);
            presupuesto = repositorio.Buscar(id);
            if (presupuesto != null)
            {
                LlenaCampo(presupuesto);
                MessageBox.Show("Encotrada");
            }
            else
            {
                MessageBox.Show("No Encotro");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private bool Validar()
        {
            bool paso = true;
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "Campo Vacio");
                paso = false;
            }
            if (MontonumericUpDown.Value == 0)
            {
                errorProvider.SetError(MontonumericUpDown, "El valor tiene que ser mayor a cero");
                paso = false;

            }
            if (FechadateTimePicker.Value < DateTime.Now)
            {
                errorProvider.SetError(FechadateTimePicker, "Fecha Invalida");
                paso = false;
            }
            return paso;
        }

        private bool ExiteEnLaDb()
        {
            repositorio = new RepositorioBase<Presupuesto>();
            Presupuesto presupuesto = repositorio.Buscar((int)IDnumericUpDown.Value);
            return (presupuesto != null);

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Presupuesto>();
            Presupuesto presupuesto;
            bool paso = false;

            presupuesto = LlenaClase();
            if (!Validar())
                return;

            if (IDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(presupuesto);
            else
            {
                if (!ExiteEnLaDb())
                {
                    MessageBox.Show("No se puede modificar no Exite!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                paso = repositorio.Modificar(presupuesto);
            }
              Limpiar();
            if (paso)
            {
                MessageBox.Show("Guadado!!", "Guardo", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            else
            {
                MessageBox.Show("No Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            repositorio = new RepositorioBase<Presupuesto>();
            int.TryParse(IDnumericUpDown.Text, out id);
            if (!ExiteEnLaDb())
            {
                errorProvider.SetError(IDnumericUpDown, "No Eliminado");
                IDnumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
                MessageBox.Show("Eliminada ");
            else
            {
                MessageBox.Show("No Elimino");
            }
        }

        private void CargarGrid()
        {
            CuentadataGridView.DataSource = null;
            CuentadataGridView.DataSource = this.Detalle;
        }
        private void Agragar_Click(object sender, EventArgs e)
        {
            if (CuentadataGridView.DataSource != null)
            {
                this.Detalle = (List<CuentasDetalle>)CuentadataGridView.DataSource;
            }
            this.Detalle.Add(
                new CuentasDetalle
                (
              CuentaID: 0,
              Descripcion: TipoCuentascomboBox.Text,
              tipoid : (int)IDnumericUpDown.Value,
              Monto : (double)MontonumericUpDown.Value

                )
                );
            CargarGrid();
            DescripciontextBox.Focus();
            DescripciontextBox.Clear();

        }

        private void TipodeCuentabutton_Click(object sender, EventArgs e)
        {
            Cuenta tp = new Cuenta();
            tp.Show();
        }

        private void RemoveFilabutton_Click(object sender, EventArgs e)
        {
            if(CuentadataGridView.Rows.Count > 0 && CuentadataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(CuentadataGridView.CurrentRow.Index);
                CargarGrid();
            }

        }
    }
}
