using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class JsonFormato
    {
        public Dictionary<string, List<Estudiantes>> DiccionarioEstudiantes { get; set; }
        public Dictionary<string, List<Administrador>> DiccionarioAdministrador { get; set; }
        public Dictionary<string, List<Profesores>> DiccionarioProfesores { get; set; }

        public JsonFormato() { }

    }
}
