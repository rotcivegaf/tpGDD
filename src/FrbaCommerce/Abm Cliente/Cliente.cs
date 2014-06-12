using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Cliente : Form
    {
        int ID;

        public Cliente()
        {
            InitializeComponent();
        }

        public void nuevo(int usuario_ID)
        {
            this.ShowDialog();
        }

        public int getClienteID()
        { return ID; }
    }
}
