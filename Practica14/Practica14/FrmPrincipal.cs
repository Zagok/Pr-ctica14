using System;
using System.Windows.Forms;
using Manejadores;

namespace Practica14
{
    public partial class FrmPrincipal : Form
    {
        ManejadorLoginRegistro mlr;
        public FrmPrincipal()
        {
            InitializeComponent();
            btnAdmin.Hide();
            if(FrmLogin.val == "ADMINISTRADOR")
            {
                btnAdmin.Show();
            }
        }

        public static Form frmactivo = null;
        public static Form frmhijo;
        public void AbrirFrmHijo(Form frmhijo)
        {
            if (frmactivo != null)
            {
                frmactivo.Close();
            }
            frmactivo = frmhijo;
            frmhijo.TopLevel = false;
            frmhijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(frmhijo);
            pnlContenedor.Tag = frmhijo;
            frmhijo.BringToFront();
            frmhijo.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlContenedor.BringToFront();
        }

        private void btnRefa_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmRefacciones());
        }

        private void btnHerra_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmHerramientas());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmAdmin());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }
    }
}
