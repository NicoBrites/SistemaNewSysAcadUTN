namespace SysAcad
{
    partial class FormAdministradorRequisitos
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
            Check1 = new DataGridViewCheckBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupoMaximoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaSemanaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursosBindingSource = new BindingSource(components);
            requisitosCursoBindingSource = new BindingSource(components);
            requisitosCursoBindingSource1 = new BindingSource(components);
            BtnMostrarRequisitos = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnModificarRequisitos = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requisitosCursoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requisitosCursoBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Check1, nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cupoMaximoDataGridViewTextBoxColumn, diaSemanaDataGridViewTextBoxColumn, aulaDataGridViewTextBoxColumn, turnoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cursosBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(847, 239);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Check1
            // 
            Check1.HeaderText = "Check";
            Check1.Name = "Check1";
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
            // cursosBindingSource
            // 
            cursosBindingSource.DataSource = typeof(Entidades.Cursos);
            // 
            // requisitosCursoBindingSource
            // 
            requisitosCursoBindingSource.DataSource = typeof(Entidades.RequisitosCurso);
            // 
            // requisitosCursoBindingSource1
            // 
            requisitosCursoBindingSource1.DataSource = typeof(Entidades.RequisitosCurso);
            // 
            // BtnMostrarRequisitos
            // 
            BtnMostrarRequisitos.Location = new Point(12, 280);
            BtnMostrarRequisitos.Name = "BtnMostrarRequisitos";
            BtnMostrarRequisitos.Size = new Size(200, 23);
            BtnMostrarRequisitos.TabIndex = 1;
            BtnMostrarRequisitos.Text = "Mostrar Requisitos";
            BtnMostrarRequisitos.UseVisualStyleBackColor = true;
            BtnMostrarRequisitos.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 284);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 2;
            label1.Text = "Cursos PreRequisito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 323);
            label2.Name = "label2";
            label2.Size = new Size(170, 15);
            label2.TabIndex = 3;
            label2.Text = "Nivel de Creditos Acumulados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 363);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 4;
            label3.Text = "Promedio Academico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 284);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 323);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 6;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(544, 363);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 7;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // BtnModificarRequisitos
            // 
            BtnModificarRequisitos.Location = new Point(12, 323);
            BtnModificarRequisitos.Name = "BtnModificarRequisitos";
            BtnModificarRequisitos.Size = new Size(200, 23);
            BtnModificarRequisitos.TabIndex = 8;
            BtnModificarRequisitos.Text = "Modificar Requisitos";
            BtnModificarRequisitos.UseVisualStyleBackColor = true;
            BtnModificarRequisitos.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 363);
            button1.Name = "button1";
            button1.Size = new Size(221, 45);
            button1.TabIndex = 9;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // FormAdministradorRequisitos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 434);
            Controls.Add(button1);
            Controls.Add(BtnModificarRequisitos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnMostrarRequisitos);
            Controls.Add(dataGridView1);
            Name = "FormAdministradorRequisitos";
            Text = "FormAdministradorRequisitos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)requisitosCursoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)requisitosCursoBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn Check1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaSemanaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private BindingSource cursosBindingSource;
        private BindingSource requisitosCursoBindingSource;
        private BindingSource requisitosCursoBindingSource1;
        private Button BtnMostrarRequisitos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BtnModificarRequisitos;
        private Button button1;
    }
}