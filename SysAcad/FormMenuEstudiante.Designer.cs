namespace SysAcad
{
    partial class FormMenuEstudiante
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
            btnInscripcionCurso = new Button();
            SuspendLayout();
            // 
            // btnInscripcionCurso
            // 
            btnInscripcionCurso.Location = new Point(229, 32);
            btnInscripcionCurso.Name = "btnInscripcionCurso";
            btnInscripcionCurso.Size = new Size(320, 46);
            btnInscripcionCurso.TabIndex = 0;
            btnInscripcionCurso.Text = "Inscripcion a Cursos";
            btnInscripcionCurso.UseVisualStyleBackColor = true;
            btnInscripcionCurso.Click += btnInscripcionCurso_Click;
            // 
            // FormMenuEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInscripcionCurso);
            Name = "FormMenuEstudiante";
            Text = "FormMenuEstudiante";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInscripcionCurso;
    }
}