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

        private string _diaSemana;

        private string _aula;

        private string _turno;


        public Cursos(string nombre, int codigo, string descripcion, int cupoMaximo, string diaSemana, string aula, string turno)
        {
            _nombre = nombre;

            _codigo = codigo;

            _descripcion = descripcion;

            _cupoMaximo = cupoMaximo;

            _diaSemana = diaSemana;

            _aula = aula;

            _turno = turno;
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

        public string DiaSemana
        {
            get { return _diaSemana; }
            set { _diaSemana = value; }
        }
        public string Aula
        {
            get { return _aula; }
            set { _aula = value; }
        }
        public string Turno
        {
            get { return _turno; }
            set { _turno = value; }
        }

    }
}
