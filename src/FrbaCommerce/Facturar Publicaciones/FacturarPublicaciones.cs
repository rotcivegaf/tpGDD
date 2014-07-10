using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            dgvPendientes.ClearSelection();
            this.tlPendientesBindingSource.DataSource = this.tl_PendientesTableAdapter.getByUsuarioID(ID);
            numCantidadPendientesAFacturar.Maximum = dgvPendientes.RowCount;
        }

        private void FacturarPublicaciones_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void numCantidadPendientesAFacturar_ValueChanged(object sender, EventArgs e)
        {
            if (numCantidadPendientesAFacturar.Value == 0)
                txtMontoAFacturar.Text = "-";
            else
            {
                montoAFacturar = 0;
                for (int i = 0; i < dgvPendientes.RowCount; i++)
                {
                    if (i < numCantidadPendientesAFacturar.Value)
                    {

                        dgvPendientes.Rows[i].Cells["Facturar"].Value = true;
                        montoAFacturar += (decimal)dgvPendientes.Rows[i].Cells[2].Value;
                    }
                    else
                        dgvPendientes.Rows[i].Cells["Facturar"].Value = false;
                }
                txtMontoAFacturar.Text = montoAFacturar.ToString();
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (!faltanCampos())
            {
                int facturaNro;
                /*INSERTAR FACTURA*/
                try
                {
                    int? factNum = 0;
                    this.tl_FacturasTableAdapter.sp_InsertarFactura(commons.getDate(),cmbModoPago.Text ,ref factNum);
                    facturaNro = (int)factNum;
                }
                catch (SqlException sqlE)
                {
                    MessageBox.Show(sqlE.Message);
                    return;
                }
                /*INSERTAR ITEMS*/
                for (int i = 0; i < numCantidadPendientesAFacturar.Value; i++)
                {
                    int pendienteID = Convert.ToInt32(dgvPendientes.Rows[i].Cells["Pendiente_ID"].Value);
                    this.tl_Facturas_ItemsTableAdapter.sp_InsertarFacturaItem(facturaNro, pendienteID);
                }
                MessageBox.Show("Factura Creada");
                numCantidadPendientesAFacturar.Value = 0;
                cmbModoPago.SelectedIndex = -1;

                llenarGrid();
            }
        }

        private bool faltanCampos()
        {
            bool algunoVacio = commons.algunoVacio(numCantidadPendientesAFacturar);
            algunoVacio |= commons.algunoVacio(cmbModoPago);

            return algunoVacio;
        }
    }
}
