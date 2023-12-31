﻿
namespace Entidades
{
    public class Estudiantes: Persona
    {
        private int _telefono;

        private string _direccion;

        private DateTime _fecha;

        public Estudiantes(int id, string nombre, string apellido,
        int dni, int telefono, string direccion, string clave, string correo, DateTime fecha) 
            : base(id, nombre, apellido, dni, clave, correo)
        {
            _telefono = telefono;
            _direccion = direccion;
            _fecha = fecha;
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

        public DateTime Fecha 
        {
            get { return _fecha; }
            set { _fecha = value; }
        }    
    }
}
