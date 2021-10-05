using System;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace Practica14
{
    public partial class FrmAdmin : Form
    {
        public static EntidadUsuario eu;
        ManejadorUsuario mu;
        public FrmAdmin()
        {
            eu = new EntidadUsuario();
            mu = new ManejadorUsuario();
            InitializeComponent();
        }
        int i = 0;
        void Actualizar()
        {
            mu.Mostrar(dtgDatos, txtBuscar.Text);
        }
        private void dtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            eu._IDUsuario = int.Parse(dtgDatos.CurrentRow.Cells["idusuario"].Value.ToString());
            eu._RFC = dtgDatos.CurrentRow.Cells["rfc"].Value.ToString();
            eu._Contrasena = dtgDatos.CurrentRow.Cells["contrasena"].Value.ToString();
            eu._Nombre = dtgDatos.CurrentRow.Cells["nombre"].Value.ToString();
            eu._ApellidoP = dtgDatos.CurrentRow.Cells["apellidop"].Value.ToString();
            eu._ApellidoM = dtgDatos.CurrentRow.Cells["apellidom"].Value.ToString();
            eu._Fechanacimiento = dtgDatos.CurrentRow.Cells["fechanacimiento"].Value.ToString();
            eu._FKIDPermisos = dtgDatos.CurrentRow.Cells["fkidpermisos"].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eu._IDUsuario = 0;
            eu._RFC = "";
            eu._Contrasena = "";
            eu._Nombre = "";
            eu._ApellidoP = "";
            eu._ApellidoM = "";
            eu._Fechanacimiento = "";
            eu._FKIDPermisos = "";
            FrmAddUsuario fau = new FrmAddUsuario();
            fau.ShowDialog();
            Actualizar();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmAddUsuario fau = new FrmAddUsuario();
            fau.ShowDialog();
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDatos.RowCount > 0)
            {
                string r = mu.Borrar(eu);
                if (string.IsNullOrEmpty(r))
                {
                    MessageBox.Show(r);
                    Actualizar();
                }
                Actualizar();
            }
            else
            {
                MessageBox.Show("Debe elegir un registro");
            }
        }
    }
}
