using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class SeleccionarRubro : Form
    {
        public int rubroID = 0;
        public string rubroDescripcion = "";

        public SeleccionarRubro()
        {
            InitializeComponent();
        }

        public bool seleccionar()
        {
            this.ShowDialog();
            return rubroID != 0;
        }

        private void SeleccionarRubro_Load(object sender, EventArgs e)
        {
            llenarRubros();

        }

        private void llenarRubros()
        {
            tlRubrosBindingSource.DataSource = tl_RubrosTableAdapter.getRubros(txtDescripcion.Text);
        }

        private void dgvRubros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Elegir.Index)
            {
                DataGridViewRow fila = dgvRubros.Rows[e.RowIndex];
                this.rubroID = Convert.ToInt32(fila.Cells[colID.Index].Value);
                this.rubroDescripcion = fila.Cells[colDescripcion.Index].Value.ToString();
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            llenarRubros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            llenarRubros();
            txtDescripcion.Focus();
        }

        void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                llenarRubros();
        }
    }
}
