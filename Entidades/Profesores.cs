﻿
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

    }
}
