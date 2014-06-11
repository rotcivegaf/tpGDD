using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.ABM_Visibilidad
{
    public partial class ABM_Visibilidad_Form : Form
    {
        public ABM_Visibilidad_Form()
        {
            InitializeComponent();
        }

        private void ABM_Visibilidad_Form_Load(object sender, EventArgs e)
        {
            this.tl_VisibilidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Visibilidades);

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Edit_Visibilidad_Form editForm = new Edit_Visibilidad_Form();
            editForm.FormClosed += new FormClosedEventHandler(editForm_FormClosed);
            
            //Mostramos el formulario.
            editForm.ShowDialog(); 
        }

        private void editForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tl_VisibilidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Visibilidades);
        }

        private void Visibilidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se presiono el boton eliminar
            if (e.ColumnIndex == 5)
            {
                //Intentamos borrarla.
                try
                {
                    this.tl_VisibilidadesTableAdapter.sp_BorrarVisibilidad(Convert.ToInt32(Visibilidades.Rows[e.RowIndex].Cells[0].Value));
                }
                catch (SqlException sqEx)
                {
                    MessageBox.Show(sqEx.Message);
                    return;
                }
                
                //Si se pudo eliminar, refrescamos el grid.
                this.tl_VisibilidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Visibilidades);
            }
            
            //Se presiono el boton seleccionar
            if (e.ColumnIndex == 4)
            {
               
            }
        }

    }
}
