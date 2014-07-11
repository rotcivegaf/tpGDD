using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class EditarPublicacion : Form
    {
        private int userID;
        private int rolID;
        int offset = 1;
        int LIMITE = 20;
        int QtyRegistros;

        GD1C2014DataSet.tl_PublicacionesDataTable tablaTemporal = new GD1C2014DataSet.tl_PublicacionesDataTable();
        public EditarPublicacion(int usuario_ID,int rol_ID)
        {
            InitializeComponent();
            userID = usuario_ID;
            rolID = rol_ID;
        }

        /*
        internal void setID(int usuario_ID)
        {
            this.userID = usuario_ID;
        }
        */

        private void EditarPublicacion_Load(object sender, EventArgs e)
        {
            this.publicacionesBindingSource.DataSource = this.publicacionesTableAdapter.GetDataByID(userID);
            //this.tl_PublicacionesTableAdapter.FillByIDAndVisibilidad(tablaTemporal, userID);
            //QtyRegistros = Convert.ToInt32(tablaTemporal.Count);
            //Paginamos esa tabla utilizando el paginador
            //paginar(tablaTemporal);
        }

        private void paginar(GD1C2014DataSet.tl_PublicacionesDataTable unaTabla)
        {
            //Pagino la tabla
            this.tl_PublicacionesDataGridView.DataSource = this.tl_PublicacionesTableAdapter.GetDataByPaginador(offset, LIMITE, unaTabla);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            offset = 1;
            paginar(tablaTemporal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (offset > LIMITE)
                offset -= LIMITE;
            else
                offset = 1;
            paginar(tablaTemporal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (offset <= QtyRegistros - LIMITE)
                offset += LIMITE;
            paginar(tablaTemporal);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            offset = QtyRegistros - LIMITE +1;
            paginar(tablaTemporal);
        }

        private void tl_PublicacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tl_PublicacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gD1C2014DataSet);

        }

        private void tl_PublicacionesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para editar
            if (e.ColumnIndex == 8)
            {
                Generar_Publicacion.Generar_Publicacion_form frame = new Generar_Publicacion.Generar_Publicacion_form();
                frame.setIDs(userID,rolID);
                frame.editPublicidad(Convert.ToInt32(this.tl_PublicacionesDataGridView.Rows[e.RowIndex].Cells[0].Value));
                frame.ShowDialog();
            }
        }
        
    }
}
