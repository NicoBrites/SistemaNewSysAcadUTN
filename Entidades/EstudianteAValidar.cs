
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

        public EstudianteAValidar() { }
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
        { get { return _nombre; } set { _nombre = value; } }
        public string Apellido
        { get { return _apellido; } set { _apellido = value; } }
        public string Dni { get { return _dni; } set { _dni = value; } }
        public string Telefono { get { return _telefono; } set { _telefono = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public string Clave { get { return _clave; } set { _clave = value; } }
        public string Correo { get { return _correo; } set { _correo = value; } } 



    }
}
