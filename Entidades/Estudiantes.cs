using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiantes : Persona
    {
        private DateTime _fechaDeNacimiento;

        private string _usuario;

        private int _telefono;

        private string _direccion;

        private Enum _estado;

        private string _carrera;

        private string _historialAcademico;



        public Estudiantes(int id, string nombre, string apellido,
        int dni, DateTime fechaDeNacimiento, string usuario,
        int telefono, string direccion, Enum estado, string carrera,
        string historialAcademico, string clave, string correo) 
            : base(id, nombre, apellido, dni, clave, correo)
        {
            _fechaDeNacimiento = fechaDeNacimiento;
            _usuario = usuario;
            _telefono = telefono;
            _direccion = direccion;
            _estado = estado;
            _carrera = carrera;
            _historialAcademico = historialAcademico;

        }
        public DateTime FechaDeNacimiento
        {
            get { return _fechaDeNacimiento; }
            set { _fechaDeNacimiento = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
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
