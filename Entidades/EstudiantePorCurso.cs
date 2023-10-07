using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstudiantePorCurso
    {
        private int _codigoEstudiante;
        private string _nombreEstudiante;
        private string _ApellidoEstudiante;
        private int _codigoCurso;
        private string _nombreCurso;
        private Enum _diaSemana;
        private Enum _turno;

        public EstudiantePorCurso(int codigoEstudiante, string nombreEstudiante, string apellidoEstudiante,
            int codigoCurso, string nombreCurso, Enum diaSemana, Enum turno)
        {
            _codigoEstudiante = codigoEstudiante;
            _nombreEstudiante = nombreEstudiante;
            _ApellidoEstudiante = apellidoEstudiante;
            _codigoCurso = codigoCurso;
            _nombreCurso = nombreCurso;
            _diaSemana = diaSemana;
            _turno = turno;
        }
        public int CodigoEstudiante
        {  get { return _codigoEstudiante;} }
        public string NombreEstudiante
        { get { return _nombreEstudiante;} }
        public string ApellidoEstudiante
        { get { return _ApellidoEstudiante;} }
        public int CodigoCurso { get {  return _codigoCurso;} }
        public string NombreCurso {  get { return _nombreCurso;} }
        public Enum DiaSemana { get {  return _diaSemana;} }
        public Enum Turno { get { return _turno;} } 

    }
}
