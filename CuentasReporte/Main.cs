using CuentasReporte.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasReporte
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presupuest ps = new Presupuest();
            ps.Show();
            ps.MdiParent = this;
        }
    }
}
