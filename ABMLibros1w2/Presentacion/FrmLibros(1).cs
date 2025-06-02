
using ABMLibros1w2.Negocio;
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
    public partial class FrmLibros : Form
    {
        LibroServicio oServicio;
        public FrmLibros()
        {
            InitializeComponent();
            oServicio= new LibroServicio();
        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            CargarCombo(CboAutor);
        }

        private void CargarCombo(ComboBox combo)
        {
            combo.DataSource = oServicio.TraerAutores();
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (ChkTodos.Checked)
            {
                List<Libro> lista = oServicio.TraerLibros();
                foreach (Libro L in lista)
                {
                    DgvLibros.Rows.Add(L.Codigo, L.Titulo, L.Autor.Nombre);
                }
            }
        }
    }
}
