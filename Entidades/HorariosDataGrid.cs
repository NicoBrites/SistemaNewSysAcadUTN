
namespace Entidades
{
    public class HorariosDataGrid
    {
        private string _diaSemana;
        private string _nombre;
        private string _aula;
        private string _turno;

        public HorariosDataGrid(string turno, string nombre, string diaSemana, string aula)
        {
            _turno = turno;
            _nombre = nombre;
            _diaSemana = diaSemana;
            _aula = aula;
        }
        public string Turno { get { return _turno; } }
        public string Nombre { get {  return _nombre; } }   
        public string DiaSemana { get {  return _diaSemana; } }
        public string Aula { get { return _aula;} }
    }
}
