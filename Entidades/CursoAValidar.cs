
namespace Entidades
{
    public class CursoAValidar
    {
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cupoMaximo;
        private string _diaSemana;
        private string _aula;
        private string _turno;

        public CursoAValidar(string nombre, string codigo, string descripcion, string cupoMaximo, string diaSemana, string aula, string turno)
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
        public string DiaSemana
        { 
            get { return _diaSemana; }
        }
        public string Aula
        { 
            get { return _aula; }
        }   
        public string Turno
        { 
            get { return _turno; }
        }
    }
}
