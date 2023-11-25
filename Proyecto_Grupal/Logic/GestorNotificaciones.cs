using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GestorNotificacion
    {

        private static GestorNotificacion? _instancia = null;
        public event Action<string> OnEstudianteCreado;
        public static GestorNotificacion Instancia()
        {
            _instancia ??= new GestorNotificacion();
            return _instancia;
        }

        public void Inicializar(IReloj reloj)
        {
            if (reloj.HoraActual.Day == 22)
            {
                // hacer algo
            }
        }

        public void NotificarCreoNuevo(Estudiantes creado)
        {
            OnEstudianteCreado?.Invoke(creado.Nombre);

            Console.WriteLine("creo nuevo");
        }
        

    }
}
