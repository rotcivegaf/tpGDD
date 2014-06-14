using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Comprar_Ofertar : Form
    {
        public Comprar_Ofertar()
        {
            InitializeComponent();
        }

        private void tl_PublicacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tl_PublicacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gD1C2014DataSet);

        }

        private void Comprar_Ofertar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2014DataSet.tl_Publicaciones_Rubros' table. You can move, or remove it, as needed.
            this.tl_Publicaciones_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Publicaciones_Rubros);
            // TODO: This line of code loads data into the 'gD1C2014DataSet.tl_Rubros' table. You can move, or remove it, as needed.
            this.tl_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Rubros);

        }

        private bool validar()
        {

            return (!(commons.algunoVacio(textBoxDescripcion) ));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String condicion = "";
            if (this.validar())
            {
                condicion += "Descripcion LIKE '%" + textBoxDescripcion.Text + "%'";
                if (comboBoxRubros.SelectedText != "")
                    condicion += " AND Rubro_ID = " + comboBoxRubros.SelectedValue;

                //this.tl_PublicacionesTableAdapter.FillByCondition(


                //Llenamos el table adapter que es el source del Data Grid View (binding source) con la consulta filtrada
                this.tl_PublicacionesTableAdapter.FillByDescripcionYRubro(this.gD1C2014DataSet.tl_Publicaciones, armarLike(textBoxDescripcion.Text),Convert.ToInt32(comboBoxRubros.SelectedValue));
            }
        }

        private string armarLike(string descripcion)
        {
            //La consulta del where es LIKE %Descripcion%
            return "%"+textBoxDescripcion.Text.ToString()+"%";
        }

        private void dataGridViewPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                DataGridViewRow fila = dataGridViewPublicaciones.Rows[e.RowIndex];
                if (Convert.ToBoolean (fila.Cells[7].Value))
                {
                    Gestion_de_Preguntas.Nueva_Pregunta frame = new Gestion_de_Preguntas.Nueva_Pregunta();
                    //MessageBox.Show(fila.Cells[0].Value.ToString());
                    frame.setIDPublicacion(Convert.ToInt32(fila.Cells[0].Value));
                    frame.ShowDialog();
                }
            }
        }

        
    }
}
