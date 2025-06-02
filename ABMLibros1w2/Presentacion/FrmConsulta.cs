using ABMLibros1w2.Datos;
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
    public partial class FrmConsulta : Form
    {
        AccesoDatos oBD;
        public FrmConsulta()
        {
            InitializeComponent();
            oBD= new AccesoDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consultaSQL = "Select * from libros ";
            if (radioButton1.Checked)
                consultaSQL += "where formato=1";
            if (radioButton2.Checked)
                consultaSQL += "where formato=2";

            dataGridView1.DataSource = oBD.ConsultarBD(consultaSQL);
        }
    }
}
