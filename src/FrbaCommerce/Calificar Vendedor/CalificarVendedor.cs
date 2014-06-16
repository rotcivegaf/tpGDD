using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class CalificarVendedor : Form
    {
        int usuario_ID;
        int compra_ID;

        public CalificarVendedor()
        {
            InitializeComponent();
        }
        
        public void abrir(int user_ID)
        {
            usuario_ID=user_ID;
            this.ShowDialog();
        }

        private void CalificarVendedor_Load(object sender, EventArgs e) { llenarGrid(); }

        private void llenarGrid()
        {
            String condicion = "Cliente_ID = " + usuario_ID + " AND Calificacion_Codigo IS NULL";

            this.tlComprasBindingSource.DataSource = this.tl_ComprasTableAdapter.GetData().Select(condicion);
        }

        private void dgvCompras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvCompras.ColumnCount - 1)
            {
                compra_ID = getCompraID(e.RowIndex);
                grpCompras.Enabled = false;
                grpCalificacion.Enabled = true;
                numCantidadEstrellas.Focus();
            }
        }

        private int getCompraID(int rowIndex)
        {
            DataGridViewRow fila = dgvCompras.Rows[rowIndex];
            return Convert.ToInt32(fila.Cells[0].Value);
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {

            this.tl_ComprasTableAdapter.sp_CalificarVendedor(compra_ID, (byte)numCantidadEstrellas.Value, cmbDescripcion.Text);
            llenarGrid();
            grpCompras.Enabled = true;
            grpCalificacion.Enabled = false;
            numCantidadEstrellas.Value = 0;
            cmbDescripcion.Text = "";
        }
    }
}
