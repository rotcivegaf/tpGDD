using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class ResponderPreguntas : Form
    {
        private int UsuarioID;
        private int PreguntaID;

        public ResponderPreguntas()
        {
            InitializeComponent();
        }

        public void abrir(int userID)
        {
            UsuarioID = userID;

            this.ShowDialog();
        }

        private void Preguntas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2014DataSet.tl_Preguntas' table. You can move, or remove it, as needed.
            llenarPreguntas();

        }

        private void llenarPreguntas()
        {
            this.tl_PreguntasTableAdapter.Fill(this.gD1C2014DataSet.tl_Preguntas);
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (!commons.algunoVacio(txtRespuesta))
            {
                this.tl_PreguntasTableAdapter.guardarRespuesta(txtRespuesta.Text, commons.getDate().ToString(), PreguntaID);
                txtRespuesta.Clear();
                grpRespuesta.Enabled = false;
                dgvPreguntas.Enabled = true;
                llenarPreguntas();



                /*
                this.tl_ComprasTableAdapter.sp_CalificarVendedor(compra_ID, (byte)numCantidadEstrellas.Value, cmbDescripcion.Text);
                numCantidadEstrellas.Value = 0;
                cmbDescripcion.Text = "";
                grpCompras.Enabled = true;
                grpCalificacion.Enabled = false;
                llenarGrid();
                */
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Responder.Index)
            {
                DataGridViewRow fila = dgvPreguntas.Rows[e.RowIndex];
                PreguntaID = Convert.ToInt32(fila.Cells[ID.Index]);
                dgvPreguntas.Enabled = false;
                grpRespuesta.Enabled = true;
                txtRespuesta.Focus();
            }
        }
    }
}
