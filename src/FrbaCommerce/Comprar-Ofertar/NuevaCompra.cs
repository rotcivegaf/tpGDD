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

        public void sendData(int clienteID, int publicacionCodigo, int stock, int visibilidad, decimal precio, int vendedor)
        {
            this.UserID = clienteID;
            this.publicacionCodigo = publicacionCodigo;
            this.stock = stock;
            this.visibilidad = visibilidad; ;
            this.precio = precio;
            this.vendedor = vendedor;
        }
        private int UserID;
        private int publicacionCodigo;
        private int stock;
        private int visibilidad;
        private decimal precio;
        private decimal comision;
        private int vendedor;

        GD1C2014DataSet.tl_ClientesyEmpresasDataTable tablaTemporal = new GD1C2014DataSet.tl_ClientesyEmpresasDataTable();
        //Cargo stock y habilito compra si hay stock
        private void NuevaCompra_Load(object sender, EventArgs e)
        {
            this.numericUpDownStock.Maximum = this.stock;
            this.tl_ClientesyEmpresasDataGridView.Visible = false;
            this.label2.Visible = false;
            if (this.stock <= 0)
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tl_ClientesyEmpresasDataGridView.Visible = true;
            this.label2.Visible = true;
            this.tl_ClientesyEmpresasTableAdapter.FillByID(tablaTemporal,vendedor);
            this.tl_ClientesyEmpresasDataGridView.DataSource = tablaTemporal;
            comision = (decimal)this.tl_VisibilidadesTableAdapter.PorcentajePorCodigo(visibilidad) * stock * precio;
            this.tl_ComprasTableAdapter.sp_crearCompra(publicacionCodigo,
                UserID,
                commons.getDate(),
               Convert.ToInt32(this.numericUpDownStock.Value));
            this.numericUpDownStock.Enabled = false;
            this.button1.Enabled = false;
        }
        
    }
}
