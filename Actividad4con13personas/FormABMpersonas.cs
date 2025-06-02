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
        const int tamanio=100;
        Persona[] aPersonas = new Persona[tamanio];
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
            CargarLista();
        }

        private void CargarLista()
        {
            miConexion.Open();
            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = "Select * from Personas";

            SqlDataReader dr = miComando.ExecuteReader(); /*datareader = conectado | datatable = no conectado

int posicion = 0;

while (dr.Read()) /*lee hasta el final del data reader
{
    Persona p = new Persona();

    if (!dr.IsDBNull(0)) /*con esto deja de dar un error si es null
        p.Apellido = dr[0].ToString(); /*Opcion 1 con la posicion
    if (!dr.IsDBNull(1))
        p.Nombres = dr["nombres"].ToString(); /*Opcion 2 con el nombre directamente
    if (!dr.IsDBNull(2))
        p.TipoDocumento = dr.GetInt32(2); /*Opcion 3 solo para enteros | Si es null dará error
    if (!dr.IsDBNull(3))
        p.Documento = Convert.ToInt32(dr[3].ToString());/*Opcion 4 Documento se vuelve string y luego vuelve a entero | Si el valor es nulo puede dar error
    if (!dr.IsDBNull(4))
        p.EstadoCivil = dr.GetInt32(4);
    if (!dr.IsDBNull(5))
        p.Sexo = dr.GetInt32(5);
    if (!dr.IsDBNull(6))
        p.Fallecio = dr.GetBoolean(6); /*Opcion 5 para booleanos
    if (!dr.IsDBNull(7))
        p.FechaNacimiento = dr.GetDateTime(7);/*Opcion 6 para datetimes

    aPersonas[posicion] = p;
    posicion++;

    if (posicion == tamanio)
    {
        break;
    }
}
dr.Close();
miConexion.Close();

lstPersonas.Items.Clear(); //Ya que se piensa agregar, modificar y eliminar personas. Con esto carga y se recarga
//lstPersonas.DataSource= aPersonas; /*Muestra el arreglo en la listbox
for (int i = 0; i < posicion; i++)
{
    lstPersonas.Items.Add(aPersonas[i]);
}
            
            
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

private void btnBorrar_Click(object sender, EventArgs e) //No se suelen borrar datos hoy en día
{
    if (MessageBox.Show("¿Está seguro de eliminar esta persona?"
        , "¿Borrar?"
        , MessageBoxButtons.YesNo
        , MessageBoxIcon.Warning
        , MessageBoxDefaultButton.Button2)
        == DialogResult.Yes)
    {
        miConexion.Open();

        miComando = new SqlCommand();
        miComando.Connection = miConexion;
        miComando.CommandType = CommandType.Text;
        miComando.CommandText = "Delete from Personas where documento = " + aPersonas[lstPersonas.SelectedIndex].Documento;
        miComando.ExecuteNonQuery(); //Para ejecutar un comando sin más (Sin filas o columnas involucradas)

        miConexion.Close();

        CargarLista(); //Actualizar la lista gracias al metodo ya creado
    }
}

private void btnCancelar_Click(object sender, EventArgs e)
{

    limpiar();
    habilitar(false);
    esNuevo = false;
}

private void btnGrabar_Click(object sender, EventArgs e)
{
    Persona p = new Persona();

    if (ValidarDatos())
    {
        p.Apellido = txtApellido.Text;
        p.Nombres = txtNombres.Text;
        p.TipoDocumento = (int)cboTipoDocumento.SelectedValue;
        p.Documento = int.Parse(txtDocumento.Text); // funciona igual que la anterior
        p.EstadoCivil = (int)cboEstadoCivil.SelectedValue;
        p.FechaNacimiento = dtpFechaNacimiento.Value;

        if (rbtMasculino.Checked)
            p.Sexo = 1;
        else
            p.Sexo = 0;
        p.Fallecio = chkFallecio.Checked;


    }

    if (esNuevo)
    {

        // VALIDAR QUE NO EXISTA LA PK !!!!!! (SI NO ES AUTOINCREMENTAL / IDENTITY)
        if (!ExistePK(p.Documento))
        {
            /* insert con sentencia SQL tradicional

            string consultaSQL = "Insert into Personas Values ('"+p.Apellido+"', '"+p.Nombres+"', "+p.TipoDocumento+", "+p.Documento+", "+p.EstadoCivil+", "+p.Sexo+", "+", '"+p.Fallecio+"', '"+p.FechaNacimiento.ToString("yyyy/MM/dd")+"')";
            miConexion.Open();

            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = consultaSQL;
            miComando.ExecuteNonQuery(); //Para ejecutar un comando sin más (Sin filas o columnas involucradas)

            miConexion.Close();

            CargarLista(); //Actualizar la lista gracias al metodo ya creado

            fin del comentario aca

            // insert usando parámetros
            string consultaSQL = "Insert into Personas Values (@apellido,@nombres,@tipo_documento,@documento,@estado_civil,@sexo,@fallecio,@fecha_nacimiento)";

            miConexion.Open();

            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = consultaSQL;
            miComando.Parameters.AddWithValue("@apellido", p.Apellido);

            miComando.ExecuteNonQuery(); //Para ejecutar un comando sin más (Sin filas o columnas involucradas)

            miConexion.Close();

            CargarLista();
        }

        habilitar(false);
        esNuevo = false;
    }
}

private bool ExistePK(object documento)
{
    int pk = 0;

    miConexion.Open();

    miComando = new SqlCommand();
    miComando.Connection = miConexion;
    miComando.CommandType = CommandType.Text;
    miComando.CommandText = "Select * from Personas where documento = " + pk;

    DataTable miTabla = new DataTable();
    miTabla.Load(miComando.ExecuteReader());

    miConexion.Close();

    if (miTabla.Rows.Count > 0)
        return true;
    else
        return false;
}

private bool ValidarDatos()
{
    if (txtApellido.Text == string.Empty)
    {
        MessageBox.Show("Debe ingresar apellido."); /*Saltar un cartel
        txtApellido.Focus(); /*Fijar el form en apellido para facilitar la corrección
        return false;
    }

    if (txtNombres.Text.Equals(string.Empty)) /*funciona igual que el anterior
    {
        MessageBox.Show("Debe ingresar nombre.");
        txtNombres.Focus();
        return false;
    }

    if (cboTipoDocumento.SelectedIndex == -1) /*para combo box
    {
        MessageBox.Show("Debe ingresar un tipo de documento.");
        cboTipoDocumento.Focus();
        return false;
    }

    if (txtDocumento.Equals(string.Empty))
    {
        MessageBox.Show("Debe ingresar documento.");
        txtDocumento.Focus();
        return false;
    }

    if (cboEstadoCivil.SelectedIndex == -1)
    {
        MessageBox.Show("Debe ingresar estado civil.");
        cboEstadoCivil.Focus();
        return false;
    }

    if (dtpFechaNacimiento.Value > DateTime.Today)
    {
        MessageBox.Show("Ingrese una fecha de nacimiento real.");
        dtpFechaNacimiento.Focus();
        return false;
    }

    if (!rbtMasculino.Checked && !rbtFemenino.Checked)
    {
        MessageBox.Show("Debe elegir un sexo.");
        rbtMasculino.Focus();
        return false;
    }

    return true;
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
    CargarCampos(aPersonas[lstPersonas.SelectedIndex]); /*SelectedIndex = La posición de la lista en la que el usuario esta seleccionando
}

private void CargarCampos(Persona persona)
{
    txtApellido.Text = persona.Apellido;
    txtNombres.Text = persona.Nombres;
    txtDocumento.Text = persona.Documento.ToString(); /*Convertirlo en string para evitar errores
    cboTipoDocumento.SelectedValue = persona.TipoDocumento; /*Para combo box
    cboEstadoCivil.SelectedValue = persona.EstadoCivil;
    dtpFechaNacimiento.Value = persona.FechaNacimiento; /*Para datetime
    if (persona.Sexo == 1) /*Para radio buttons con 2 alternativas*/ /*si es nulo pondrá femenino
        rbtMasculino.Checked = true;
    else rbtFemenino.Checked = true;

    chkFallecio.Checked = persona.Fallecio; /*Para check box | booleano
}
    }
}


 */