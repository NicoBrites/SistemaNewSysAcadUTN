
namespace Entidades
{
    public class Administrador : Persona
    {
        private int _nivel;

        public Administrador(int id, string nombre, string apellido, int nivel, string clave, string correo) 
            : base(id, nombre, apellido, clave, correo)
        {
            _nivel = nivel;
        }

        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

    }
}
