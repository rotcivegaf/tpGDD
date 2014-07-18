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
            llenarVisibilidades();
        }

        private void llenarVisibilidades()
        {
            this.tl_VisibilidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Visibilidades);
        }

        private void Visibilidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == Deshabilitar.Index)//Se presiono el boton Deshabilitar
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
                    MessageBox.Show("Visibilidad Deshabilitada");
                    //Si se pudo Deshabilitar, refrescamos el grid.
                    llenarVisibilidades();
                } else if (e.ColumnIndex == seleccionar.Index) //Se presiono el boton seleccionar
                {
                    //Pasamos como parametro el codigo de visibiiad a editar.
                    Edit_Visibilidad_Form editForm = new Edit_Visibilidad_Form(Convert.ToInt32(Visibilidades.Rows[e.RowIndex].Cells[0].Value));
                    //Mostramos el formulario.
                    editForm.ShowDialog();
                    llenarVisibilidades();
                }
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optNueva_Click(object sender, EventArgs e)
        {
            //Pasamos como parametro -1 porque estamos creando una visibilidad.
            Edit_Visibilidad_Form editForm = new Edit_Visibilidad_Form(-1);
            editForm.ShowDialog();
            llenarVisibilidades();
        }

    }
}
