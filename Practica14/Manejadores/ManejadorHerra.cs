using AccesoDatos;
using Entidades;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorHerra
    {
        AccesoBase ab = new AccesoBase("localhost", "root", "", "agencia_automotriz", 3306);
        public string Guardar(EntidadHerra eh)
        {
            return ab.Comando(string.Format("insert into modulo_herramientas values('{0}','{1}','{2}', '{3}', '{4}')", eh._Codigoherra, eh._Nombre, eh._Medida, eh._Descripcion, eh._Marca));
        }


        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = ab.Mostrar(string.Format("select * from modulo_herramientas where nombre like '%{0}%' or codigoherra like '%{0}%'", dato), "modulo_herramientas").Tables["modulo_herramientas"];
            tabla.AutoResizeColumns();
        }

        public string Editar(EntidadHerra eh)
        {
            return ab.Comando(string.Format("update modulo_herramientas set nombre = '{0}', medida = '{1}', descripcion = '{2}', marca = '{3}' where codigoherra = '{4}'", eh._Nombre,
                eh._Medida, eh._Descripcion, eh._Marca, eh._Codigoherra));
        }
        public string Borrar(EntidadHerra eh)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + eh._Descripcion, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ab.Comando(string.Format("delete from modulo_herramientas where codigoherra = '{0}'", eh._Codigoherra));
            }
            return r;
        }
    }
}
