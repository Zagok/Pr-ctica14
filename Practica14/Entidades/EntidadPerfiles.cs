using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadPerfiles
    {
        public EntidadPerfiles()
        {
        }

        public EntidadPerfiles(int id, string iDPerfil, string fKIDPermisos)
        {
            _ID = id;
            _IDPerfil = iDPerfil;
            _FKIDPermisos = fKIDPermisos;
        }

        public int _ID { get; set; }
        public string _IDPerfil { get; set; }
        public string _FKIDPermisos { get; set; }
    }
}
