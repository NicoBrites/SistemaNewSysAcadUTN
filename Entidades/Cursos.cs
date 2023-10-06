using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cursos
    {
        private string _nombre;

        private int _codigo;

        private string _descripcion;

        private int _cupoMaximo;

        private int _cupoActual;
        public List<EstudianteEnCursos> _estudiantes {  get; set; }

        public Cursos(string nombre, int codigo, string descripcion, int cupoMaximo, int cupoActual = 0 )
        {
            _nombre = nombre;

            _codigo = codigo;

            _descripcion = descripcion;

            _cupoMaximo = cupoMaximo;

            _cupoActual = cupoActual;

            _estudiantes = new List<EstudianteEnCursos>();
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int CupoMaximo
        {
            get { return _cupoMaximo; }
            set { _cupoMaximo = value;}
        }

        public int CupoActual { get { return _cupoActual; } set { _cupoActual = value;} }



    }
}
