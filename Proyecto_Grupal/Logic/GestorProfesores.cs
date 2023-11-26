﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic
{
    public class GestorProfesores
    {
        private ValidadorTextosVacios _validadorTextosVacios;
        private DB.DB _gestorDB;

        public GestorProfesores()
        {
            _validadorTextosVacios = new ValidadorTextosVacios();
            _gestorDB = new DB.DB();
        }

        public List<Profesores> GetListaProfesores()
        {
            JsonUsuariosFormato json = _gestorDB.ReturnAllUsers();

            List<Profesores> profesores = json.Profesores;

            return profesores;
        }
        public bool ValidadorProfesores(ProfesorAValidar profesores)
        {
            int numero;

            if (int.TryParse(profesores.Telefono, out numero) && int.TryParse(profesores.Dni, out numero))
            {
                if (_validadorTextosVacios.ValidarTextosVacios(profesores.Nombre) &&
               _validadorTextosVacios.ValidarTextosVacios(profesores.Apellido) &&
               _validadorTextosVacios.ValidarTextosVacios(profesores.Especializacion) &&
               _validadorTextosVacios.ValidarTextosVacios(profesores.Clave))
                {
                    if (ValidarEmail(profesores.Correo))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool ValidarEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }

        public void CrearProfesorNewDB(Profesores nuevProfesor)
        {
            int ultimoId = 0;

            JsonUsuariosFormato json = _gestorDB.ReturnAllUsers();

            List<Profesores> profesores = json.Profesores;

            foreach (Profesores profesor in profesores)
            {
                if (nuevProfesor.Correo == profesor.Correo || nuevProfesor.Dni == profesor.Dni)
                {
                    throw new Exception("El correo electronico o DNI ya esta en uso");
                }
                if (profesor.Id > ultimoId)
                {
                    ultimoId = profesor.Id;
                }
            }
            ultimoId++;
            string claveConHash = MetodosEstaticos.GetHash(nuevProfesor.Clave);

            _gestorDB.CrearProfesor(nuevProfesor, ultimoId, claveConHash);

        }

        public void ModificarProfesor(Profesores profesor, string codigoAnterior)
        {
            int codigoAnteriorParseado = Convert.ToInt32(codigoAnterior);

            List<Profesores> listaProfesores = GetListaProfesores();

            foreach (Profesores profesores in listaProfesores)
            {
                if ((profesores.Correo == profesor.Correo || profesores.Dni == profesor.Dni) && profesor.Id != codigoAnteriorParseado)
                {
                    throw new Exception("El ID del Profesor ya esta en uso en otro Profe");
                }
                
               
            }

            _gestorDB.ModificarProfesor(profesor, codigoAnteriorParseado);

        }

        public void EliminarProfesor(string correo)
        {
            _gestorDB.EliminarProfesor(correo);
        }

    }
}