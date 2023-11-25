
namespace Entidades
{
    public class Profesores : Persona
    {
        private string _especializacion;
        private int _telefono;
 

        public Profesores(int id, string nombre, string apellido, int dni, string especializacion, string clave, string correo, int telefono)
            : base(id, nombre, apellido, dni, clave, correo) 
        {
            _especializacion = especializacion;
            _telefono = telefono;
            
        }
        public string Especializacion
        { get { return _especializacion; } set { _especializacion = value; } }

        public int Telefono
        { get { return _telefono; } set { _telefono = value; } }

    
    }
}
