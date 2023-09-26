using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public  class Persona : Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private int _dni;

        public Persona(int id, string nombre, string apellido, string clave, string correo) : base(clave, correo)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
        }

        public Persona(int id, string nombre, string apellido, int dni, string clave, string correo) : base(clave, correo)
        {
            _id = id;
            _nombre = nombre;  
            _apellido = apellido;
            _dni = dni;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        { get { return _nombre; } set { _nombre = value; } }

        public string Apellido
        { get { return _apellido; } set { _apellido = value; } }

        public int Dni
        { get { return _dni; } set { _dni = value; } }


     }
}
