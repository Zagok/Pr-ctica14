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
using Entidades;

namespace Practica14
{
    public partial class FrmAddPerfiles : Form
    {
        ManejadorPerfiles mp;
        public FrmAddPerfiles()
        {
            mp = new ManejadorPerfiles();
            InitializeComponent();
            if (FrmAdmin.ep._ID != 0)
            {
                txtPerfil.Text = FrmAdmin.ep._IDPerfil;
                txtPermiso.Text = FrmAdmin.ep._FKIDPermisos;
            }
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {
            if (FrmAdmin.ep._ID == 0)
            {
                MessageBox.Show(mp.Guardar(new EntidadPerfiles(FrmAdmin.ep._ID, txtPerfil.Text, txtPermiso.Text)));
                Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
