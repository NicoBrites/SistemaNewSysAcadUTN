using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class JsonUsuariosFormato
   {
        public List<Administrador> Administradores { get; set; }
        public List<Estudiantes> Estudiantes { get; set; }
        public List<Profesores> Profesores { get; set; }

        public JsonUsuariosFormato() { } 
    }
}
