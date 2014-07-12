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
    public partial class NuevaOferta : Form
    {
        private int userID;
        private int publicacionCodigo;

        public NuevaOferta()
        {
            InitializeComponent();
        }

        public void setID(int user_ID)
        {
            userID = user_ID;
        }

        public void abrir (int user_ID,int publicacion_Codigo)
        {
            this.userID = user_ID;
            this.publicacionCodigo = publicacion_Codigo;

            decimal? MaxOferta = this.tl_OfertasTableAdapter.getOfertaMaximaByCodigo(publicacionCodigo);
            this.numericUpDownOferta.Minimum = MaxOferta != null ? (int)MaxOferta + 1 : 1;
            this.numericUpDownOferta.Value = this.numericUpDownOferta.Minimum;

            this.ShowDialog();
        }

        private void buttonOfertar_Click(object sender, EventArgs e)
        {
            this.tl_OfertasTableAdapter.sp_crearOferta(publicacionCodigo, userID, commons.getDate(), numericUpDownOferta.Value);
            this.buttonOfertar.Enabled = false;
            this.numericUpDownOferta.Enabled = false;
            MessageBox.Show ("Oferta creada");
            this.Close();
        }

    }
}
