using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorPerfiles
    {
        AccesoBase ab = new AccesoBase("localhost", "root", "", "agencia_automotriz", 3306);
        public string Guardar(EntidadPerfiles ep)
        {
            return ab.Comando(string.Format("insert into perfil values('{0}','{1}')", ep._IDPerfil, ep._FKIDPermisos));
        }
    }
}
