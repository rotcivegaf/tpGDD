using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class FacturarPublicaciones : Form
    {
        int ID;
        int rol_ID;
        decimal montoAFacturar = 0;

        public FacturarPublicaciones()
        {
            InitializeComponent();
        }

        public void abrir(int userID, int rolID)
        {
            ID = userID;
            rol_ID = rolID;

            this.ShowDialog();
        }

        private void llenarGrid()
        {
            if (rol_ID == commons.Rol_Cliente_ID)
                this.tlPendientesBindingSource.DataSource = this.tl_PendientesTableAdapter.getByClienteID(ID);
            else //Empresa
                this.tlPendientesBindingSource.DataSource = this.tl_PendientesTableAdapter.getByEmpresaID(ID);
            numCantidadPendientesAFacturar.Maximum = dgvPendientes.RowCount;
            dgvPendientes.ClearSelection();
        }

        private void FacturarPublicaciones_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void numCantidadPendientesAFacturar_ValueChanged(object sender, EventArgs e)
        {
            montoAFacturar = 0;
            txtMontoAFacturar.Text = "-";
            for (int i = 0; i < dgvPendientes.RowCount; i++)
            {
                if (i < numCantidadPendientesAFacturar.Value)
                {
                    dgvPendientes.Rows[i].Cells[5].Value = true;
                    montoAFacturar += (decimal)dgvPendientes.Rows[i].Cells[2].Value;
                }
                else
                    dgvPendientes.Rows[i].Cells[5].Value = false;
            }
            txtMontoAFacturar.Text = montoAFacturar.ToString();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (!faltanCampos())
            { }
        }

        private bool faltanCampos()
        {
            bool algunoVacio = commons.algunoVacio(numCantidadPendientesAFacturar);
            algunoVacio |= commons.algunoVacio(cmbModoPago);

            return algunoVacio;
        }
    }
}
