using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ValidadorTextosVacios
    {
        public ValidadorTextosVacios() { }  

        public bool ValidarTextosVacios(string texto)
        {
            if (texto == null || texto.Trim() == "" )
            {
                return false;
            }
            return true;
        }
    }
}
