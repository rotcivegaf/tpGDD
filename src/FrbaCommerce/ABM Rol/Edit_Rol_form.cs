using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce;

namespace FrbaCommerce.ABM_Rol
{
    public partial class Edit_Rol_Form : Form
    {
        private int selectedRol;
        private string rolName;
        private bool habilitado;

        public Edit_Rol_Form(int selected, string selectedName, bool hab)
        {
            selectedRol = selected;
            rolName = selectedName;
            habilitado = hab;
            InitializeComponent();
        }

        private void Edit_Rol_Form_Load(object sender, EventArgs e)
        {
            this.tl_FuncionalidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Funcionalidades);
            if (this.selectedRol != -1)
            {
                this.inputNombre.Text = this.rolName;
                this.Habilitado.Checked = habilitado;
                GD1C2014DataSet.tl_FuncionalidadesDataTable funcionalidadesDeUnRol;
                funcionalidadesDeUnRol = tl_FuncionalidadesTableAdapter.FuncionalidadesPorRol(this.selectedRol);
                foreach (DataRow row in funcionalidadesDeUnRol)
                {
                    int index = this.listFuncionalidades.FindString(row["Nombre"].ToString(), -1);
                    listFuncionalidades.SetSelected(index, true);
                }
            }
        }

        private void GuardarRol_Click(object sender, EventArgs e)
        {
            if (commons.algunoVacio(listFuncionalidades) ||
                commons.algunoVacio(inputNombre))
            {
                return;
            }
            else
            {
                if (this.selectedRol == -1)
                {
                    int newRolId;
                    newRolId = Convert.ToInt32(this.tl_RolesTableAdapter.InsertAndGetId(inputNombre.Text, Habilitado.Checked).ToString());
                    foreach (DataRowView li in listFuncionalidades.SelectedItems)
                    {
                        this.tl_Roles_FuncionalidadesTableAdapter1.Insert(newRolId, Convert.ToInt32(li["ID"].ToString()));
                    }

                }
                else
                {
                    if (!Habilitado.Checked)
                    {
                        this.tl_Usuarios_RolesTableAdapter1.BorrarPorRol(this.selectedRol);
                    }
                    this.tl_RolesTableAdapter.Update(inputNombre.Text, Habilitado.Checked, this.selectedRol, this.rolName, this.habilitado);
                    this.tl_Roles_FuncionalidadesTableAdapter1.BorrarPorRol(this.selectedRol);
                    foreach (DataRowView li in listFuncionalidades.SelectedItems)
                    {
                        this.tl_Roles_FuncionalidadesTableAdapter1.Insert(this.selectedRol, Convert.ToInt32(li["ID"].ToString()));
                    }
                }
            }
            
            this.Close();
        }
    }
}
