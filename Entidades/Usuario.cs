namespace Entidades
{
    public  class Usuario 
    {
        private string _clave;
        private string _correo;


        public Usuario(string clave, string correo)
        {
            _clave = clave;
            _correo = correo;
        }

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }


    }

}