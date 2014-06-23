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
    public partial class NuevaSubasta : Form
    {
        private int userID;
        private int precio;
        private int publicacionID;
        public NuevaSubasta()
        {
            InitializeComponent();
        }

        public void setID(int user_ID)
        {
            userID = user_ID;
        }

        public void sendData (int precio, int publicacionID)
        {
            this.precio=precio;
            this.publicacionID = publicacionID;
            this.numericUpDownOferta.Value = this.precio;
            this.numericUpDownOferta.Minimum = this.precio;
        }

        private void NuevaSubasta_Load(object sender, EventArgs e)
        {
            this.numericUpDownOferta.Value = this.precio;
            this.numericUpDownOferta.Minimum = this.precio;
        }

        private void buttonOfertar_Click(object sender, EventArgs e)
        {
            this.tl_OfertasTableAdapter1.sp_crearOferta(publicacionID, userID, commons.getDate(), numericUpDownOferta.Value);
            this.buttonOfertar.Enabled = false;
            this.numericUpDownOferta.Enabled = false;
            MessageBox.Show ("Oferta creada");
            
        }

    }
}
