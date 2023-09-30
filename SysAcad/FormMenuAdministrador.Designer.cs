namespace SysAcad
{
    partial class FormMenuAdministrador
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
            btnRegistrarEstudiante = new Button();
            btnGestionarCursos = new Button();
            SuspendLayout();
            // 
            // btnRegistrarEstudiante
            // 
            btnRegistrarEstudiante.Location = new Point(235, 59);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new Size(363, 49);
            btnRegistrarEstudiante.TabIndex = 0;
            btnRegistrarEstudiante.Text = "Registrar estudiante";
            btnRegistrarEstudiante.UseVisualStyleBackColor = true;
            btnRegistrarEstudiante.Click += button1_Click;
            // 
            // button1
            // 
            btnGestionarCursos.Location = new Point(235, 141);
            btnGestionarCursos.Name = "btnGestionarCursos";
            btnGestionarCursos.Size = new Size(363, 50);
            btnGestionarCursos.TabIndex = 1;
            btnGestionarCursos.Text = "Gestionar cursos";
            btnGestionarCursos.UseVisualStyleBackColor = true;
            btnGestionarCursos.Click += button1_Click_1;
            // 
            // FormMenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGestionarCursos);
            Controls.Add(btnRegistrarEstudiante);
            Name = "FormMenuAdministrador";
            Text = "FormMenuAdministrador";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarEstudiante;
        private Button btnGestionarCursos;
    }
}