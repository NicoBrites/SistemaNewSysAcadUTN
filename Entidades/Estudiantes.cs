using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiantes : Persona
    {
        private int _telefono;

        private string _direccion;

        public Estudiantes(int id, string nombre, string apellido,
        int dni, int telefono, string direccion, string clave, string correo) 
            : base(id, nombre, apellido, dni, clave, correo)
        {
            _telefono = telefono;
            _direccion = direccion;
        }


        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        static void PagarCuotas()
        {

        }

        static void GestionarMaterias()
        {

        }

    }
}
