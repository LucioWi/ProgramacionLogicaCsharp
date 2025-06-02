using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMLibros1w2.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibros fl= new FrmLibros();
            fl.ShowDialog();
        }

        private void consulta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta fc= new FrmConsulta();
            fc.ShowDialog();
        }
    }
}
