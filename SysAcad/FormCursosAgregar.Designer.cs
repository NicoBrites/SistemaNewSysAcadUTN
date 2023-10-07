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
            textDiaSemana = new TextBox();
            textAula = new TextBox();
            textTurno = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(238, 504);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(267, 76);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 137);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 256);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 325);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 5;
            label4.Text = "Cupo maximo";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(267, 180);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(100, 23);
            textCodigo.TabIndex = 6;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(267, 274);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 23);
            textDescripcion.TabIndex = 7;
            // 
            // textCupoMaximo
            // 
            textCupoMaximo.Location = new Point(267, 366);
            textCupoMaximo.Name = "textCupoMaximo";
            textCupoMaximo.Size = new Size(100, 23);
            textCupoMaximo.TabIndex = 8;
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(377, 504);
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
            label5.Location = new Point(471, 137);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "Dia de la cursada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 256);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 11;
            label6.Text = "Aula";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(471, 325);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 12;
            label7.Text = "Turno";
            // 
            // textBox1
            // 
            textDiaSemana.Location = new Point(439, 180);
            textDiaSemana.Name = "textBox1";
            textDiaSemana.Size = new Size(100, 23);
            textDiaSemana.TabIndex = 13;
            // 
            // textBox2
            // 
            textAula.Location = new Point(439, 274);
            textAula.Name = "textBox2";
            textAula.Size = new Size(100, 23);
            textAula.TabIndex = 14;
            // 
            // textBox3
            // 
            textTurno.Location = new Point(439, 366);
            textTurno.Name = "textBox3";
            textTurno.Size = new Size(100, 23);
            textTurno.TabIndex = 15;
            // 
            // FormCursosAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 661);
            Controls.Add(textTurno);
            Controls.Add(textAula);
            Controls.Add(textDiaSemana);
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
        private TextBox textDiaSemana;
        private TextBox textAula;
        private TextBox textTurno;
    }
}