using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace SysAcad
{
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
            GestorCursos cursos = new GestorCursos();
            try
            {
                List<Cursos> listaCursos = cursos.GetCursos();
                dataGridView1.DataSource = listaCursos;
            }
            catch { }
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCursosAgregar formCursosAgregar = new();
            formCursosAgregar.Show();
            this.Hide();
        }
    }
}
