using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Empresas : Form
    {
        public Empresas()
        {
            InitializeComponent();
        }
        
        public void abrir()
        {
            this.ShowDialog();
        }

        private void Empresas_Resize(object sender, EventArgs e)
        {
            int margin = dgvEmpresas.Left;

            dgvEmpresas.Width = this.ClientRectangle.Width - dgvEmpresas.Left - margin;
            dgvEmpresas.Height = this.ClientRectangle.Bottom - dgvEmpresas.Top - margin;
        }

        private void opcNueva_Click(object sender, EventArgs e)
        {
            Empresa frmEmpresa = new Empresa();
            if (frmEmpresa.nuevaByAdmin())
                llenarGrid();
        }

        private void opcSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRazonSocial.Text = "";
            txtCUIT.Text = "";
            txtMail.Text = "";
            llenarGrid();
            txtRazonSocial.Focus();
        }

        private String crearCondicion()
        {
            String condicion;

            condicion = "Razon_Social LIKE '%" + txtRazonSocial.Text + "%'";
            if (txtCUIT.Text != "")
                condicion += " AND CUIT = '" + txtCUIT.Text + "'";
            if (txtMail.Text != "")
                condicion += " AND Mail LIKE '%" + txtMail.Text + "%'";

            return condicion;
        }

        private void llenarGrid()
        {
            this.tlEmpresasBindingSource.DataSource = this.tl_EmpresasTableAdapter.GetData().Select(crearCondicion());
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
        
        void dgvEmpresas_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ID = getEmpresaID(e.RowIndex);
                Empresa frmEmpresa = new Empresa();
                if (frmEmpresa.editar(ID))
                    llenarGrid();
            } 
        }
        
        private int getEmpresaID(int rowIndex)
        {
            DataGridViewRow fila = dgvEmpresas.Rows[rowIndex];
            return Convert.ToInt32(fila.Cells[0].Value);
        }

        private void txtMail_GotFocus(object sender, EventArgs e) { commons.selectAll(txtMail); }
        private void txtCUIT_GotFocus(object sender, EventArgs e) { commons.selectAll(txtCUIT); }
        private void txtRazonSocial_GotFocus(object sender, EventArgs e) { commons.selectAll(txtRazonSocial); }

        private void dgvEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmpresas.ColumnCount - 1 && e.RowIndex >= 0)
            {
                int ID = getEmpresaID(e.RowIndex);
                //FALTA HACER -> sp_EliminarEmpresa
            }
        }
    }
}
