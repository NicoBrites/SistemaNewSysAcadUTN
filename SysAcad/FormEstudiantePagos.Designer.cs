using Entidades;

namespace SysAcad
{
    partial class FormEstudiantePagos
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
            label1 = new Label();
            btnVolver = new Button();
            dataGridView1 = new DataGridView();
            CheckBox = new DataGridViewCheckBoxColumn();
            conceptoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            conseptoDePagoBindingSource = new BindingSource(components);
            horariosDataGridBindingSource = new BindingSource(components);
            btnPagar = new Button();
            comboBoxMetodoDePago = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conseptoDePagoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horariosDataGridBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Pagos";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(476, 376);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CheckBox, conceptoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, montoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = conseptoDePagoBindingSource;
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(469, 150);
            dataGridView1.TabIndex = 2;
            // 
            // CheckBox
            // 
            CheckBox.HeaderText = "CheckBox";
            CheckBox.Name = "CheckBox";
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            conceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto";
            conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            conceptoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conseptoDePagoBindingSource
            // 
            conseptoDePagoBindingSource.DataSource = typeof(ConseptoDePago);
            // 
            // horariosDataGridBindingSource
            // 
            horariosDataGridBindingSource.DataSource = typeof(HorariosDataGrid);
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(258, 376);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBoxMetodoDePago.FormattingEnabled = true;
            comboBoxMetodoDePago.Items.AddRange(new object[] { "Tarjeta de credito", "Tarjeta de debito", "Transferencia bancaria" });
            comboBoxMetodoDePago.Location = new Point(49, 271);
            comboBoxMetodoDePago.Name = "comboBoxMetodoDePago";
            comboBoxMetodoDePago.Size = new Size(121, 23);
            comboBoxMetodoDePago.TabIndex = 4;
            // 
            // FormEstudiantePagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxMetodoDePago);
            Controls.Add(btnPagar);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Name = "FormEstudiantePagos";
            Text = "FormEstudiantePagos";
            Load += FormEstudiantePagos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conseptoDePagoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)horariosDataGridBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVolver;
        public Estudiantes estudiante;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn CheckBox;
        private DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private BindingSource conseptoDePagoBindingSource;
        private BindingSource horariosDataGridBindingSource;
        private Button btnPagar;
        private ComboBox comboBoxMetodoDePago;
    }
}