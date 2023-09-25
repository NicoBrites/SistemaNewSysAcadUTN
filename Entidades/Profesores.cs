using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesores : Persona
    {
        private string _materia;

        public Profesores(int id, string nombre, string apellido, int dni, string materia, string clave, string correo)
            : base(id, nombre, apellido, dni, clave, correo) 
        {
            _materia = materia;
            
        }

        public string Materia
        { get { return _materia; } set { _materia = value; } }
        static void DarClase() 
        { 

        }

        static void TomarExamen() { }
       
        static void TomarAsistencia() { }

        static void CargarNotas() { }
    }
}
