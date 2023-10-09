namespace SysAcad
{
    partial class FormCursosAgregar
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
        private void InitializeComponent()
        {
            label1 = new Label();
            BtnAgregar = new Button();
            textNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textCodigo = new TextBox();
            textDescripcion = new TextBox();
            textCupoMaximo = new TextBox();
            BtnVolver = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxDias = new ComboBox();
            comboBoxAulas = new ComboBox();
            comboBoxTurnos = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 54);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(71, 307);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(63, 82);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 108);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 164);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 234);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 5;
            label4.Text = "Cupo maximo";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(63, 129);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(100, 23);
            textCodigo.TabIndex = 6;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(63, 194);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 23);
            textDescripcion.TabIndex = 7;
            // 
            // textCupoMaximo
            // 
            textCupoMaximo.Location = new Point(63, 256);
            textCupoMaximo.Name = "textCupoMaximo";
            textCupoMaximo.Size = new Size(100, 23);
            textCupoMaximo.TabIndex = 8;
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(227, 307);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(75, 23);
            BtnVolver.TabIndex = 9;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 108);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 10;
            label5.Text = "Dia de la cursada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 164);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 11;
            label6.Text = "Aula";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 234);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 12;
            label7.Text = "Turno";
            // 
            // comboBoxDias
            // 
            comboBoxDias.FormattingEnabled = true;
            comboBoxDias.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" });
            comboBoxDias.Location = new Point(215, 129);
            comboBoxDias.Name = "comboBoxDias";
            comboBoxDias.Size = new Size(121, 23);
            comboBoxDias.TabIndex = 16;
            comboBoxDias.SelectedIndexChanged += comboBoxDias_SelectedIndexChanged;
            // 
            // comboBoxAulas
            // 
            comboBoxAulas.FormattingEnabled = true;
            comboBoxAulas.Items.AddRange(new object[] { "Aula505", "Aula606", "Aula707", "Aula808" });
            comboBoxAulas.Location = new Point(215, 194);
            comboBoxAulas.Name = "comboBoxAulas";
            comboBoxAulas.Size = new Size(121, 23);
            comboBoxAulas.TabIndex = 17;
            // 
            // comboBoxTurnos
            // 
            comboBoxTurnos.FormattingEnabled = true;
            comboBoxTurnos.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            comboBoxTurnos.Location = new Point(215, 256);
            comboBoxTurnos.Name = "comboBoxTurnos";
            comboBoxTurnos.Size = new Size(121, 23);
            comboBoxTurnos.TabIndex = 18;
            // 
            // FormCursosAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 377);
            Controls.Add(comboBoxTurnos);
            Controls.Add(comboBoxAulas);
            Controls.Add(comboBoxDias);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BtnVolver);
            Controls.Add(textCupoMaximo);
            Controls.Add(textDescripcion);
            Controls.Add(textCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textNombre);
            Controls.Add(BtnAgregar);
            Controls.Add(label1);
            Name = "FormCursosAgregar";
            Text = "FormCursosAgregar";
            Load += FormCursosAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textNombre;
        private TextBox textCodigo;
        private TextBox textDescripcion;
        private TextBox textCupoMaximo;
        private Button BtnAgregar;
        private Button BtnVolver;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxDias;
        private ComboBox comboBoxAulas;
        private ComboBox comboBoxTurnos;
    }
}