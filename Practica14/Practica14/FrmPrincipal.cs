using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(FrmLogin.val == "ADMIN")
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
    }
}
