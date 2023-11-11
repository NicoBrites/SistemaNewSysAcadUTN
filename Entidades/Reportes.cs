using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reportes
    {
        private string _informe;
        private int _codigo;

        public Reportes(string informe, int codigo)
        {
            _informe = informe;
            _codigo = codigo;
        }

        public string Informe
        { get { return _informe; } }
        public int Codigo { get { return _codigo; } }
    }
}
