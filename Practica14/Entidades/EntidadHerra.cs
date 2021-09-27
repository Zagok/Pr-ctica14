using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadHerra
    {
        public EntidadHerra(string codigoherra, string nombre, string medida, string descripcion, string marca)
        {
            _Codigoherra = codigoherra;
            _Nombre = nombre;
            _Medida = medida;
            _Descripcion = descripcion;
            _Marca = marca;
        }

        public string _Codigoherra { get; set; }
        public string _Nombre { get; set; }
        public string _Medida { get; set; }
        public string _Descripcion { get; set; }
        public string _Marca { get; set; }
    }
}
