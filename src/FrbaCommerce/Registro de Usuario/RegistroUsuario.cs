using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrbaCommerce.Abm_Cliente;
using FrbaCommerce.Abm_Empresa;

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class RegistroUsuario : Form
    {
        int usuario_ID;

        public RegistroUsuario(String username, String password)
        {
            InitializeComponent();
            txtUsername.Text = username;
            txtPassword.Text = password;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int rol_ID;

            if (!commons.algunoVacio(txtUsername, txtPassword))
                if (!optCliente.Checked && !optEmpresa.Checked)
                    MessageBox.Show("Debe seleccionar el Rol");
                else
            {
                usuario_ID = Convert.ToInt32(this.tl_UsuariosTableAdapter.InsertAndGetID(txtUsername.Text, commons.hash(txtPassword.Text) ).ToString());
                if (optCliente.Checked)
                {
                    Cliente frame = new Cliente();
                    frame.nuevo(usuario_ID);
                    frame.getClienteID();
                    rol_ID = 2;
                }
                else
                {
                    Empresa frame = new Empresa();
                    frame.nuevo(usuario_ID);
                    rol_ID=frame.getEmpresaID();
                    rol_ID = 3;
                }
                this.tl_Usuarios_RolesTableAdapter.Insert(usuario_ID,rol_ID,true);
            }
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
