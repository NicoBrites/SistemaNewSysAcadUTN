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

        public Cursos(string nombre, int codigo, string descripcion, int cupoMaximo )
        {
            _nombre = nombre;

            _codigo = codigo;

            _descripcion = descripcion;

            _cupoMaximo = cupoMaximo;
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

    }
}
