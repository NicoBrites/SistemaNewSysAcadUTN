﻿using System.ComponentModel;

namespace SysAcad
{
    public partial class FormMenuAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            button1 = new Button();
            btnGestorInformes = new Button();
            btnListaEspera = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnRegistrarEstudiante
            // 
            btnRegistrarEstudiante.Location = new Point(235, 33);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new Size(363, 49);
            btnRegistrarEstudiante.TabIndex = 0;
            btnRegistrarEstudiante.Text = "Registrar estudiante";
            btnRegistrarEstudiante.UseVisualStyleBackColor = true;
            btnRegistrarEstudiante.Click += button1_Click;
            // 
            // btnGestionarCursos
            // 
            btnGestionarCursos.Location = new Point(235, 88);
            btnGestionarCursos.Name = "btnGestionarCursos";
            btnGestionarCursos.Size = new Size(363, 50);
            btnGestionarCursos.TabIndex = 1;
            btnGestionarCursos.Text = "Gestionar cursos";
            btnGestionarCursos.UseVisualStyleBackColor = true;
            btnGestionarCursos.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(308, 415);
            button1.Name = "button1";
            button1.Size = new Size(206, 23);
            button1.TabIndex = 2;
            button1.Text = "Cerrar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // btnGestorInformes
            // 
            btnGestorInformes.Location = new Point(235, 144);
            btnGestorInformes.Name = "btnGestorInformes";
            btnGestorInformes.Size = new Size(363, 49);
            btnGestorInformes.TabIndex = 3;
            btnGestorInformes.Text = "Generar Reportes";
            btnGestorInformes.UseVisualStyleBackColor = true;
            btnGestorInformes.Click += button2_Click;
            // 
            // btnListaEspera
            // 
            btnListaEspera.Location = new Point(235, 199);
            btnListaEspera.Name = "btnListaEspera";
            btnListaEspera.Size = new Size(363, 49);
            btnListaEspera.TabIndex = 4;
            btnListaEspera.Text = "Manejar Lista de Espera";
            btnListaEspera.UseVisualStyleBackColor = true;
            btnListaEspera.Click += btnListaEspera_Click;
            // 
            // button2
            // 
            button2.Location = new Point(235, 254);
            button2.Name = "button2";
            button2.Size = new Size(363, 49);
            button2.TabIndex = 5;
            button2.Text = "Gestionar Requisitos Academicos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(235, 309);
            button3.Name = "button3";
            button3.Size = new Size(363, 49);
            button3.TabIndex = 6;
            button3.Text = "Gestionar Profesores";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormMenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnListaEspera);
            Controls.Add(btnGestorInformes);
            Controls.Add(button1);
            Controls.Add(btnGestionarCursos);
            Controls.Add(btnRegistrarEstudiante);
            Name = "FormMenuAdministrador";
            Text = "Menu Administrador";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarEstudiante;
        private Button btnGestionarCursos;
        private Button button1;
        private Button btnGestorInformes;
        private Button btnListaEspera;
        private Button button2;
        private Button button3;
    }
}