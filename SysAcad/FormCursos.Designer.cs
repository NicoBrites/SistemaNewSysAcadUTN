namespace SysAcad
{
    partial class FormCursos
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
            btnAgregarCursos = new Button();
            btnModificarCursos = new Button();
            btnEliminarCursos = new Button();
            dataGridView1 = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DiaSemana = new DataGridViewTextBoxColumn();
            Aula = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            cursosBindingSource4 = new BindingSource(components);
            cursosBindingSource3 = new BindingSource(components);
            cursosBindingSource2 = new BindingSource(components);
            cursosBindingSource = new BindingSource(components);
            btnVolver = new Button();
            cursosBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarCursos
            // 
            btnAgregarCursos.Location = new Point(166, 560);
            btnAgregarCursos.Name = "btnAgregarCursos";
            btnAgregarCursos.Size = new Size(179, 23);
            btnAgregarCursos.TabIndex = 0;
            btnAgregarCursos.Text = "Agregar Cursos";
            btnAgregarCursos.UseVisualStyleBackColor = true;
            btnAgregarCursos.Click += button1_Click;
            // 
            // btnModificarCursos
            // 
            btnModificarCursos.Location = new Point(485, 560);
            btnModificarCursos.Name = "btnModificarCursos";
            btnModificarCursos.Size = new Size(174, 23);
            btnModificarCursos.TabIndex = 1;
            btnModificarCursos.Text = "Modificar Cursos";
            btnModificarCursos.UseVisualStyleBackColor = true;
            btnModificarCursos.Click += btnModificarCursos_Click;
            // 
            // btnEliminarCursos
            // 
            btnEliminarCursos.Location = new Point(781, 560);
            btnEliminarCursos.Name = "btnEliminarCursos";
            btnEliminarCursos.Size = new Size(190, 23);
            btnEliminarCursos.TabIndex = 2;
            btnEliminarCursos.Text = "Eliminar Cursos";
            btnEliminarCursos.UseVisualStyleBackColor = true;
            btnEliminarCursos.Click += btnEliminarCursos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, DiaSemana, Aula, Turno });
            dataGridView1.DataSource = cursosBindingSource4;
            dataGridView1.Location = new Point(166, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(645, 377);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // cursosBindingSource4
            // 
            cursosBindingSource4.DataSource = typeof(Entidades.Cursos);
            // 
            // cursosBindingSource3
            // 
            cursosBindingSource3.DataSource = typeof(Entidades.Cursos);
            // 
            // cursosBindingSource2
            // 
            cursosBindingSource2.DataSource = typeof(Entidades.Cursos);
            // 
            // cursosBindingSource
            // 
            cursosBindingSource.DataSource = typeof(Entidades.Cursos);
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(538, 607);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // cursosBindingSource1
            // 
            cursosBindingSource1.DataSource = typeof(Entidades.Cursos);
            // 
            // FormCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 656);
            Controls.Add(btnVolver);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminarCursos);
            Controls.Add(btnModificarCursos);
            Controls.Add(btnAgregarCursos);
            Name = "FormCursos";
            Text = "Cursos";
            Load += FormCursos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarCursos;
        private Button btnModificarCursos;
        private Button btnEliminarCursos;
        private DataGridView dataGridView1;
        private BindingSource cursosBindingSource;
        private Button btnVolver;
        private BindingSource cursosBindingSource1;
        private BindingSource cursosBindingSource2;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DiaSemana;
        private DataGridViewTextBoxColumn Aula;
        private DataGridViewTextBoxColumn Turno;
        private BindingSource cursosBindingSource3;
        private BindingSource cursosBindingSource4;
    }
}