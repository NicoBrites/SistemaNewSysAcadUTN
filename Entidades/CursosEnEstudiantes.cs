using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CursosEnEstudiantes
    {
        private string _nombre;
        private int _codigo;



        public CursosEnEstudiantes(string nombre, int codigo)
        {
            _nombre = nombre;
            _codigo = codigo;
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
    }
}
