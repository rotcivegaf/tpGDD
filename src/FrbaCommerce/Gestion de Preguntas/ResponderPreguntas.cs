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
            llenarPreguntas();

        }

        private void llenarPreguntas()
        {
            this.tlPreguntasBindingSource.DataSource = this.tl_PreguntasTableAdapter.GetParaResponder(UsuarioID);
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
            }
        }

        private void dgvPreguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
