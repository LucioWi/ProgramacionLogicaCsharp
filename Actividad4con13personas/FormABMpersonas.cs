using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Actividad4con13personas
{
    public partial class FormABMpersonas : Form
    {
        bool esNuevo = false;

        public FormABMpersonas()
        {
            InitializeComponent();
        }

        private void FormABMpersonas_Load(object sender, EventArgs e)
        {
            habilitar(false);
        }

        private void habilitar(bool x)
        {
            ApellidoBox.Enabled = x;
            NombreBox.Enabled = x;
            TipoDocList.Enabled = x;
            DocBox.Enabled = x;
            EstCivilList.Enabled = x;
            MujerRadio.Enabled = x;
            HombreRadio.Enabled = x;
            FallecidoCheck.Enabled = x;
            Grabar.Enabled = x;
            Cancelar.Enabled = x;
            Nuevo.Enabled = !x;
            Editar.Enabled = !x;
            Borrar.Enabled = !x;
            Salir.Enabled = !x;
            PersonasList.Enabled = !x;
        }

        private void limpiar()
        {
            ApellidoBox.Text = "";
            NombreBox.Text = "";
            TipoDocList.SelectedIndex = -1;
            DocBox.Text = "";
            EstCivilList.SelectedIndex = -1;
            MujerRadio.Checked = false;
            HombreRadio.Checked = false;
            FallecidoCheck.Checked = false;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            habilitar(true);
            limpiar();
            ApellidoBox.Focus();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (PersonasList.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una persona para editar.");
                return;
            }

            esNuevo = false;
            habilitar(true);
            DocBox.Enabled = false;

            Persona p = (Persona)PersonasList.SelectedItem;
            ApellidoBox.Text = p.Apellido;
            NombreBox.Text = p.Nombres;
            TipoDocList.SelectedIndex = p.TipoDocumento;
            DocBox.Text = p.Documento.ToString();
            EstCivilList.SelectedIndex = p.EstadoCivil;
            HombreRadio.Checked = (p.Sexo == 1);
            MujerRadio.Checked = (p.Sexo == 0);
            FallecidoCheck.Checked = p.Fallecio;
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            int index = PersonasList.SelectedIndex;
            if (index != -1)
            {
                PersonasList.Items.RemoveAt(index);
                limpiar();
            }
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona
            {
                Apellido = ApellidoBox.Text,
                Nombres = NombreBox.Text,
                TipoDocumento = TipoDocList.SelectedIndex,
                Documento = int.TryParse(DocBox.Text, out int doc) ? doc : 0,
                EstadoCivil = EstCivilList.SelectedIndex,
                Sexo = HombreRadio.Checked ? 1 : 0, // 1: Hombre, 0: Mujer
                Fallecio = FallecidoCheck.Checked
            };

            if (esNuevo)
            {
                PersonasList.Items.Add(p);
            }
            else
            {
                int index = PersonasList.SelectedIndex;
                if (index != -1)
                {
                    PersonasList.Items[index] = p;
                }
            }

            limpiar();
            habilitar(false);
            esNuevo = false;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(false);
            esNuevo = false;
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
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