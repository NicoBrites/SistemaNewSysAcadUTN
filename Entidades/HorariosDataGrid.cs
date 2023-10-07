using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HorariosDataGrid
    {
        private string _diaSemana;
        private string _nombreYAula;
        private string _turno;

        public HorariosDataGrid(string turno, string nombreYAula, string diaSemana)
        {
            _turno = turno;
            _nombreYAula = nombreYAula;
            _diaSemana = diaSemana;
        }
        public string Turno { get { return _turno; } }
        public string NombreYAula { get {  return _nombreYAula; } }
        public string DiaSemana { get {  return _diaSemana; } }
    }
}
