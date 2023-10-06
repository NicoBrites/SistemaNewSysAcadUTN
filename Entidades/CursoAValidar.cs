using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CursoAValidar
    {
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cupoMaximo;

        public CursoAValidar(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;
            _cupoMaximo = cupoMaximo;
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public string Codigo
        {
            get { return _codigo; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
        }
        public string CupoMaximo
        {
            get { return _cupoMaximo; }
        }
    }
}
