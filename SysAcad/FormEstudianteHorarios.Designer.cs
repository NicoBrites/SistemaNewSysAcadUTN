using Entidades;

namespace SysAcad
{
    partial class FormEstudianteHorarios
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
            horariosDataGridBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaSemanaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horariosDataGridBindingSource1 = new BindingSource(components);
            cursosBindingSource = new BindingSource(components);
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)horariosDataGridBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horariosDataGridBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 23);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Horarios";
            // 
            // horariosDataGridBindingSource
            // 
            horariosDataGridBindingSource.DataSource = typeof(HorariosDataGrid);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, diaSemanaDataGridViewTextBoxColumn, aulaDataGridViewTextBoxColumn, turnoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = horariosDataGridBindingSource1;
            dataGridView1.Location = new Point(84, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(446, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaSemanaDataGridViewTextBoxColumn
            // 
            diaSemanaDataGridViewTextBoxColumn.DataPropertyName = "DiaSemana";
            diaSemanaDataGridViewTextBoxColumn.HeaderText = "DiaSemana";
            diaSemanaDataGridViewTextBoxColumn.Name = "diaSemanaDataGridViewTextBoxColumn";
            diaSemanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aulaDataGridViewTextBoxColumn
            // 
            aulaDataGridViewTextBoxColumn.DataPropertyName = "Aula";
            aulaDataGridViewTextBoxColumn.HeaderText = "Aula";
            aulaDataGridViewTextBoxColumn.Name = "aulaDataGridViewTextBoxColumn";
            aulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            turnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horariosDataGridBindingSource1
            // 
            horariosDataGridBindingSource1.DataSource = typeof(HorariosDataGrid);
            // 
            // cursosBindingSource
            // 
            cursosBindingSource.DataSource = typeof(Cursos);
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(262, 233);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button1_Click;
            // 
            // FormEstudianteHorarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 291);
            Controls.Add(btnVolver);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FormEstudianteHorarios";
            Text = "Horarios";
            Load += FormEstudianteHorarios_Load;
            ((System.ComponentModel.ISupportInitialize)horariosDataGridBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)horariosDataGridBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        public Estudiantes estudiante;
        private BindingSource horariosDataGridBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaSemanaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private BindingSource horariosDataGridBindingSource1;
        private BindingSource cursosBindingSource;
        private Button btnVolver;
    }
}