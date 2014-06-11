using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class RegistroUsuario : Form
    {
        int usuario_ID;

        public RegistroUsuario(String username, String password)
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!commons.algunoVacio(txtUsername, txtPassword))
            {
                if (optCliente.Checked)
                { }
                else
                { }
            }
        }

        private void optCliente_CheckedChanged(object sender, EventArgs e)
        {
            optEmpresa.Checked = false;
        }

        private void optEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            optCliente.Checked = false;
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
