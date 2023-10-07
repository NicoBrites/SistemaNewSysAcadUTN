namespace SysAcad
{
    partial class FormCursosModificar : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            textCupoMaximo = new TextBox();
            textDescripcion = new TextBox();
            textCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textNombre = new TextBox();
            BtnModificar = new Button();
            label1 = new Label();
            textCodigoNuevo = new TextBox();
            label5 = new Label();
            BtnVolver = new Button();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            comboBoxDias = new ComboBox();
            comboBoxAulas = new ComboBox();
            comboBoxTurnos = new ComboBox();
            SuspendLayout();
            // 
            // textCupoMaximo
            // 
            textCupoMaximo.Location = new Point(241, 394);
            textCupoMaximo.Name = "textCupoMaximo";
            textCupoMaximo.Size = new Size(100, 23);
            textCupoMaximo.TabIndex = 17;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(241, 302);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 23);
            textDescripcion.TabIndex = 16;
            textDescripcion.TextChanged += textDescripcion_TextChanged;
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(94, 204);
            textCodigo.Name = "textCodigo";
            textCodigo.ReadOnly = true;
            textCodigo.Size = new Size(100, 23);
            textCodigo.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 353);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 14;
            label4.Text = "Cupo maximo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 284);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 13;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 161);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 12;
            label2.Text = "Codigo";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(241, 104);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 11;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(266, 532);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(75, 23);
            BtnModificar.TabIndex = 10;
            BtnModificar.Text = "Agregar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 63);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // textCodigoNuevo
            // 
            textCodigoNuevo.Location = new Point(241, 204);
            textCodigoNuevo.Name = "textCodigoNuevo";
            textCodigoNuevo.Size = new Size(100, 23);
            textCodigoNuevo.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 161);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 19;
            label5.Text = "Codigo nuevo";
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(378, 532);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(75, 23);
            BtnVolver.TabIndex = 20;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(428, 349);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 23;
            label7.Text = "Turno";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 280);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 22;
            label6.Text = "Aula";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(428, 161);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 21;
            label8.Text = "Dia de la cursada";
            // 
            // comboBox1
            // 
            comboBoxDias.FormattingEnabled = true;
            comboBoxDias.Location = new Point(428, 204);
            comboBoxDias.Name = "comboBox1";
            comboBoxDias.Size = new Size(121, 23);
            comboBoxDias.TabIndex = 24;
            // 
            // comboBox2
            // 
            comboBoxAulas.FormattingEnabled = true;
            comboBoxAulas.Location = new Point(428, 298);
            comboBoxAulas.Name = "comboBox2";
            comboBoxAulas.Size = new Size(121, 23);
            comboBoxAulas.TabIndex = 25;
            // 
            // comboBox3
            // 
            comboBoxTurnos.FormattingEnabled = true;
            comboBoxTurnos.Location = new Point(428, 394);
            comboBoxTurnos.Name = "comboBox3";
            comboBoxTurnos.Size = new Size(121, 23);
            comboBoxTurnos.TabIndex = 26;
            // 
            // FormCursosModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 636);
            Controls.Add(comboBoxTurnos);
            Controls.Add(comboBoxAulas);
            Controls.Add(comboBoxDias);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(BtnVolver);
            Controls.Add(label5);
            Controls.Add(textCodigoNuevo);
            Controls.Add(textCupoMaximo);
            Controls.Add(textDescripcion);
            Controls.Add(textCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textNombre);
            Controls.Add(BtnModificar);
            Controls.Add(label1);
            Name = "FormCursosModificar";
            Text = "FormCursosModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textCupoMaximo;
        public TextBox textDescripcion;
        public TextBox textCodigo;
        private Label label4;
        private Label label3;
        private Label label2;
        public TextBox textNombre;
        private Button BtnModificar;
        private Label label1;
        private TextBox textCodigoNuevo;
        private Label label5;
        private Button BtnVolver;
        private Label label7;
        private Label label6;
        private Label label8;
        public ComboBox comboBoxDias;
        public ComboBox comboBoxAulas;
        public ComboBox comboBoxTurnos;
    }
}