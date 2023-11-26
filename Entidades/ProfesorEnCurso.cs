using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProfesorEnCurso
    {
        private int _codigoProfesor;
        private string _nombreProfesor;
        private string _apellidoProfesor;
        private int _codigoCurso;
        private string _nombreCurso;
        private string _diaSemana;
        private string _turno;
        private string _aula;

        public ProfesorEnCurso(int codigoProfesor, string nombreProfesor, string apellidoProfesor,
           int codigoCurso, string nombreCurso, string diaSemana, string turno, string aula)
        {
            _codigoProfesor = codigoProfesor;
            _nombreProfesor = nombreProfesor;
            _apellidoProfesor = apellidoProfesor;
            _codigoCurso = codigoCurso;
            _nombreCurso = nombreCurso;
            _diaSemana = diaSemana;
            _turno = turno;
            _aula = aula;
        }
        public int CodigoProfesor
        { get { return _codigoProfesor; } }
        public string NombreProfesor
        { get { return _nombreProfesor; } }
        public string ApellidoProfesor
        { get { return _apellidoProfesor; } }
        public int CodigoCurso { get { return _codigoCurso; } }
        public string NombreCurso { get { return _nombreCurso; } }
        public string DiaSemana { get { return _diaSemana; } }
        public string Turno { get { return _turno; } }
        public string Aula { get { return _aula; } }
    }
}
