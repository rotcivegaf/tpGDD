using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Historial_Cliente
{
    public partial class Historial : Form
    {
        int usuario_ID;
        int rol_ID;

        public Historial()
        {
            InitializeComponent();
        }

        public void abrir(int userID, int rolID)
        {
            usuario_ID = userID;
            rol_ID = rolID;
            if (rol_ID == commons.Rol_Cliente_ID)
                optCompras.Checked = true;
            else
            {
                optCompras.Enabled = false;
                optOfertas.Enabled = false;
                optCalificacionesOtorgadas.Enabled = false;
                optCalificacionesRecibidas.Checked = true;
            }

            this.ShowDialog();
        }

        private void optCompras_CheckedChanged(object sender, EventArgs e)
        {
            if (optCompras.Checked)
            {
                dgvHistorial.DataSource = ComprasBindingSource;
                dgvHistorial.Refresh();
                ComprasBindingSource.DataSource = historialComprasTableAdapter.GetData(usuario_ID);
                txtCantidadRegistros.Text = dgvHistorial.RowCount.ToString();
            }
        }

        private void optOfertas_CheckedChanged(object sender, EventArgs e)
        {
            if (optOfertas.Checked)
            {
                dgvHistorial.DataSource = OfertasBindingSource;
                dgvHistorial.Refresh();
                OfertasBindingSource.DataSource = historialOfertasTableAdapter.GetData(usuario_ID);
                txtCantidadRegistros.Text = dgvHistorial.RowCount.ToString();
            }
        }

        private void optCalificacionesOtorgadas_CheckedChanged(object sender, EventArgs e)
        {
            if (optCalificacionesOtorgadas.Checked)
            {
                dgvHistorial.DataSource = CalificacionesOtorgadasBindingSource;
                dgvHistorial.Refresh();
                CalificacionesOtorgadasBindingSource.DataSource = historialCalificacionesOtorgadasTableAdapter.GetData(usuario_ID);
                txtCantidadRegistros.Text = dgvHistorial.RowCount.ToString();
            }
        }

        private void optCalificacionesRecibidas_CheckedChanged(object sender, EventArgs e)
        {
            if (optCalificacionesRecibidas.Checked)
            {
                dgvHistorial.DataSource = CalificacionesRecibidasBindingSource;
                dgvHistorial.Refresh();
                //if (rol_ID == commons.Rol_Cliente_ID)
                //{
                //    CalificacionesRecibidasBindingSource.DataSource = historialCalificacionesRecibidasTableAdapter.GetDataByClienteID(usuario_ID);
                //}
                //else
                //{
                //    CalificacionesRecibidasBindingSource.DataSource = historialCalificacionesRecibidasTableAdapter.GetDataByEmpresaID(usuario_ID);
                //}
                CalificacionesRecibidasBindingSource.DataSource = historialCalificacionesRecibidasTableAdapter.GetDataByUsuarioID(usuario_ID);
                txtCantidadRegistros.Text = dgvHistorial.RowCount.ToString();
            }
        }
    }
}
