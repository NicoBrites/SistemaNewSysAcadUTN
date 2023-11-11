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
            reportesBindingSource = new BindingSource(components);
            Check = new DataGridViewCheckBoxColumn();
            Informe = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            // reportesBindingSource
            // 
            reportesBindingSource.DataSource = typeof(Entidades.Reportes);
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
            // FormAdministradorReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "FormAdministradorReportes";
            Text = "FormAdministradorReportes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tipoInformeDataGridViewTextBoxColumn;
        private BindingSource reportesBindingSource;
        private DataGridViewCheckBoxColumn Check;
        private DataGridViewTextBoxColumn Informe;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
    }
}