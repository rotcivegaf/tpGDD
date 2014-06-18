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
    public partial class HistorialCliente : Form
    {
        int usuario_ID;
        int rol_ID;

        public HistorialCliente()
        {
            InitializeComponent();
        }

        public void abrir(int userID, int rolID)
        {
            usuario_ID = userID;
            rol_ID = rolID;
            optCompras.Checked = true;

            this.ShowDialog();
        }

        private void optCompras_CheckedChanged(object sender, EventArgs e)
        {
            if (optCompras.Checked)
            {

            }
        }

        private void optOfertas_CheckedChanged(object sender, EventArgs e)
        {
            if (optOfertas.Checked)
            {
                
            }
        }

        private void optCalificaciones_CheckedChanged(object sender, EventArgs e)
        {
            if (optCalificaciones.Checked)
            {
                
            }
        }
    }
}
