namespace SysAcad
{
    partial class FormAdministradorReportes
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            Check = new DataGridViewCheckBoxColumn();
            Informe = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reportesBindingSource = new BindingSource(components);
            generarReportes = new Button();
            volver = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            comboBox4 = new ComboBox();
            btnParametros = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Check, Informe, codigoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = reportesBindingSource;
            dataGridView1.Location = new Point(116, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(557, 154);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Check
            // 
            Check.HeaderText = "Check";
            Check.Name = "Check";
            // 
            // Informe
            // 
            Informe.DataPropertyName = "Informe";
            Informe.HeaderText = "Informe";
            Informe.Name = "Informe";
            Informe.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportesBindingSource
            // 
            reportesBindingSource.DataSource = typeof(Entidades.Reportes);
            // 
            // generarReportes
            // 
            generarReportes.Location = new Point(239, 397);
            generarReportes.Name = "generarReportes";
            generarReportes.Size = new Size(134, 23);
            generarReportes.TabIndex = 1;
            generarReportes.Text = "Generar Reportes";
            generarReportes.UseVisualStyleBackColor = true;
            generarReportes.Visible = false;
            generarReportes.Click += generarReportes_Click;
            // 
            // volver
            // 
            volver.Location = new Point(419, 397);
            volver.Name = "volver";
            volver.Size = new Size(75, 23);
            volver.TabIndex = 2;
            volver.Text = "Volver";
            volver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 248);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 266);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 248);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(219, 266);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            comboBox2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 248);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(435, 266);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 8;
            comboBox3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(635, 248);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(635, 266);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 10;
            comboBox4.Visible = false;
            // 
            // btnParametros
            // 
            btnParametros.Location = new Point(239, 330);
            btnParametros.Name = "btnParametros";
            btnParametros.Size = new Size(255, 23);
            btnParametros.TabIndex = 11;
            btnParametros.Text = "Ingresar parametros";
            btnParametros.UseVisualStyleBackColor = true;
            btnParametros.Click += btnParametros_Click;
            // 
            // FormAdministradorReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnParametros);
            Controls.Add(comboBox4);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(volver);
            Controls.Add(generarReportes);
            Controls.Add(dataGridView1);
            Name = "FormAdministradorReportes";
            Text = "FormAdministradorReportes";
            Load += FormAdministradorReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tipoInformeDataGridViewTextBoxColumn;
        private BindingSource reportesBindingSource;
        private DataGridViewCheckBoxColumn Check;
        private DataGridViewTextBoxColumn Informe;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private Button generarReportes;
        private Button volver;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox3;
        private Label label4;
        private ComboBox comboBox4;
        private Button btnParametros;
    }
}