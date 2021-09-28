using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace Practica14
{
    public partial class FrmRegistrar : Form
    {
        ManejadorLoginRegistro mlr;
        EntidadUsuario eu;
        public FrmRegistrar()
        {
            InitializeComponent();
            mlr = new ManejadorLoginRegistro();
            eu = new EntidadUsuario();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Gainsboro;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Gainsboro;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtConfContraseña_Enter(object sender, EventArgs e)
        {
            if (txtConfContraseña.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtConfContraseña.Text = "";
                txtConfContraseña.ForeColor = Color.Gainsboro;
                txtConfContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtConfContraseña_Leave(object sender, EventArgs e)
        {
            if (txtConfContraseña.Text == "")
            {
                txtConfContraseña.Text = "CONFIRMAR CONTRASEÑA";
                txtConfContraseña.ForeColor = Color.Gray;
                txtConfContraseña.UseSystemPasswordChar = false;
            }
        }

        private void chbMostrarC_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrarC.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtConfContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                if (chbMostrarC.Checked == false)
                {
                    txtContraseña.UseSystemPasswordChar = true;
                    txtConfContraseña.UseSystemPasswordChar = true;
                }
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE(S)")
            {              
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Gainsboro;
            }
        }

        private void txtApeP_Enter(object sender, EventArgs e)
        {
            if (txtApeP.Text == "APELLIDO PATERNO")
            {
                txtApeP.Text = "";
                txtApeP.ForeColor = Color.Gainsboro;
            }
        }

        private void txtApeP_Leave(object sender, EventArgs e)
        {
            if (txtApeP.Text == "")
            {
                txtApeP.Text = "APELLIDO PATERNO";
                txtApeP.ForeColor = Color.Gray;
            }
        }

        private void txtApeM_Enter(object sender, EventArgs e)
        {
            if (txtApeM.Text == "APELLIDO MATERNO")
            {
                txtApeM.Text = "";
                txtApeM.ForeColor = Color.Gainsboro;
            }
        }

        private void txtApeM_Leave(object sender, EventArgs e)
        {
            if (txtApeM.Text == "")
            {
                txtApeM.Text = "APELLIDO MATERNO";
                txtApeM.ForeColor = Color.Gray;
            }
        }

        private void txtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "FECHA DE NACIMIENTO")
            {
                txtFecha.Text = "";
                txtFecha.ForeColor = Color.Gainsboro;
            }
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "FECHA DE NACIMIENTO";
                txtFecha.ForeColor = Color.Gray;
            }
        }

        private void txtPermisos_Leave(object sender, EventArgs e)
        {
            if (txtPermisos.Text == "")
            {
                txtPermisos.Text = "PERMISOS";
                txtPermisos.ForeColor = Color.Gray;
            }
        }

        private void txtPermisos_Enter(object sender, EventArgs e)
        {
            if (txtPermisos.Text == "PERMISOS")
            {
                txtPermisos.Text = "";
                txtPermisos.ForeColor = Color.Gainsboro;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfContraseña.Text)
            {
                GuardarRegistro();
                this.Hide();
                FrmLogin fl = new FrmLogin();
                fl.Show();
            }
            else
            {
                MessageBox.Show("Verifique que las contraseñas coincidan.");
            }
        }
        public static string permiso;
        private void GuardarRegistro()
        {
            permiso = eu._FKIDPermisos;
            eu._RFC = txtUsuario.Text;
            eu._Contrasena = txtContraseña.Text;
            eu._Nombre = txtNombre.Text;
            eu._ApellidoP = txtApeP.Text;
            eu._ApellidoM = txtApeM.Text;
            eu._Fechanacimiento = txtFecha.Text;
            eu._FKIDPermisos = txtPermisos.Text;
            mlr.Guardar(eu);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE(S)";
                txtNombre.ForeColor = Color.Gray;
            }
        }
    }
}