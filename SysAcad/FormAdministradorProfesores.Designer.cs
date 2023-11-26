namespace SysAcad
{
    partial class FormAdministradorProfesores
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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Especializacion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profesoresBindingSource = new BindingSource(components);
            reportesBindingSource = new BindingSource(components);
            BtnAgregar = new Button();
            button1 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            nombreDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaSemanaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursosBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profesoresBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, Especializacion, Telefono, dniDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = profesoresBindingSource;
            dataGridView1.Location = new Point(23, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(852, 218);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // Especializacion
            // 
            Especializacion.DataPropertyName = "Especializacion";
            Especializacion.HeaderText = "Especializacion";
            Especializacion.Name = "Especializacion";
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // profesoresBindingSource
            // 
            profesoresBindingSource.DataSource = typeof(Entidades.Profesores);
            // 
            // reportesBindingSource
            // 
            reportesBindingSource.DataSource = typeof(Entidades.Reportes);
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(23, 271);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(255, 23);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar Profesor";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(23, 300);
            button1.Name = "button1";
            button1.Size = new Size(255, 23);
            button1.TabIndex = 2;
            button1.Text = "Modificar Profesor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(23, 329);
            button2.Name = "button2";
            button2.Size = new Size(255, 23);
            button2.TabIndex = 3;
            button2.Text = "Eliminar Profesor";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn1, codigoDataGridViewTextBoxColumn, diaSemanaDataGridViewTextBoxColumn, aulaDataGridViewTextBoxColumn, turnoDataGridViewTextBoxColumn });
            dataGridView2.DataSource = cursosBindingSource;
            dataGridView2.Location = new Point(314, 271);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(561, 264);
            dataGridView2.TabIndex = 4;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
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
            // cursosBindingSource
            // 
            cursosBindingSource.DataSource = typeof(Entidades.Cursos);
            // 
            // FormAdministradorProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 600);
            Controls.Add(dataGridView2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnAgregar);
            Controls.Add(dataGridView1);
            Name = "FormAdministradorProfesores";
            Text = "FormAdministradorProfesores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profesoresBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private BindingSource profesoresBindingSource;
        private BindingSource reportesBindingSource;
        private Button BtnAgregar;
        private Button button1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Especializacion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private Button button2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaSemanaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private BindingSource cursosBindingSource;
    }
}