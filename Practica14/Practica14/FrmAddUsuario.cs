using System;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace Practica14
{
    public partial class FrmAddUsuario : Form
    {
        EntidadUsuario eu;
        ManejadorUsuario mu;
        public FrmAddUsuario()
        {
            mu = new ManejadorUsuario();
            eu = new EntidadUsuario();
            InitializeComponent();
            if (FrmAdmin.eu._IDUsuario != 0)
            {
                txtRFC.Text = FrmAdmin.eu._RFC;
                txtContraseña.Text = FrmAdmin.eu._Contrasena;
                txtNombre.Text = FrmAdmin.eu._Nombre;
                txtApeP.Text = FrmAdmin.eu._ApellidoP;
                txtApeM.Text = FrmAdmin.eu._ApellidoM;
                txtFecha.Text = FrmAdmin.eu._Fechanacimiento;
                txtPermiso.Text = FrmAdmin.eu._FKIDPermisos;
            }
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {
            if (FrmAdmin.eu._IDUsuario == 0)
            {
                MessageBox.Show(mu.Guardar(new EntidadUsuario(FrmAdmin.eu._IDUsuario, txtRFC.Text, txtContraseña.Text, txtNombre.Text, txtApeP.Text, txtApeM.Text, txtFecha.Text, txtPermiso.Text)));
                Close();
            }
            else
            {
                MessageBox.Show(mu.Editar(new EntidadUsuario(FrmAdmin.eu._IDUsuario, txtRFC.Text, txtContraseña.Text, txtNombre.Text, txtApeP.Text, txtApeM.Text, txtFecha.Text, txtPermiso.Text)));
            }
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
