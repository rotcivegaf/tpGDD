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
using System.Data.SqlClient;

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class RegistroUsuario : Form
    {
        int usuario_ID;

        public int nuevo(String username, String password)
        {
            txtUsername.Text = username;
            txtPassword.Text = password;

            GD1C2014DataSet.tl_RolesDataTable rolDataTable = new GD1C2014DataSet.tl_RolesDataTable();
            DataRow rol;
            rolDataTable = tl_RolesTableAdapter.getByNombre("Cliente");
            rol = rolDataTable.Rows[0];
            optCliente.Enabled = Convert.ToBoolean(rol["Habilitado"]);


            rolDataTable = tl_RolesTableAdapter.getByNombre("Empresa");
            rol = rolDataTable.Rows[0];
            optEmpresa.Enabled = Convert.ToBoolean(rol["Habilitado"]);

            this.ShowDialog();

            return usuario_ID;
        }

        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!faltanCampos())
            {
                try
                {
                    int? userID = 0;
                    this.tl_UsuariosTableAdapter.sp_InsertarUsuario(txtUsername.Text, commons.hash(txtPassword.Text), false, ref userID);
                    usuario_ID = (int)userID;
                }
                catch (SqlException sqlE)
                {
                   MessageBox.Show(sqlE.Message);
                    return;
                }
                if (optCliente.Checked)
                {
                    Cliente frame = new Cliente();
                    frame.nuevo(usuario_ID);
                }
                else
                {
                    Empresa frame = new Empresa();
                    frame.nueva(usuario_ID);
                }
                this.Close();
            }
        }

        private bool faltanCampos()
        {
            bool algunoVacio = commons.algunoVacio(txtUsername, txtPassword);   
            if (!optCliente.Checked && !optEmpresa.Checked)
            {    
                MessageBox.Show("Debe seleccionar el Rol");
                algunoVacio = true;
            }

            return algunoVacio;
        }
    }
}
