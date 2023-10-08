using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GestorPagos
    {
        private Archivos _gestorArchivos;
        private ValidadorTextosVacios _validadorTextosVacios;

        public GestorPagos() 
        {
            _gestorArchivos = new Archivos();
            _validadorTextosVacios = new ValidadorTextosVacios();     
        }

        public void PagarDeudas(ConseptoDePago conseptoDePago)
        {


        }




    }
}
