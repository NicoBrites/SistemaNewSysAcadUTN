namespace SysAcad
{
    partial class FormProfesorModificar
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
            BtnVolver = new Button();
            label5 = new Label();
            textIdNuevo = new TextBox();
            textApellido = new TextBox();
            textID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textNombre = new TextBox();
            BtnModificar = new Button();
            label1 = new Label();
            label4 = new Label();
            textDni = new TextBox();
            label6 = new Label();
            textEspecializacion = new TextBox();
            label7 = new Label();
            textCorreo = new TextBox();
            label8 = new Label();
            textTelefono = new TextBox();
            SuspendLayout();
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(299, 350);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(75, 23);
            BtnVolver.TabIndex = 38;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 135);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 37;
            label5.Text = "ID nuevo";
            // 
            // textIdNuevo
            // 
            textIdNuevo.Location = new Point(146, 153);
            textIdNuevo.Name = "textIdNuevo";
            textIdNuevo.Size = new Size(100, 23);
            textIdNuevo.TabIndex = 36;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(274, 102);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(100, 23);
            textApellido.TabIndex = 34;
            // 
            // textID
            // 
            textID.Location = new Point(20, 153);
            textID.Name = "textID";
            textID.ReadOnly = true;
            textID.Size = new Size(100, 23);
            textID.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 84);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 31;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 135);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 30;
            label2.Text = "ID";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(146, 102);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 29;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(146, 350);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(75, 23);
            BtnModificar.TabIndex = 28;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 84);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 27;
            label1.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 135);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 39;
            label4.Text = "Dni";
            // 
            // textDni
            // 
            textDni.Location = new Point(274, 153);
            textDni.Name = "textDni";
            textDni.Size = new Size(100, 23);
            textDni.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 194);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 41;
            label6.Text = "Especializacion";
            // 
            // textEspecializacion
            // 
            textEspecializacion.Location = new Point(146, 212);
            textEspecializacion.Name = "textEspecializacion";
            textEspecializacion.Size = new Size(228, 23);
            textEspecializacion.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(146, 248);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 43;
            label7.Text = "Correo";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(146, 266);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(100, 23);
            textCorreo.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(274, 248);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 45;
            label8.Text = "Telefono";
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(274, 266);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(100, 23);
            textTelefono.TabIndex = 46;
            // 
            // FormProfesorModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 425);
            Controls.Add(textTelefono);
            Controls.Add(label8);
            Controls.Add(textCorreo);
            Controls.Add(label7);
            Controls.Add(textEspecializacion);
            Controls.Add(label6);
            Controls.Add(textDni);
            Controls.Add(label4);
            Controls.Add(BtnVolver);
            Controls.Add(label5);
            Controls.Add(textIdNuevo);
            Controls.Add(textApellido);
            Controls.Add(textID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textNombre);
            Controls.Add(BtnModificar);
            Controls.Add(label1);
            Name = "FormProfesorModificar";
            Text = "FormProfesorModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnVolver;
        private Label label5;
        public TextBox textIdNuevo;
        public TextBox textApellido;
        public TextBox textID;
        private Label label3;
        private Label label2;
        public TextBox textNombre;
        private Button BtnModificar;
        private Label label1;
        private Label label4;
        public TextBox textDni;
        private Label label6;
        public TextBox textEspecializacion;
        private Label label7;
        public TextBox textCorreo;
        private Label label8;
        public TextBox textTelefono;
    }
}