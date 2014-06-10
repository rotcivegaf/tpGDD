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
        /* Datos del rol en caso de edicion,
         * si se tratara de una creacion estos valores no aplican */
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
            //Cargamos el tableAdapter funcionalidades
            this.tl_FuncionalidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Funcionalidades);
            
            //Si selectedRol no es -1 significa que estamos editando un Rol existente.
            if (this.selectedRol != -1)
            {
                //Llenamos el input y el checkbox con los valores actuales.
                this.inputNombre.Text = this.rolName;
                this.Habilitado.Checked = habilitado;

                /* Creamos un objeto tabla Funcionalidades y lo llenamos con todas
                 * las funcionalidades que tiene actualmente el rol */
                GD1C2014DataSet.tl_FuncionalidadesDataTable funcionalidadesDeUnRol;
                funcionalidadesDeUnRol = tl_FuncionalidadesTableAdapter.FuncionalidadesPorRol(this.selectedRol);

                //Deseleccionamos la opcion que siempre viene activada por defecto.
                listFuncionalidades.SetSelected(0, false);
                
                /* Iteramos sobre las funcionalidades que buscamos en el paso anterior,
                 * y por cada una la buscamos en el ListBox y le cambiamos el estado a
                 * seleccionada, de esta forma reflejamos las funcionalidades que este
                 * rol posee actualmente. */
                foreach (DataRow row in funcionalidadesDeUnRol)
                {
                    int index = this.listFuncionalidades.FindString(row["Nombre"].ToString(), -1);
                    listFuncionalidades.SetSelected(index, true);
                }
            }
        }

        private void GuardarRol_Click(object sender, EventArgs e)
        {
            //Validamos que el rol tenga un nombre y al menos una funcionalidad.
            if (commons.algunoVacio(listFuncionalidades) ||
                commons.algunoVacio(inputNombre))
            {
                return;
            }
            else
            {
                //Si estamos guardando un rol creado...
                if (this.selectedRol == -1)
                {
                    /* Insertamos el rol y en la misma consulta devolvemos el ID de
                     * este nuevo registro. */
                    int newRolId;
                    newRolId = Convert.ToInt32(this.tl_RolesTableAdapter.InsertAndGetId(inputNombre.Text, Habilitado.Checked).ToString());
                    
                    /* Iteramos sobre todas las funcionalidades que se marcaron como
                     * activas y, junto con el ID conseguido antes, insertamos los registros
                     * correspondientes en Roles_Funcionalidades para satifascer la relacion
                     * many to many. */
                    foreach (DataRowView li in listFuncionalidades.SelectedItems)
                    {
                        this.tl_Roles_FuncionalidadesTableAdapter1.Insert(newRolId, Convert.ToInt32(li["ID"].ToString()));
                    }

                }
                //Si estamos guardando un rol existente...
                else
                {
                    
                    //Si se deshabilito el rol, se lo quitamos a los usuarios que lo tenian.
                    if (!Habilitado.Checked)
                    {
                        this.tl_Usuarios_RolesTableAdapter1.BorrarPorRol(this.selectedRol);
                    }

                    //Actualizamos el registro mediante el table adapter Roles.
                    this.tl_RolesTableAdapter.Update(inputNombre.Text, Habilitado.Checked, this.selectedRol, this.rolName, this.habilitado);
                    
                    /* Borramos todos los registros que existian en Roles_Funcionalidades
                     * y los volvemos a crear con la nueva informacion */
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
