using Entidades;

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
            btnConsultarHorario = new Button();
            btnRealizarPagos = new Button();
            btnCerrarSesion = new Button();
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
            // btnConsultarHorario
            // 
            btnConsultarHorario.Location = new Point(229, 122);
            btnConsultarHorario.Name = "btnConsultarHorario";
            btnConsultarHorario.Size = new Size(320, 46);
            btnConsultarHorario.TabIndex = 1;
            btnConsultarHorario.Text = "Consultar horarios";
            btnConsultarHorario.UseVisualStyleBackColor = true;
            btnConsultarHorario.Click += button1_Click;
            // 
            // btnRealizarPagos
            // 
            btnRealizarPagos.Location = new Point(229, 202);
            btnRealizarPagos.Name = "btnRealizarPagos";
            btnRealizarPagos.Size = new Size(320, 46);
            btnRealizarPagos.TabIndex = 2;
            btnRealizarPagos.Text = "Realizar Pagos";
            btnRealizarPagos.UseVisualStyleBackColor = true;
            btnRealizarPagos.Click += btnRealizarPagos_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(289, 398);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(221, 23);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += button1_Click_1;
            // 
            // FormMenuEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnRealizarPagos);
            Controls.Add(btnConsultarHorario);
            Controls.Add(btnInscripcionCurso);
            Name = "FormMenuEstudiante";
            Text = "Menu Estudiante";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInscripcionCurso;
        public Estudiantes estudiante;
        private Button btnConsultarHorario;
        private Button btnRealizarPagos;
        private Button btnCerrarSesion;
    }
}