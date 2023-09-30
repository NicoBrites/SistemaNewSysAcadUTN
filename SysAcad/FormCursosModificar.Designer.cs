namespace SysAcad
{
    partial class FormCursosModificar : Form
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
        public void InitializeComponent()
        {
            textCupoMaximo = new TextBox();
            textDescripcion = new TextBox();
            textCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textNombre = new TextBox();
            BtnAgregar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textCupoMaximo
            // 
            textCupoMaximo.Location = new Point(241, 394);
            textCupoMaximo.Name = "textCupoMaximo";
            textCupoMaximo.Size = new Size(100, 23);
            textCupoMaximo.TabIndex = 17;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(241, 302);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 23);
            textDescripcion.TabIndex = 16;
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(241, 208);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(100, 23);
            textCodigo.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 353);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 14;
            label4.Text = "Cupo maximo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 284);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 13;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 165);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 12;
            label2.Text = "Codigo";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(241, 104);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 11;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(266, 532);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 10;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 63);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // FormCursosModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 636);
            Controls.Add(textCupoMaximo);
            Controls.Add(textDescripcion);
            Controls.Add(textCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textNombre);
            Controls.Add(BtnAgregar);
            Controls.Add(label1);
            Name = "FormCursosModificar";
            Text = "FormCursosModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textCupoMaximo;
        public TextBox textDescripcion;
        public TextBox textCodigo;
        private Label label4;
        private Label label3;
        private Label label2;
        public TextBox textNombre;
        private Button BtnAgregar;
        private Label label1;
    }
}