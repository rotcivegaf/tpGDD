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
        private int idPublicacion;

        public Nueva_Pregunta()
        {
            InitializeComponent();
        }

        public void setIDPublicacion (int ID)
        {
            this.idPublicacion = ID;
        }

        private bool validar()

        {
            return (!(commons.algunoVacio(textBoxPregunta)));
        }

        private void buttonPreguntar_Click(object sender, EventArgs e)
        {
            if (this.validar())
            {
                this.tl_PreguntasTableAdapter.Insert(idPublicacion, 0, textBoxPregunta.Text, null, null);
                MessageBox.Show("Pregunta cargada con éxito");
            }

         }

        private void tl_PreguntasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tl_PreguntasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gD1C2014DataSet);

        }

        private void Nueva_Pregunta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2014DataSet.tl_Preguntas' table. You can move, or remove it, as needed.
            this.tl_PreguntasTableAdapter.Fill(this.gD1C2014DataSet.tl_Preguntas);

        }
    }
}
