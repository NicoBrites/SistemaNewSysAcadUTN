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

        private Enum _diaSemana;

        private Enum _aula;

        private Enum _turno;


        public Cursos(string nombre, int codigo, string descripcion, int cupoMaximo, Enum diaSemana, Enum aula, Enum turno)
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

        public Enum DiaSemana
        {
            get { return _diaSemana; }
            set { _diaSemana = value; }
        }
        public Enum Aula
        {
            get { return _aula; }
            set { _aula = value; }
        }
        public Enum Turno
        {
            get { return _turno; }
            set { _turno = value; }
        }

    }
}
