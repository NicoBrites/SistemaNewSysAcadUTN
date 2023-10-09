
namespace Entidades
{
    public class EstudianteAValidar
    {
        private string _nombre;
        private string _apellido;
        private string _dni;
        private string _telefono;
        private string _direccion;
        private string _clave;
        private string _correo;

        public EstudianteAValidar(string nombre, string apellido,
        string dni, string telefono, string direccion, string clave, string correo) 
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _telefono = telefono;
            _direccion = direccion;
            _clave = clave;
            _correo = correo;        
        }

        public string Nombre
        { get { return _nombre; } }
        public string Apellido
        { get { return _apellido; } }
        public string Dni { get { return _dni; } }
        public string Telefono { get { return _telefono; } }
        public string Direccion { get { return _direccion; } }
        public string Clave { get { return _clave; } }
        public string Correo { get { return _correo;} } 



    }
}
