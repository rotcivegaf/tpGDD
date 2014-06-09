using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Login;

namespace FrbaCommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(commons.hash("w23e"));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formLogin frame = new formLogin();

            frame.ShowDialog();
        }
    }
}
