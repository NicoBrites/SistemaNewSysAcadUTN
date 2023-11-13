using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PagoDeEstudiante
    {
        private string _consepto;
        private int _monto;
        private string _nombre;
        private string _apellido;
        private int _idEstudiante;
        private DateTime _fecha;

        public PagoDeEstudiante(string consepto, int monto, string nombre, string apellido, int idEstudiante, DateTime fecha)
        {
            _apellido = apellido;
            _consepto = consepto;
            _monto = monto;
            _nombre = nombre;
            _fecha = fecha;
            _idEstudiante = idEstudiante;

        }
        public string Consepto
        {
            get { return _consepto; }
            set { _consepto = value; }
        }
        public int Monto { get { return _monto; } set { _monto = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public int IdEstudiante { get {  return _idEstudiante; } set { _idEstudiante = value; } }
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }
    }

}
