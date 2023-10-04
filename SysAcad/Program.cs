using Logic;

namespace SysAcad
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            // VALIDAR QUE EXISTEN ARCHIVOS CON METODOS ESTATICOS
            MetodosEstaticos.CrearAdministradorInicial();

            MetodosEstaticos.CrearAdministradorInicialNuevo();

            MetodosEstaticos.CrearAdministradorInicialNuevoFormato();
            //CLASES INICIALIZADORAS PARA QUE NO EXPLOTE Y EXISTA LO MINIMO Y NECESARIO PAR EL 4
            


            Application.Run(new FormLogin());
        }
    }
}