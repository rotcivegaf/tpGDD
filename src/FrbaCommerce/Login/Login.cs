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
        bool logueado = false;

        public formLogin()
        {
            InitializeComponent();
        }

        public bool login()
        {
            this.ShowDialog();
            return logueado;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!commons.algunoVacio(txtUsername, txtPassword))
            {
                bool mustChangePassword;

                try
                {
                    int? id = 0;
                    bool? changePassword = false;

                    this.tl_UsuariosTableAdapter.sp_TryLogin(txtUsername.Text, commons.hash(txtPassword.Text), ref id, ref changePassword);

                    usuario_ID = (int)id;
                    mustChangePassword = (bool)changePassword;
                }
                catch (SqlException sqlE)
                    {
                        MessageBox.Show(sqlE.Message);
                        return;
                    }
                commons.bloquearCampos(txtUsername, txtPassword);
                commons.bloquearCampos(btnRegistrar, btnLogin);
                splitContainer.Visible = true;
                if (mustChangePassword)
                {
                    splitContainer.Panel1Collapsed = false;
                    splitContainer.Panel2Collapsed = true;
                    txtNewPassword.Focus();
                }
                else
                {
                    splitContainer.Panel1Collapsed = true;
                    splitContainer.Panel2Collapsed = false;
                    cmbRoles.Focus();
                    llenarComboRoles();
                }
            }
        }

        private void llenarComboRoles()
        {
            GD1C2014DataSet.tl_RolesDataTable roles = new GD1C2014DataSet.tl_RolesDataTable();
            tl_RolesTableAdapter.getRolesPorUsuarioID(roles, (decimal)usuario_ID);
            cmbRoles.DataSource = new BindingSource(roles, null);
            cmbRoles.DisplayMember = "Nombre";
            cmbRoles.ValueMember = "ID";
            if (cmbRoles.Items.Count == 1)
                getRubroIDAndClose();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            getRubroIDAndClose();
        }

        private void getRubroIDAndClose()
        {
            rol_ID = Convert.ToInt32(cmbRoles.SelectedValue.ToString());
            logueado = true;
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
                RegistroUsuario frame = new RegistroUsuario();  
                usuario_ID = frame.nuevo(txtUsername.Text, txtPassword.Text);
                if (usuario_ID != 0)
                {
                    splitContainer.Panel1Collapsed = true;
                    splitContainer.Panel2Collapsed = false;
                    cmbRoles.Focus();
                    llenarComboRoles();
                }

            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.tl_UsuariosTableAdapter.changePassword(commons.hash(txtNewPassword.Text),(decimal)usuario_ID);
            splitContainer.Panel1Collapsed = true;
            splitContainer.Panel2Collapsed = false;
            llenarComboRoles();
        }
    }
}
