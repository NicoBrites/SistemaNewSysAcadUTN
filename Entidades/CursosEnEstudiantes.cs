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
        private string _diaSemana;
        private string _turno;
        private string _aula;

        public CursosEnEstudiantes(string nombre, int codigo, string diaSemana, string turno, string aula)
        {
            _nombre = nombre;
            _codigo = codigo;
            _diaSemana = diaSemana;
            _turno = turno;
            _aula = aula;
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
        public string DiaSemana { get { return _diaSemana; } }
        public string Turno { get { return _turno; } }
        public string Aula { get { return _aula;} }
    }
}
