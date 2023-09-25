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

        private Enum _estado;

        private string _carrera;

        private string _historialAcademico;



        public Estudiantes(int id, string nombre, string apellido,
        int dni, int telefono, string direccion, Enum estado, string carrera,
        string historialAcademico, string clave, string correo) 
            : base(id, nombre, apellido, dni, clave, correo)
        {
            _telefono = telefono;
            _direccion = direccion;
            _estado = estado;
            _carrera = carrera;
            _historialAcademico = historialAcademico;

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

        public Enum Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string Carrera
        {
            get { return _carrera; }
            set { _carrera = value; }
        }
        public string HistorialAcademico
        {
            get { return _historialAcademico; }
            set { _historialAcademico = value; }
        }

        static void PagarCuotas()
        {

        }

        static void GestionarMaterias()
        {

        }

    }
}
