using Entidades;

namespace SysAcad
{
    partial class FormEstudianteCursos
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
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DiaSemana = new DataGridViewTextBoxColumn();
            Aula = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            cursosBindingSource3 = new BindingSource(components);
            cursosBindingSource2 = new BindingSource(components);
            cursosBindingSource = new BindingSource(components);
            btnInscribirse = new Button();
            cursosBindingSource1 = new BindingSource(components);
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Check, nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, DiaSemana, Aula, Turno });
            dataGridView1.DataSource = cursosBindingSource3;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(744, 247);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Check
            // 
            Check.HeaderText = "Check";
            Check.Name = "Check";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // DiaSemana
            // 
            DiaSemana.DataPropertyName = "DiaSemana";
            DiaSemana.HeaderText = "DiaSemana";
            DiaSemana.Name = "DiaSemana";
            // 
            // Aula
            // 
            Aula.DataPropertyName = "Aula";
            Aula.HeaderText = "Aula";
            Aula.Name = "Aula";
            // 
            // Turno
            // 
            Turno.DataPropertyName = "Turno";
            Turno.HeaderText = "Turno";
            Turno.Name = "Turno";
            // 
            // cursosBindingSource3
            // 
            cursosBindingSource3.DataSource = typeof(Cursos);
            // 
            // cursosBindingSource2
            // 
            cursosBindingSource2.DataSource = typeof(Cursos);
            // 
            // cursosBindingSource
            // 
            cursosBindingSource.DataSource = typeof(Cursos);
            // 
            // btnInscribirse
            // 
            btnInscribirse.Location = new Point(188, 381);
            btnInscribirse.Name = "btnInscribirse";
            btnInscribirse.Size = new Size(75, 23);
            btnInscribirse.TabIndex = 1;
            btnInscribirse.Text = "Inscribirse";
            btnInscribirse.UseVisualStyleBackColor = true;
            btnInscribirse.Click += button1_Click;
            // 
            // cursosBindingSource1
            // 
            cursosBindingSource1.DataSource = typeof(Cursos);
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(454, 381);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormEstudianteCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnInscribirse);
            Controls.Add(dataGridView1);
            Name = "FormEstudianteCursos";
            Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource cursosBindingSource;
        private Button btnInscribirse;
        private BindingSource cursosBindingSource1;
        private BindingSource cursosBindingSource2;
        public Estudiantes estudiante;
        private DataGridViewCheckBoxColumn Check;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DiaSemana;
        private DataGridViewTextBoxColumn Aula;
        private DataGridViewTextBoxColumn Turno;
        private BindingSource cursosBindingSource3;
        private Button btnVolver;
    }
}