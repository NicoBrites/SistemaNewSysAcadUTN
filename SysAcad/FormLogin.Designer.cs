﻿namespace SysAcad
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnInicioSesion = new Button();
            label2 = new Label();
            label3 = new Label();
            textCorreo = new TextBox();
            textContraseña = new TextBox();
            SuspendLayout();
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.BackColor = SystemColors.ControlDarkDark;
            btnInicioSesion.FlatStyle = FlatStyle.Flat;
            btnInicioSesion.Location = new Point(223, 307);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(355, 106);
            btnInicioSesion.TabIndex = 0;
            btnInicioSesion.Text = "Iniciar Sesion";
            btnInicioSesion.UseVisualStyleBackColor = false;
            btnInicioSesion.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(223, 139);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(223, 216);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // textCorreo
            // 
            textCorreo.BackColor = SystemColors.WindowFrame;
            textCorreo.Location = new Point(223, 168);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(100, 23);
            textCorreo.TabIndex = 4;
            // 
            // textContraseña
            // 
            textContraseña.BackColor = SystemColors.WindowFrame;
            textContraseña.Location = new Point(223, 252);
            textContraseña.Name = "textContraseña";
            textContraseña.PasswordChar = '*';
            textContraseña.Size = new Size(100, 23);
            textContraseña.TabIndex = 5;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 600);
            Controls.Add(textContraseña);
            Controls.Add(textCorreo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnInicioSesion);
            Name = "FormLogin";
            Text = "Sys Acad Godeto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicioSesion;
        private Label label2;
        private Label label3;
        private TextBox textCorreo;
        private TextBox textContraseña;
    }
}