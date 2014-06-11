using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using FrbaCommerce.Registro_de_Usuario;

namespace FrbaCommerce.Login
{
    public partial class formLogin : Form
    {
        int usuario_ID;
        int rol_ID;

        public formLogin()
        {
            InitializeComponent();
        }

        //Hay que hacerlo con el dataset.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!commons.algunoVacio(txtUsername, txtPassword))
            {
                int? id = 0;
                try
                {
                    this.tl_UsuariosTableAdapter.sp_TryLogin(txtUsername.Text, txtPassword.Text, ref id);
                }
                catch (SqlException sqlE)
                    {
                        MessageBox.Show(sqlE.Message);
                    }
                usuario_ID = (int)id;
                commons.bloquearCampos(txtUsername, txtPassword);
                commons.bloquearCampos(btnRegistrar, btnLogin);
                btnContinuar.Enabled = true;
                
                GD1C2014DataSet.tl_RolesDataTable roles = new GD1C2014DataSet.tl_RolesDataTable();
                tl_RolesTableAdapter.getRolesPorUsuarioID(roles,(decimal)id);
                cmbRoles.DataSource = new BindingSource(roles, null);
                cmbRoles.DisplayMember = "Nombre";
                cmbRoles.ValueMember = "ID";
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            rol_ID = Convert.ToInt32(cmbRoles.SelectedValue.ToString());
            this.Close();
        }

        public int getUsuarioLogueadoID()
        {
            return this.usuario_ID;
        }
        public int getRolID()
        {
            return this.rol_ID;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!commons.algunoVacio(txtUsername,txtPassword))
            {
                RegistroUsuario frame = new RegistroUsuario(txtUsername.Text,txtPassword.Text);
                frame.ShowDialog();

            }
        }

    }
}
