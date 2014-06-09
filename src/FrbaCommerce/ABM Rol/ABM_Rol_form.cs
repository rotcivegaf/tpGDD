using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.ABM_Rol
{
    public partial class ABM_Rol_Form : Form
    {
        public ABM_Rol_Form()
        {
            InitializeComponent();
        }

        private void ABM_Rol_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2014DataSet.tl_Roles' table. You can move, or remove it, as needed.
            this.tl_RolesTableAdapter.Fill(this.gD1C2014DataSet.tl_Roles);
        }

        private void NuevoRol_Click(object sender, EventArgs e)
        {
            Edit_Rol_Form editForm = new Edit_Rol_Form(-1, "-1", false);
            editForm.FormClosed += new FormClosedEventHandler(editForm_FormClosed);
            editForm.ShowDialog(); 
        }

        private void editForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tl_RolesTableAdapter.Fill(this.gD1C2014DataSet.tl_Roles);
        }

        private void EditarRol_Click(object sender, EventArgs e)
        {
            Edit_Rol_Form editForm = new Edit_Rol_Form(Convert.ToInt32(Roles.SelectedRows[0].Cells[0].Value), Roles.SelectedRows[0].Cells[1].Value.ToString(), Convert.ToBoolean(Roles.SelectedRows[0].Cells[2].Value));
            editForm.FormClosed += new FormClosedEventHandler(editForm_FormClosed);
            editForm.ShowDialog();
        }

        private void EliminarRol_Click(object sender, EventArgs e)
        {
            this.tl_RolesTableAdapter.sp_EliminarRol(Convert.ToInt32(Roles.SelectedRows[0].Cells[0].Value));
            this.tl_RolesTableAdapter.Fill(this.gD1C2014DataSet.tl_Roles);
        }

    }
}