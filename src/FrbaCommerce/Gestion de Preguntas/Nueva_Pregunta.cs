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
    public partial class Nueva_Pregunta : Form
    {
        private int usuarioID;
        private int publicacionCodigo;

        public Nueva_Pregunta()
        {
            InitializeComponent();
        }

        public void abrir(int Usuario_ID, int Publicacion_Codigo)
        {
            usuarioID = Usuario_ID;
            publicacionCodigo = Publicacion_Codigo;

            this.ShowDialog();
        }

        private bool validar()
        {
            return (!(commons.algunoVacio(textBoxPregunta)));
        }

        private void buttonPreguntar_Click(object sender, EventArgs e)
        {
            if (this.validar())
            {
                this.tl_PreguntasTableAdapter.guardarPregunta(publicacionCodigo, textBoxPregunta.Text,usuarioID );
                MessageBox.Show("Pregunta cargada con éxito");
                this.Close();
            }

         }

        private void Nueva_Pregunta_Load(object sender, EventArgs e)
        {

        }
    }
}
