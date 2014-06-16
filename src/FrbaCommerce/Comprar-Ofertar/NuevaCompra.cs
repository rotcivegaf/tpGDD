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

        private void NuevaCompra_Load(object sender, EventArgs e)
        {
            numericUpDownStock.Maximum = this.stock;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Acá empieza el baile porque no tengo idea como hacer que se muestre los datos de
            //un vendedor sea el mismo empresa o cliente...
        }
        
    }
}
