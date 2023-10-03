namespace SysAcad
{
    partial class FormRegistroEstudiante
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
            btnCrearEstudiante = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textDni = new TextBox();
            textDireccion = new TextBox();
            textNumTelefono = new TextBox();
            textCorreoElectronico = new TextBox();
            textContraseñaProv = new TextBox();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnCrearEstudiante
            // 
            btnCrearEstudiante.Location = new Point(124, 528);
            btnCrearEstudiante.Name = "btnCrearEstudiante";
            btnCrearEstudiante.Size = new Size(196, 26);
            btnCrearEstudiante.TabIndex = 0;
            btnCrearEstudiante.Text = "Crear Estudiante";
            btnCrearEstudiante.UseVisualStyleBackColor = true;
            btnCrearEstudiante.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 47);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 114);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 180);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "Dni";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 263);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 345);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 5;
            label5.Text = "Numero de telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(191, 415);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 6;
            label6.Text = "Correo electronico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(192, 468);
            label7.Name = "label7";
            label7.Size = new Size(128, 15);
            label7.TabIndex = 7;
            label7.Text = "Contraseña provisional";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(183, 65);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 8;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(183, 132);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(100, 23);
            textApellido.TabIndex = 9;
            // 
            // textDni
            // 
            textDni.Location = new Point(183, 215);
            textDni.Name = "textDni";
            textDni.Size = new Size(100, 23);
            textDni.TabIndex = 10;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(183, 291);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(100, 23);
            textDireccion.TabIndex = 11;
            // 
            // textNumTelefono
            // 
            textNumTelefono.Location = new Point(183, 373);
            textNumTelefono.Name = "textNumTelefono";
            textNumTelefono.Size = new Size(100, 23);
            textNumTelefono.TabIndex = 12;
            // 
            // textCorreoElectronico
            // 
            textCorreoElectronico.Location = new Point(191, 433);
            textCorreoElectronico.Name = "textCorreoElectronico";
            textCorreoElectronico.Size = new Size(100, 23);
            textCorreoElectronico.TabIndex = 13;
            // 
            // textContraseñaProv
            // 
            textContraseñaProv.Location = new Point(191, 486);
            textContraseñaProv.Name = "textContraseñaProv";
            textContraseñaProv.Size = new Size(100, 23);
            textContraseñaProv.TabIndex = 14;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(379, 528);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // FormRegistroEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 583);
            Controls.Add(btnVolver);
            Controls.Add(textContraseñaProv);
            Controls.Add(textCorreoElectronico);
            Controls.Add(textNumTelefono);
            Controls.Add(textDireccion);
            Controls.Add(textDni);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrearEstudiante);
            Name = "FormRegistroEstudiante";
            Text = "FormRegistroEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearEstudiante;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDni;
        private TextBox textDireccion;
        private TextBox textNumTelefono;
        private TextBox textCorreoElectronico;
        private TextBox textContraseñaProv;
        private Button btnVolver;
    }
}