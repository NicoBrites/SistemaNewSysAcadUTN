﻿using Entidades;

namespace SysAcad
{
    partial class FormComprobanteDePago
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
            comprobanteDePago = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // comprobanteDePago
            // 
            comprobanteDePago.AutoSize = true;
            comprobanteDePago.Location = new Point(29, 19);
            comprobanteDePago.Name = "comprobanteDePago";
            comprobanteDePago.Size = new Size(38, 15);
            comprobanteDePago.TabIndex = 0;
            comprobanteDePago.Text = "label1";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(144, 323);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button1_Click;
            // 
            // FormComprobanteDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 368);
            Controls.Add(btnVolver);
            Controls.Add(comprobanteDePago);
            Name = "FormComprobanteDePago";
            Text = "Comprobante De Pago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label comprobanteDePago;
        public Estudiantes estudiante;
        private Button btnVolver;
    }
}
