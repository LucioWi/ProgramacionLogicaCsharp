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
    public partial class FrmDetalles : Form
    {
        LibroServicio oServicio;
        public enum Modo
        {
            nuevo, ver, editar
        }
        public FrmDetalles(Modo accion, Libro oLibro)
        {
            InitializeComponent();

        }

        private void FrmDetalles_Load(object sender, EventArgs e)
        {

        }
        private void CargarCombo(ComboBox combo)
        {
            combo.DataSource = oServicio.TraerAutores();
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validar datos
            //crear objeto

            L.Titulo = txtTitulo.Text;
            L.Autor = (Autor)cboAutor.SelectedItem;
            if (rbtImpreso.Checked)
            {
                L.Formato = 1;
            }
            else
            {
                L.Formato = 2;
            }
            L.Fecha = dtpFecha.Value;
            L.Precio = double.Parse(txtPrecio.Text);
            //llamar al servicio
            if (oServicio.CrearLibro(L) > 0)
                MessageBox.Show("Se creó nuevo libro! ! !");
        }
    }
}
