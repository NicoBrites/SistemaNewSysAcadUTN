using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProfesorAValidar
    {
        private string _nombre;
        private string _apellido;
        private string _dni;
        private string _telefono;
        private string _especializacion;
        private string _clave;
        private string _correo;

        public ProfesorAValidar(string nombre, string apellido,
        string dni, string telefono, string especializacion, string clave, string correo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _telefono = telefono;
            _especializacion = especializacion;
            _clave = clave;
            _correo = correo;
        }

        public string Nombre
        { get { return _nombre; } }
        public string Apellido
        { get { return _apellido; } }
        public string Dni { get { return _dni; } }
        public string Telefono { get { return _telefono; } }
        public string Especializacion { get { return _especializacion; } }
        public string Clave { get { return _clave; } }
        public string Correo { get { return _correo; } }

    }
}
