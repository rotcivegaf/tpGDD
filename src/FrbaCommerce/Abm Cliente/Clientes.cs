using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        public void abrir() 
        {
            cmbTipoDocumento.SelectedIndex = 0;
            this.ShowDialog(); 
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void Clientes_Resize(object sender, EventArgs e)
        {
            int margin = dgvClientes.Left;
            
            dgvClientes.Width = this.ClientRectangle.Width - dgvClientes.Left - margin;
            dgvClientes.Height = this.ClientRectangle.Bottom - dgvClientes.Top - margin;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid()
        {
            this.tlClientesBindingSource.DataSource = this.tl_ClientesTableAdapter.GetData().Select(crearCondicion());
        }

        private String crearCondicion()
        {
            String condicion;
            
            condicion = "Nombre LIKE '%" + txtNombre.Text + "%'";
            if (txtApellido.Text != "")
                condicion += " AND Apellido LIKE '%" + txtApellido.Text + "%'";
            if (cmbTipoDocumento.Text != "*")
                condicion += " AND Tipo_Documento = '" + cmbTipoDocumento.Text + "'";
            if (numNroDocumento.Value != 0)
                condicion += " AND Nro_Documento = " + numNroDocumento.Value;
            if (txtMail.Text != "")
                condicion += " AND Mail LIKE '%" + txtMail.Text + "%'";

            return condicion;
        }

        private void txtNombre_GotFocus(object sender, EventArgs e) { commons.selectAll(txtNombre); }
        private void txtApellido_GotFocus(object sender, EventArgs e) { commons.selectAll(txtApellido); }
        private void numNroDocumento_GotFocus(object sender, EventArgs e) { commons.selectAll(numNroDocumento); }
        private void txtMail_GotFocus(object sender, EventArgs e) { commons.selectAll(txtMail); }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClientes.Columns.Count - 1)
            {
                int ID = getClienteID(e.RowIndex);
                //FALTA HACER -> sp_EliminarCliente (que es darlo de baja)
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = getClienteID(e.RowIndex);
            Cliente cliente = new Cliente();
            cliente.editar(ID);
            llenarGrid();
        }

        private int getClienteID(int rowIndex)
        {
            DataGridViewRow fila = dgvClientes.Rows[rowIndex];
            return Convert.ToInt32(fila.Cells[0].Value); 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbTipoDocumento.SelectedIndex = 0;
            numNroDocumento.Value = 0;
            txtMail.Text = "";
            llenarGrid();
            txtNombre.Focus();
        }

        private void optNuevo_Click(object sender, EventArgs e)
        {
            Cliente frmCliente = new Cliente();
            frmCliente.nuevoByAdmin();
            llenarGrid();
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
    }
}
