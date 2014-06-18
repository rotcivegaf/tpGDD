using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class NuevaCompra : Form
    {
        public NuevaCompra()
        {
            InitializeComponent();
        }
        public void sendData(int clienteID, int publicacionID, int stock)
        {
            this.UserID = clienteID;
            this.publicacionID = publicacionID;
            this.stock = stock;
        }
        private int UserID;
        private int publicacionID;
        private int stock;
        GD1C2014DataSet.tl_ClientesyEmpresasDataTable tablaTemporal = new GD1C2014DataSet.tl_ClientesyEmpresasDataTable();

        private void NuevaCompra_Load(object sender, EventArgs e)
        {
            this.numericUpDownStock.Maximum = this.stock;
            this.tl_ClientesyEmpresasDataGridView.Visible = false;
            this.label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tl_ClientesyEmpresasDataGridView.Visible = true;
            this.label2.Visible = true;
            this.tl_ClientesyEmpresasTableAdapter.FillByID(tablaTemporal, this.UserID.ToString());
            this.tl_ClientesyEmpresasDataGridView.DataSource = tablaTemporal;

        }
        
    }
}
