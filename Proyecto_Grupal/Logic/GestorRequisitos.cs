using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GestorRequisitos
    {
        private DB.DB _gestorDB;
        public GestorRequisitos() 
        {
            _gestorDB = new DB.DB();
        }

        public List<RequisitosCurso> GetRequisitosCursos()
        {
            try
            {
                List<RequisitosCurso> listaRequisitos = _gestorDB.ReturnAllRequisitosDelCurso(); ;
                return listaRequisitos;
            }
            catch (ExcepcionPropia ex)
            {
                throw new ExcepcionPropia(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ModificarRequisitos(RequisitosCurso requisitos)
        {
            List<RequisitosCurso> listaRequisitos = GetRequisitosCursos();
            bool existe = false;

            foreach(RequisitosCurso requisitosCurso in listaRequisitos)
            { 
                if (requisitosCurso.Codigo == requisitos.Codigo)
                {
                    _gestorDB.ModificarRequisito(requisitos, true);
                    existe = true;
                    break;
                }
            }
            if (existe == false)
            {
                _gestorDB.ModificarRequisito(requisitos, existe);

            }
        }
    }
}
