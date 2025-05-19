namespace Actividad4con13personas
{
    public partial class FormABMpersonas : Form
    {
        public FormABMpersonas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
        {

        }

        private void Borrar_Click(object sender, EventArgs e)
        {

        }

        private void Grabar_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApellidoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TipoDocList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DocBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EstCivilList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HombreRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MujerRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FallecidoCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormABMpersonas_Load(object sender, EventArgs e)
        {

        }
    }
}
/*
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABMPersonas
{
    public partial class frmPersona : Form
    {
        bool esNuevo = false;

        SqlConnection miConexion = new SqlConnection("Data Source=172.16.10.196;Initial Catalog=TUPPI;User ID=alumno1w1; Encrypt = false; Password=alumno1w1");
        SqlCommand miComando = null;

        private void CargarCombo(ComboBox combo, string nombreTabla)
        {
            miConexion.Open();
            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = "Select * from " + nombreTabla + " order by 2";

            DataTable miTabla = new DataTable();
            miTabla.Load(miComando.ExecuteReader());

            miConexion.Close();

            combo.DataSource = miTabla;
            combo.DisplayMember = miTabla.Columns[1].ColumnName;
            combo.ValueMember = miTabla.Columns[0].ColumnName;
        }

            public frmPersona()
        {
            InitializeComponent();
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            habilitar(false);
            CargarCombo(cboTipoDocumento, "tipo_documento");
            CargarCombo(cboEstadoCivil, "estado_civil");
            
        }
        
  
        private void habilitar(bool x)
        {
            txtApellido.Enabled = x;
            txtNombres.Enabled = x;
            cboTipoDocumento.Enabled = x;
            txtDocumento.Enabled = x;
            cboEstadoCivil.Enabled = x;
            dtpFechaNacimiento.Enabled = x;
            rbtFemenino.Enabled = x;
            rbtMasculino.Enabled = x;
            chkFallecio.Enabled = x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            lstPersonas.Enabled = !x;
        }

        private void limpiar()
        {
            txtApellido.Text = "";
            txtNombres.Text = "";
            cboTipoDocumento.SelectedIndex = -1;
            txtDocumento.Text = "";
            cboEstadoCivil.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Today;
            rbtFemenino.Checked = false;
            rbtMasculino.Checked = false;
            chkFallecio.Checked = false;
        }
      
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            habilitar(true);
            limpiar();
            txtApellido.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            txtDocumento.Enabled = false;
            txtApellido.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
                

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            limpiar();
            habilitar(false);
            esNuevo = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
    

            if (esNuevo) 
                {

                    // VALIDAR QUE NO EXISTA LA PK !!!!!! (SI NO ES AUTOINCREMENTAL / IDENTITY)

                    // insert con sentencia SQL tradicional

                    // insert usando parámetros


                habilitar(false);
                esNuevo = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                this.Close();
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

 */