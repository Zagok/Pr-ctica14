namespace Entidades
{
    public class EntidadRefa
    {
        public EntidadRefa()
        {
        }

        public EntidadRefa(string codigorefa, string nombre, string descripcion, string marca)
        {
            _Codigorefa = codigorefa;
            _Nombre = nombre;
            _Descripcion = descripcion;
            _Marca = marca;
        }

        public string _Codigorefa { get; set; }
        public string _Nombre { get; set; }
        public string _Descripcion { get; set; }
        public string _Marca { get; set; }
    }
}
