using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Historial_Cliente
{
    public partial class Historial : Form
    {
        int usuario_ID;
        int rol_ID;

        public Historial()
        {
            InitializeComponent();
        }

        public void abrir(int userID, int rolID)
        {
            usuario_ID = userID;
            rol_ID = rolID;
            if (rol_ID == 2) //Cliente
                optCompras.Checked = true;
            else
            {
                optCompras.Enabled = false;
                optOfertas.Enabled = false;
                optCalificacionesOtorgadas.Enabled = false;
                optCalificacionesRecibidas.Checked = true;
            }

            this.ShowDialog();
        }

        private void optCompras_CheckedChanged(object sender, EventArgs e)
        {
            if (optCompras.Checked)
            {
                String condicion = "Cliente_ID = " + usuario_ID;
                this.dgvHistorialBindingSource.DataSource = this.tl_ComprasTableAdapter.GetData().Select(condicion);
            }
        }

        private void optOfertas_CheckedChanged(object sender, EventArgs e)
        {
            if (optOfertas.Checked)
            {
                String condicion = "Cliente_ID = " + usuario_ID;
                //this.dgvHistorialBindingSource.DataSource = this.tl_OfertasTableAdapter.GetData().Select(condicion());
            }
        }

        private void optCalificacionesOtorgadas_CheckedChanged(object sender, EventArgs e)
        {
            if (optCalificacionesOtorgadas.Checked)
            {
                String condicion = "Cliente_ID = " + usuario_ID;
                //this.dgvHistorialBindingSource.DataSource = this.tl_OfertasTableAdapter.GetData().Select(condicion());
            }
        }

        private void optCalificacionesRecibidas_CheckedChanged(object sender, EventArgs e)
        {
            if (optCalificacionesRecibidas.Checked)
            {
                String condicion;
                if (rol_ID == 2)//Cliente
                {
                    condicion = "Cliente_ID = " + usuario_ID;
                    //this.dgvHistorialBindingSource.DataSource = this.tl_OfertasTableAdapter.GetData().Select(condicion()) ;
                }
                else
                {
                    condicion = "Empresa_ID = " + usuario_ID;
                    //this.dgvHistorialBindingSource.DataSource = this.tl_OfertasTableAdapter.GetData().Select(condicion()) 
                }
            }
        }
    }
}
