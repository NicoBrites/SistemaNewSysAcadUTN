using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionPropia : Exception
    {
        public ExcepcionPropia(string message) : base(message)
        {

        }
        public override string Message => $"Nuevo mensaje : {base.Message}";
    }
}
