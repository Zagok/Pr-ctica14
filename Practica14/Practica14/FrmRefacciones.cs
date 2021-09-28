﻿using System;
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
    public partial class FrmRefacciones : Form
    {
        EntidadRefa er;
        ManejadorRefa mr;
        public FrmRefacciones()
        {
            er = new EntidadRefa();
            mr = new ManejadorRefa();
            InitializeComponent();
        }
        int i = 0;
        void Actualizar()
        {
            mr.Mostrar(txtBuscar.Text, dtgDatos);
        }
        private void dtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            er._Codigorefa = dtgDatos.CurrentRow.Cells["codigorefa"].Value.ToString();
            er._Nombre = dtgDatos.CurrentRow.Cells["nombre"].Value.ToString();
            er._Descripcion = dtgDatos.CurrentRow.Cells["descripcion"].Value.ToString();
            er._Marca = dtgDatos.CurrentRow.Cells["marca"].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
