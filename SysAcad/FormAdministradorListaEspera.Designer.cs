namespace SysAcad
{
    partial class FormAdministradorListaEspera
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
            cursosBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            Check2 = new DataGridViewCheckBoxColumn();
            nombreDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            estudiantesBindingSource = new BindingSource(components);
            horariosDataGridBindingSource = new BindingSource(components);
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupoMaximoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaSemanaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horariosDataGridBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cursosBindingSource
            // 
            cursosBindingSource.DataSource = typeof(Entidades.Cursos);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Check2, nombreDataGridViewTextBoxColumn1, Apellido, Id });
            dataGridView2.DataSource = estudiantesBindingSource;
            dataGridView2.Location = new Point(366, 183);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(430, 276);
            dataGridView2.TabIndex = 1;
            // 
            // Check2
            // 
            Check2.DataPropertyName = "Telefono";
            Check2.HeaderText = "Check";
            Check2.Name = "Check2";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // estudiantesBindingSource
            // 
            estudiantesBindingSource.DataSource = typeof(Entidades.Estudiantes);
            // 
            // horariosDataGridBindingSource
            // 
            horariosDataGridBindingSource.DataSource = typeof(Entidades.HorariosDataGrid);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(63, 202);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(184, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar Estudiante";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cupoMaximoDataGridViewTextBoxColumn, diaSemanaDataGridViewTextBoxColumn, aulaDataGridViewTextBoxColumn, turnoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cursosBindingSource;
            dataGridView1.Location = new Point(45, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(751, 150);
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
            // cupoMaximoDataGridViewTextBoxColumn
            // 
            cupoMaximoDataGridViewTextBoxColumn.DataPropertyName = "CupoMaximo";
            cupoMaximoDataGridViewTextBoxColumn.HeaderText = "CupoMaximo";
            cupoMaximoDataGridViewTextBoxColumn.Name = "cupoMaximoDataGridViewTextBoxColumn";
            // 
            // diaSemanaDataGridViewTextBoxColumn
            // 
            diaSemanaDataGridViewTextBoxColumn.DataPropertyName = "DiaSemana";
            diaSemanaDataGridViewTextBoxColumn.HeaderText = "DiaSemana";
            diaSemanaDataGridViewTextBoxColumn.Name = "diaSemanaDataGridViewTextBoxColumn";
            // 
            // aulaDataGridViewTextBoxColumn
            // 
            aulaDataGridViewTextBoxColumn.DataPropertyName = "Aula";
            aulaDataGridViewTextBoxColumn.HeaderText = "Aula";
            aulaDataGridViewTextBoxColumn.Name = "aulaDataGridViewTextBoxColumn";
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            // 
            // FormAdministradorListaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 631);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView2);
            Name = "FormAdministradorListaEspera";
            Text = "FormAdministradorListaEspera";
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)horariosDataGridBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource cursosBindingSource;
        private DataGridView dataGridView2;
        private BindingSource estudiantesBindingSource;
        private BindingSource horariosDataGridBindingSource;
        private DataGridViewCheckBoxColumn Check2;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Id;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaSemanaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
    }
}