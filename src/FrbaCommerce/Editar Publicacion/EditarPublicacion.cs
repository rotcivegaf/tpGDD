using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Generar_Publicacion;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class EditarPublicacion : Form
    {
        private int userID;
        private int rolID;
        int offset = 1;
        int LIMITE;
        int QtyRegistros;

        GD1C2014DataSet.tl_PublicacionesDataTable tablaTemporal = new GD1C2014DataSet.tl_PublicacionesDataTable();
        public EditarPublicacion()
        {
            InitializeComponent();
        }

        public void abrir(int usuario_ID, int rol_ID)
        {
            userID = usuario_ID;
            rolID = rol_ID;

            this.ShowDialog();
        }

        private void EditarPublicacion_Load(object sender, EventArgs e)
        {
            cmbCantidadRegistros.SelectedIndex = 0;
            llenarPublicaciones();
        }

        private void llenarPublicaciones()
        {
            int? TotalRegistros = 0;

            this.publicacionesBindingSource.DataSource =
                this.publicacionesTableAdapter.getParaEditar(userID, offset, LIMITE, ref TotalRegistros);

            QtyRegistros = (int)TotalRegistros;
        }

        private void buttonPrincipio_Click(object sender, EventArgs e)
        {
            offset = 1;
            llenarPublicaciones();
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (offset > LIMITE)
                offset -= LIMITE;
            else
                offset = 1;
            llenarPublicaciones();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (offset <= QtyRegistros - LIMITE)
            {
                offset += LIMITE;
                llenarPublicaciones();
            }
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            
            offset = QtyRegistros - LIMITE +1;
            llenarPublicaciones();

        }

        private void tl_PublicacionesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para editar
            if (e.ColumnIndex == Editar.Index && e.RowIndex >= 0)
            {
                DataGridViewRow fila = this.tl_PublicacionesDataGridView.Rows[e.RowIndex];
                Generar_Publicacion_form frame = new Generar_Publicacion_form();
                frame.editarPublicacion(userID,rolID,Convert.ToInt32(fila.Cells[Codigo.Index].Value));
                llenarPublicaciones();
            }
        }

        private void cmbCantidadRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            LIMITE = Convert.ToInt32(cmbCantidadRegistros.Text);
        }
    }
}
