using System;
using System.Drawing;
using System.Windows.Forms;
using Manejadores;

namespace Practica14
{
    public partial class FrmLogin : Form
    {
        public static string val = "";
        ManejadorLoginRegistro mlr;
        public FrmLogin()
        {
            InitializeComponent();
            mlr = new ManejadorLoginRegistro();
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

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Gainsboro;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void chbMostrarC_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrarC.Checked == true)
            {
                txtContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                if (chbMostrarC.Checked == false)
                {
                    txtContrasena.UseSystemPasswordChar = true;
                }
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrar fr = new FrmRegistrar();
            fr.Show();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            int v = mlr.ValidarUsuario(txtUsuario.Text, txtContrasena.Text);
            if (v == 1)
            {
                this.Hide();
                val = mlr.Permiso(txtUsuario.Text);
                FrmPrincipal fp = new FrmPrincipal();
                fp.Show();
      
            }
            else
            {
                MessageBox.Show("Error, Usuario y/o Contraseña Incorrectos.");
            }
        }
    }
}
