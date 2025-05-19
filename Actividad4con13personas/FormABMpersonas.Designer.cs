namespace Actividad4con13personas
{
    partial class FormABMpersonas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ApellidoBox = new System.Windows.Forms.TextBox();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DocBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HombreRadio = new System.Windows.Forms.RadioButton();
            this.MujerRadio = new System.Windows.Forms.RadioButton();
            this.FallecidoCheck = new System.Windows.Forms.CheckBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Grabar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.TipoDocList = new System.Windows.Forms.ComboBox();
            this.EstCivilList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido";
            // 
            // ApellidoBox
            // 
            this.ApellidoBox.Location = new System.Drawing.Point(170, 62);
            this.ApellidoBox.Name = "ApellidoBox";
            this.ApellidoBox.Size = new System.Drawing.Size(172, 23);
            this.ApellidoBox.TabIndex = 1;
            this.ApellidoBox.TextChanged += new System.EventHandler(this.ApellidoBox_TextChanged);
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(170, 102);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(172, 23);
            this.NombreBox.TabIndex = 3;
            this.NombreBox.TextChanged += new System.EventHandler(this.NombreBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Documento";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DocBox
            // 
            this.DocBox.Location = new System.Drawing.Point(170, 184);
            this.DocBox.Name = "DocBox";
            this.DocBox.Size = new System.Drawing.Size(172, 23);
            this.DocBox.TabIndex = 8;
            this.DocBox.TextChanged += new System.EventHandler(this.DocBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado Civil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fallecido";
            // 
            // HombreRadio
            // 
            this.HombreRadio.AutoSize = true;
            this.HombreRadio.Location = new System.Drawing.Point(170, 267);
            this.HombreRadio.Name = "HombreRadio";
            this.HombreRadio.Size = new System.Drawing.Size(69, 19);
            this.HombreRadio.TabIndex = 13;
            this.HombreRadio.TabStop = true;
            this.HombreRadio.Text = "Hombre";
            this.HombreRadio.UseVisualStyleBackColor = true;
            this.HombreRadio.CheckedChanged += new System.EventHandler(this.HombreRadio_CheckedChanged);
            // 
            // MujerRadio
            // 
            this.MujerRadio.AutoSize = true;
            this.MujerRadio.Location = new System.Drawing.Point(244, 267);
            this.MujerRadio.Name = "MujerRadio";
            this.MujerRadio.Size = new System.Drawing.Size(56, 19);
            this.MujerRadio.TabIndex = 14;
            this.MujerRadio.TabStop = true;
            this.MujerRadio.Text = "Mujer";
            this.MujerRadio.UseVisualStyleBackColor = true;
            this.MujerRadio.CheckedChanged += new System.EventHandler(this.MujerRadio_CheckedChanged);
            // 
            // FallecidoCheck
            // 
            this.FallecidoCheck.AutoSize = true;
            this.FallecidoCheck.Location = new System.Drawing.Point(170, 304);
            this.FallecidoCheck.Name = "FallecidoCheck";
            this.FallecidoCheck.Size = new System.Drawing.Size(15, 14);
            this.FallecidoCheck.TabIndex = 15;
            this.FallecidoCheck.UseVisualStyleBackColor = true;
            this.FallecidoCheck.CheckedChanged += new System.EventHandler(this.FallecidoCheck_CheckedChanged);
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(32, 401);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Nuevo.TabIndex = 16;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(133, 401);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 17;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Grabar
            // 
            this.Grabar.Location = new System.Drawing.Point(336, 401);
            this.Grabar.Name = "Grabar";
            this.Grabar.Size = new System.Drawing.Size(75, 23);
            this.Grabar.TabIndex = 19;
            this.Grabar.Text = "Grabar";
            this.Grabar.UseVisualStyleBackColor = true;
            this.Grabar.Click += new System.EventHandler(this.Grabar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(235, 401);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 18;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(539, 401);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 21;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click_1);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(438, 401);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 20;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(383, 62);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(231, 304);
            this.listBox.TabIndex = 22;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TipoDocList
            // 
            this.TipoDocList.FormattingEnabled = true;
            this.TipoDocList.Items.AddRange(new object[] {
            "DNI",
            "CUIT",
            "CUIL",
            "Otro"});
            this.TipoDocList.Location = new System.Drawing.Point(170, 143);
            this.TipoDocList.Name = "TipoDocList";
            this.TipoDocList.Size = new System.Drawing.Size(172, 23);
            this.TipoDocList.TabIndex = 23;
            this.TipoDocList.SelectedIndexChanged += new System.EventHandler(this.TipoDocList_SelectedIndexChanged);
            // 
            // EstCivilList
            // 
            this.EstCivilList.FormattingEnabled = true;
            this.EstCivilList.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Divorciado",
            "Unión Civil Convivencial",
            "Separado"});
            this.EstCivilList.Location = new System.Drawing.Point(170, 225);
            this.EstCivilList.Name = "EstCivilList";
            this.EstCivilList.Size = new System.Drawing.Size(172, 23);
            this.EstCivilList.TabIndex = 24;
            this.EstCivilList.SelectedIndexChanged += new System.EventHandler(this.EstCivilList_SelectedIndexChanged);
            // 
            // FormABMpersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.EstCivilList);
            this.Controls.Add(this.TipoDocList);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Grabar);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.FallecidoCheck);
            this.Controls.Add(this.MujerRadio);
            this.Controls.Add(this.HombreRadio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DocBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApellidoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormABMpersonas";
            this.Text = "A B M Personas";
            this.Load += new System.EventHandler(this.FormABMpersonas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox ApellidoBox;
        private TextBox NombreBox;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private TextBox DocBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RadioButton HombreRadio;
        private RadioButton MujerRadio;
        private CheckBox FallecidoCheck;
        private Button Nuevo;
        private Button Editar;
        private Button Grabar;
        private Button Borrar;
        private Button Salir;
        private Button Cancelar;
        private ListBox listBox;
        private ComboBox TipoDocList;
        private ComboBox EstCivilList;
    }
}
