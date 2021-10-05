using AccesoDatos;
using Entidades;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorRefa
    {
        AccesoBase ab = new AccesoBase("localhost", "root", "", "agencia_automotriz", 3306);
        public string Guardar(EntidadRefa er)
        {
            return ab.Comando(string.Format("insert into modulo_refacciones values('{0}','{1}','{2}', '{3}')", er._Codigorefa, er._Nombre, er._Descripcion, er._Marca));
        }


        public void Mostrar(string dato, DataGridView tabla)
        {
            tabla.DataSource = ab.Mostrar(string.Format("select * from modulo_refacciones where nombre like '%{0}%' or codigorefa like '%{0}%';", dato), "modulo_refacciones").Tables["modulo_refacciones"];
            tabla.AutoResizeColumns();
        }

        public string Editar(EntidadRefa er)
        {
            return ab.Comando(string.Format("update modulo_refacciones set nombre = '{0}', descripcion = '{1}', marca = '{2}' where codigorefa = '{3}'", er._Nombre,
                er._Descripcion, er._Marca, er._Codigorefa));
        }
        public string Borrar(EntidadRefa er)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + er._Descripcion, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ab.Comando(string.Format("delete from modulo_refacciones where codigorefa = '{0}'", er._Codigorefa));
            }
            return r;
        }
    }
}
