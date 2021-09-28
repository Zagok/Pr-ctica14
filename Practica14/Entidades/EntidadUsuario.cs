namespace Entidades
{
    public class EntidadUsuario
    {
        public EntidadUsuario()
        {
        }

        public EntidadUsuario(object idproducto, string text1, object text2, double v)
        {
        }

        public EntidadUsuario(int iDUsuario, string rFC, string contrasena, string nombre, string apellidoP, string apellidoM, string fechanacimiento, string fKIDPermisos)
        {
            _IDUsuario = iDUsuario;
            _RFC = rFC;
            _Contrasena = contrasena;
            _Nombre = nombre;
            _ApellidoP = apellidoP;
            _ApellidoM = apellidoM;
            _Fechanacimiento = fechanacimiento;
            _FKIDPermisos = fKIDPermisos;
        }

        public int _IDUsuario { get; set; }
        public string _RFC { get; set; }
        public string _Contrasena { get; set; }
        public string _Nombre { get; set; }
        public string _ApellidoP { get; set; }
        public string _ApellidoM { get; set; }
        public string _Fechanacimiento { get; set; }
        public string _FKIDPermisos { get; set; }
    }
}
