using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Login
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!commons.algunoVacio(txtUsername, txtPassword))
            {
                SqlParameter par1 = new SqlParameter("@user", txtUsername.Text);
                SqlParameter par2 = new SqlParameter("@pass", txtPassword.Text);
                SqlParameter output = new SqlParameter("@ID", SqlDbType.Int);
                output.Direction = ParameterDirection.Output;
                List<SqlParameter> lista = new List<SqlParameter>();

                lista.Add(par1);
                lista.Add(par2);
                lista.Add(output);

                db.runFunction("TryLogin", lista);
                MessageBox.Show("id: " + (int)output.Value);
            }
        }
    }
}
