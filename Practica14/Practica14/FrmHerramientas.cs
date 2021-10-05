using System;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace Practica14
{
    public partial class FrmHerramientas : Form
    {
        EntidadHerra eh;
        ManejadorHerra mh;
        public FrmHerramientas()
        {
            InitializeComponent();
            eh = new EntidadHerra();
            mh = new ManejadorHerra();
        }
        int i = 0;
        void Actualizar()
        {
            mh.Mostrar(dtgDatos, txtBuscar.Text);
        }
        private void dtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            eh._Codigoherra = dtgDatos.CurrentRow.Cells["codigoherra"].Value.ToString();
            eh._Nombre = dtgDatos.CurrentRow.Cells["nombre"].Value.ToString();
            eh._Medida = dtgDatos.CurrentRow.Cells["medida"].Value.ToString();
            eh._Descripcion = dtgDatos.CurrentRow.Cells["descripcion"].Value.ToString();
            eh._Marca = dtgDatos.CurrentRow.Cells["marca"].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
