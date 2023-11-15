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
            estudianteEnCursosBindingSource = new BindingSource(components);
            estudiantesBindingSource = new BindingSource(components);
            horariosDataGridBindingSource = new BindingSource(components);
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            Check = new DataGridViewCheckBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupoMaximoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DiaSemana = new DataGridViewTextBoxColumn();
            Aula = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            btnMostrarListaEspera = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnEliminar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudianteEnCursosBindingSource).BeginInit();
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
            dataGridView2.DataSource = estudianteEnCursosBindingSource;
            dataGridView2.Location = new Point(466, 183);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(430, 276);
            dataGridView2.TabIndex = 1;
            dataGridView2.Visible = false;
            // 
            // Check2
            // 
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
            Apellido.ReadOnly = true;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // estudianteEnCursosBindingSource
            // 
            estudianteEnCursosBindingSource.DataSource = typeof(Entidades.EstudianteEnCursos);
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
            btnAgregar.Location = new Point(70, 298);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Check, nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cupoMaximoDataGridViewTextBoxColumn, DiaSemana, Aula, Turno });
            dataGridView1.DataSource = cursosBindingSource;
            dataGridView1.Location = new Point(45, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(851, 150);
            dataGridView1.TabIndex = 3;
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
            // cupoMaximoDataGridViewTextBoxColumn
            // 
            cupoMaximoDataGridViewTextBoxColumn.DataPropertyName = "CupoMaximo";
            cupoMaximoDataGridViewTextBoxColumn.HeaderText = "CupoMaximo";
            cupoMaximoDataGridViewTextBoxColumn.Name = "cupoMaximoDataGridViewTextBoxColumn";
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
            // btnMostrarListaEspera
            // 
            btnMostrarListaEspera.Location = new Point(70, 216);
            btnMostrarListaEspera.Name = "btnMostrarListaEspera";
            btnMostrarListaEspera.Size = new Size(184, 23);
            btnMostrarListaEspera.TabIndex = 4;
            btnMostrarListaEspera.Text = "Mostrar la Lista de Espera";
            btnMostrarListaEspera.UseVisualStyleBackColor = true;
            btnMostrarListaEspera.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 324);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "ID Estudiante:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 342);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 6;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(276, 258);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(184, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar Estudiante";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button1_Click_2;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(295, 436);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button1_Click_3;
            // 
            // FormAdministradorListaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 489);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnMostrarListaEspera);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView2);
            Name = "FormAdministradorListaEspera";
            Text = "FormAdministradorListaEspera";
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudianteEnCursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudiantesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)horariosDataGridBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource cursosBindingSource;
        private DataGridView dataGridView2;
        private BindingSource estudiantesBindingSource;
        private BindingSource horariosDataGridBindingSource;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn Check2;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Id;
        private Button btnMostrarListaEspera;
        private BindingSource estudianteEnCursosBindingSource;
        private Label label1;
        private TextBox textBox1;
        private DataGridViewCheckBoxColumn Check;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DiaSemana;
        private DataGridViewTextBoxColumn Aula;
        private DataGridViewTextBoxColumn Turno;
        private Button btnEliminar;
        private Button btnVolver;
    }
}