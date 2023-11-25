namespace SysAcad
{
    partial class FormProfesorAgregar
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
            btnVolver = new Button();
            textContraseñaProv = new TextBox();
            textCorreoElectronico = new TextBox();
            textNumTelefono = new TextBox();
            textDni = new TextBox();
            textApellido = new TextBox();
            textNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCrearEstudiante = new Button();
            label8 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(118, 393);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 31;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // textContraseñaProv
            // 
            textContraseñaProv.Location = new Point(102, 272);
            textContraseñaProv.Name = "textContraseñaProv";
            textContraseñaProv.Size = new Size(100, 23);
            textContraseñaProv.TabIndex = 30;
            // 
            // textCorreoElectronico
            // 
            textCorreoElectronico.Location = new Point(102, 228);
            textCorreoElectronico.Name = "textCorreoElectronico";
            textCorreoElectronico.Size = new Size(100, 23);
            textCorreoElectronico.TabIndex = 29;
            // 
            // textNumTelefono
            // 
            textNumTelefono.Location = new Point(102, 184);
            textNumTelefono.Name = "textNumTelefono";
            textNumTelefono.Size = new Size(100, 23);
            textNumTelefono.TabIndex = 28;
            // 
            // textDni
            // 
            textDni.Location = new Point(102, 137);
            textDni.Name = "textDni";
            textDni.Size = new Size(100, 23);
            textDni.TabIndex = 26;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(102, 93);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(100, 23);
            textApellido.TabIndex = 25;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(102, 49);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(102, 254);
            label7.Name = "label7";
            label7.Size = new Size(128, 15);
            label7.TabIndex = 23;
            label7.Text = "Contraseña provisional";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 210);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 22;
            label6.Text = "Correo electronico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 166);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 21;
            label5.Text = "Numero de telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 119);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 19;
            label3.Text = "Dni";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 18;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 17;
            label1.Text = "Nombre";
            // 
            // btnCrearEstudiante
            // 
            btnCrearEstudiante.Location = new Point(59, 361);
            btnCrearEstudiante.Name = "btnCrearEstudiante";
            btnCrearEstudiante.Size = new Size(196, 26);
            btnCrearEstudiante.TabIndex = 16;
            btnCrearEstudiante.Text = "Crear Profesor";
            btnCrearEstudiante.UseVisualStyleBackColor = true;
            btnCrearEstudiante.Click += btnCrearEstudiante_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(110, 298);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 32;
            label8.Text = "Especialidades";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 316);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 33;
            // 
            // FormProfesorAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 476);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(btnVolver);
            Controls.Add(textContraseñaProv);
            Controls.Add(textCorreoElectronico);
            Controls.Add(textNumTelefono);
            Controls.Add(textDni);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrearEstudiante);
            Name = "FormProfesorAgregar";
            Text = "FormProfesorAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private TextBox textContraseñaProv;
        private TextBox textCorreoElectronico;
        private TextBox textNumTelefono;
        private TextBox textDni;
        private TextBox textApellido;
        private TextBox textNombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCrearEstudiante;
        private Label label8;
        private TextBox textBox1;
    }
}