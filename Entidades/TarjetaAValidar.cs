
namespace Entidades
{
    public class TarjetaAValidar
    {
        private string _metodoPago;
        private string _numeroTarjeta;
        private string _fechaDiaCaducidad;
        private string _fechaAñoCaducidad;
        private string _codigoSeguridad;
        private string _nombre;
        private string _apellido;
        private string _localidad;
        private string _dirFacturacion;
        private string _dirFacturacion2;
        private string _codigoPostal;
        private string _telefono;

        public TarjetaAValidar(string metodoPago, string numeroTarjeta, string fechaDia,
            string fechaAño, string codigoSeguridad, string nombre, string apellido,
            string localidad, string dirFacturacion, string codigoPostal, string telefono ,string dirFacturacion2 = "") 
        { 
            _metodoPago = metodoPago;
            _numeroTarjeta = numeroTarjeta;
            _fechaDiaCaducidad = fechaDia;
            _fechaAñoCaducidad = fechaAño;
            _codigoSeguridad = codigoSeguridad;
            _nombre = nombre;
            _apellido = apellido;
            _localidad = localidad;
            _dirFacturacion = dirFacturacion;
            _dirFacturacion2=dirFacturacion2;
            _codigoPostal = codigoPostal;
            _telefono = telefono;
        }
        public string MetodoPago { get { return _metodoPago; } }
        public string NumeroTarjeta {  get { return _numeroTarjeta; } }
        public string FechaDiaCaducidad { get { return _fechaDiaCaducidad; } }
        public string FechaAñoCaducidad { get { return _fechaAñoCaducidad;} }   
        public string CodigoSeguridad { get { return _codigoSeguridad;} }
        public string Nombre { get { return _nombre;} }
        public string Apellido { get { return _apellido; } }
        public string Localidad { get { return _localidad; } }
        public string DirFacturacion { get {  return _dirFacturacion; } }
        public string DirFacturacion2 {  get { return _dirFacturacion2;} }
        public string CodigoPostal { get { return _codigoPostal;} }
        public string Telefono {  get { return _telefono; } }
        
    }
}
