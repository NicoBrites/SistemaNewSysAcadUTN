using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RequisitosCurso
    {
        private string _nombre;
        private int _codigo;
        private string _cursosPreRequisito;
        private int _creditosAcumulados;
        private int _promedioAcademico;

        public RequisitosCurso(string nombre, int codigo, string cursosPreRequisito, int creditosAcumulados, int promedioAcademico)
        {
            _nombre = nombre;
            _codigo = codigo;
            _cursosPreRequisito = cursosPreRequisito;
            _creditosAcumulados = creditosAcumulados;
            _promedioAcademico = promedioAcademico;
        }
        
        public string Nombre { get { return _nombre; } }
        public int Codigo { get { return _codigo; } }
        public string CursosPreRequisito { get {  return _cursosPreRequisito; } }
        public int CreditosAcumulados { get { return _creditosAcumulados; } }
        public int PromedioAcademico { get { return _promedioAcademico;} }  
    }
}
