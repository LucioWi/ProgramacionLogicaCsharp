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
            label1 = new Label();
            ApellidoBox = new TextBox();
            NombreBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            DocBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            HombreRadio = new RadioButton();
            MujerRadio = new RadioButton();
            FallecidoCheck = new CheckBox();
            Nuevo = new Button();
            Editar = new Button();
            Grabar = new Button();
            Borrar = new Button();
            Salir = new Button();
            Cancelar = new Button();
            PersonasList = new ListBox();
            TipoDocList = new ComboBox();
            EstCivilList = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 65);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellido";
            // 
            // ApellidoBox
            // 
            ApellidoBox.Location = new Point(170, 62);
            ApellidoBox.Name = "ApellidoBox";
            ApellidoBox.Size = new Size(172, 23);
            ApellidoBox.TabIndex = 1;
            ApellidoBox.TextChanged += ApellidoBox_TextChanged;
            // 
            // NombreBox
            // 
            NombreBox.Location = new Point(170, 102);
            NombreBox.Name = "NombreBox";
            NombreBox.Size = new Size(172, 23);
            NombreBox.TabIndex = 3;
            NombreBox.TextChanged += NombreBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 105);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 146);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo Documento";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(662, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // DocBox
            // 
            DocBox.Location = new Point(170, 184);
            DocBox.Name = "DocBox";
            DocBox.Size = new Size(172, 23);
            DocBox.TabIndex = 8;
            DocBox.TextChanged += DocBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 187);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 7;
            label4.Text = "Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 228);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 9;
            label5.Text = "Estado Civil";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 269);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 11;
            label6.Text = "Sexo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 303);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 12;
            label7.Text = "Fallecido";
            // 
            // HombreRadio
            // 
            HombreRadio.AutoSize = true;
            HombreRadio.Location = new Point(170, 267);
            HombreRadio.Name = "HombreRadio";
            HombreRadio.Size = new Size(69, 19);
            HombreRadio.TabIndex = 13;
            HombreRadio.TabStop = true;
            HombreRadio.Text = "Hombre";
            HombreRadio.UseVisualStyleBackColor = true;
            HombreRadio.CheckedChanged += HombreRadio_CheckedChanged;
            // 
            // MujerRadio
            // 
            MujerRadio.AutoSize = true;
            MujerRadio.Location = new Point(244, 267);
            MujerRadio.Name = "MujerRadio";
            MujerRadio.Size = new Size(56, 19);
            MujerRadio.TabIndex = 14;
            MujerRadio.TabStop = true;
            MujerRadio.Text = "Mujer";
            MujerRadio.UseVisualStyleBackColor = true;
            MujerRadio.CheckedChanged += MujerRadio_CheckedChanged;
            // 
            // FallecidoCheck
            // 
            FallecidoCheck.AutoSize = true;
            FallecidoCheck.Location = new Point(170, 304);
            FallecidoCheck.Name = "FallecidoCheck";
            FallecidoCheck.Size = new Size(15, 14);
            FallecidoCheck.TabIndex = 15;
            FallecidoCheck.UseVisualStyleBackColor = true;
            FallecidoCheck.CheckedChanged += FallecidoCheck_CheckedChanged;
            // 
            // Nuevo
            // 
            Nuevo.Location = new Point(32, 401);
            Nuevo.Name = "Nuevo";
            Nuevo.Size = new Size(75, 23);
            Nuevo.TabIndex = 16;
            Nuevo.Text = "Nuevo";
            Nuevo.UseVisualStyleBackColor = true;
            Nuevo.Click += Nuevo_Click;
            // 
            // Editar
            // 
            Editar.Location = new Point(133, 401);
            Editar.Name = "Editar";
            Editar.Size = new Size(75, 23);
            Editar.TabIndex = 17;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // Grabar
            // 
            Grabar.Location = new Point(336, 401);
            Grabar.Name = "Grabar";
            Grabar.Size = new Size(75, 23);
            Grabar.TabIndex = 19;
            Grabar.Text = "Grabar";
            Grabar.UseVisualStyleBackColor = true;
            Grabar.Click += Grabar_Click;
            // 
            // Borrar
            // 
            Borrar.Location = new Point(235, 401);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(75, 23);
            Borrar.TabIndex = 18;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(539, 401);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 21;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click_1;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(438, 401);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 20;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // PersonasList
            // 
            PersonasList.FormattingEnabled = true;
            PersonasList.ItemHeight = 15;
            PersonasList.Location = new Point(383, 62);
            PersonasList.Name = "PersonasList";
            PersonasList.Size = new Size(231, 304);
            PersonasList.TabIndex = 22;
            PersonasList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // TipoDocList
            // 
            TipoDocList.FormattingEnabled = true;
            TipoDocList.Items.AddRange(new object[] { "DNI", "CUIT", "CUIL", "Otro" });
            TipoDocList.Location = new Point(170, 143);
            TipoDocList.Name = "TipoDocList";
            TipoDocList.Size = new Size(172, 23);
            TipoDocList.TabIndex = 23;
            TipoDocList.SelectedIndexChanged += TipoDocList_SelectedIndexChanged;
            // 
            // EstCivilList
            // 
            EstCivilList.FormattingEnabled = true;
            EstCivilList.Items.AddRange(new object[] { "Soltero", "Casado", "Viudo", "Divorciado", "Unión Civil Convivencial", "Separado" });
            EstCivilList.Location = new Point(170, 225);
            EstCivilList.Name = "EstCivilList";
            EstCivilList.Size = new Size(172, 23);
            EstCivilList.TabIndex = 24;
            EstCivilList.SelectedIndexChanged += EstCivilList_SelectedIndexChanged;
            // 
            // FormABMpersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 450);
            Controls.Add(EstCivilList);
            Controls.Add(TipoDocList);
            Controls.Add(PersonasList);
            Controls.Add(Salir);
            Controls.Add(Cancelar);
            Controls.Add(Grabar);
            Controls.Add(Borrar);
            Controls.Add(Editar);
            Controls.Add(Nuevo);
            Controls.Add(FallecidoCheck);
            Controls.Add(MujerRadio);
            Controls.Add(HombreRadio);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(DocBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NombreBox);
            Controls.Add(label2);
            Controls.Add(ApellidoBox);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormABMpersonas";
            Text = "A B M Personas";
            Load += FormABMpersonas_Load;
            ResumeLayout(false);
            PerformLayout();

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
        private ListBox PersonasList;
        private ComboBox TipoDocList;
        private ComboBox EstCivilList;
    }
}
