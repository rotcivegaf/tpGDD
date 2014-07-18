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
        bool debeCalificarTodo;

        public CalificarVendedor()
        {
            InitializeComponent();
        }
        
        public void abrir(int user_ID,bool debe_Calificar_Todo)
        {
            usuario_ID = user_ID;
            debeCalificarTodo = debe_Calificar_Todo;

            this.ShowDialog();
        }

        private void CalificarVendedor_Load(object sender, EventArgs e) { llenarGrid(); }

        void CalificarVendedor_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (debeCalificarTodo && dgvCompras.Rows.Count > 0)
            {
                MessageBox.Show("Debe Calificar todas sus Compras");
                e.Cancel = true;
            }
        }

        private void llenarGrid()
        {
            this.tlComprasBindingSource.DataSource = this.tl_ComprasTableAdapter.GetPendientesCalificarByID(usuario_ID);
        }

        private void dgvCompras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == Calificar.Index)
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
            numCantidadEstrellas.Value = 0;
            cmbDescripcion.Text = "";
            grpCompras.Enabled = true;
            grpCalificacion.Enabled = false;
            llenarGrid();
        }

    }
}
