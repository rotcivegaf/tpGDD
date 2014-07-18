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
            llenarRoles();
        }

        private void llenarRoles()
        {
            this.tl_RolesTableAdapter.Fill(this.gD1C2014DataSet.tl_Roles);
        }

        //Cuando se clickea un boton seleccionar pasamos los datos al formulario de edicion.
        private void Roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == seleccionar.Index)
                {
                    Edit_Rol_Form editForm = new Edit_Rol_Form(
                        Convert.ToInt32(Roles.Rows[e.RowIndex].Cells[0].Value),
                        Roles.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        Convert.ToBoolean(Roles.Rows[e.RowIndex].Cells[2].Value));
                    editForm.ShowDialog();
                    llenarRoles();
                }
                else if (e.ColumnIndex == Deshabilitar.Index)
                {
                    //Deshabilitamos el Rol, y los Usuarios con este Rol.
                    this.tl_RolesTableAdapter.deshabilitar(Convert.ToInt32(Roles.Rows[e.RowIndex].Cells[iDDataGridViewTextBoxColumn.Index].Value));
                    MessageBox.Show("Rol deshabilitado");
                    llenarRoles();

                }
        }

        private void optNuevo_Click(object sender, EventArgs e)
        {
            Edit_Rol_Form editForm = new Edit_Rol_Form(-1, "-1", false);
            editForm.ShowDialog();
            llenarRoles();
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}