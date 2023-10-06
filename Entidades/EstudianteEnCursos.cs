using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstudianteEnCursos
    {

        private int _id;

        private string _nombre;

        private string _apellido;

        public EstudianteEnCursos(int id, string nombre, string apellido) 
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;       
        }

        public int Id {  get { return _id; } }
        public string Nombre { get { return _nombre; } }
        public string Apellido { get { return _apellido; } }

    }
}
