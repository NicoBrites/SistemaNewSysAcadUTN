using Entidades;

namespace Logic
{
    public class GestorRequisitos
    {
        private DB.DB _gestorDB;
        public GestorRequisitos() 
        {
            _gestorDB = new DB.DB();
        }
        /// <summary>
        /// Obtiene la lista de requisitos de cursos.
        /// </summary>
        /// <returns>Lista de requisitos de cursos.</returns>
        public List<RequisitosCurso> GetRequisitosCursos()
        {
            try
            {
                List<RequisitosCurso> listaRequisitos = _gestorDB.ReturnAllRequisitosDelCurso();
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
        /// <summary>
        /// Modifica los requisitos del curso.
        /// </summary>
        /// <param name="requisitos">Requisitos a modificar.</param>
        public async void ModificarRequisitos(RequisitosCurso requisitos)
        {
            List<RequisitosCurso> listaRequisitos = GetRequisitosCursos();
            bool existe = false;

            foreach(RequisitosCurso requisitosCurso in listaRequisitos)
            { 
                if (requisitosCurso.Codigo == requisitos.Codigo)
                {
                    await _gestorDB.ModificarRequisito(requisitos, true);
                    existe = true;
                    break;
                }
            }
            if (existe == false)
            {
                await _gestorDB.ModificarRequisito(requisitos, existe);

            }
        }
    }
}
