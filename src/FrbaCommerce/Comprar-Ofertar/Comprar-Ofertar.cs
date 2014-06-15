using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Comprar_Ofertar : Form
    {
        private int UserID;
        int offset = 0;
        int LIMITE = 20;

        public Comprar_Ofertar()
        {
            InitializeComponent();
        }

        public void setID(int user_ID)
        {
            UserID = user_ID;
        }

        private void tl_PublicacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tl_PublicacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gD1C2014DataSet);

        }

        private void Comprar_Ofertar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2014DataSet.tl_Rubros' table. You can move, or remove it, as needed.
            this.tl_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Rubros);
            
        }

        private bool validar()
        {

            return (!(commons.algunoVacio(textBoxDescripcion) ));

        }

        private void buttonBuscarPublicacion_Click(object sender, EventArgs e)
        {
            this.tl_Publicaciones_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Publicaciones_Rubros);
    //FALTA VER LO DE LAS CONDICIONES QUE SE FILTRE POR UNA O POR OTRA
            String condicion = "";
            if (this.validar())
            {
                condicion += "Descripcion LIKE '%" + textBoxDescripcion.Text + "%'";
                if (comboBoxRubros.SelectedText != "")
                    condicion += " AND Rubro_ID = " + comboBoxRubros.SelectedValue;
                
                llenarTabla();
            }
        }

        private void llenarTabla()
        {

            GD1C2014DataSetTableAdapters.tl_PublicacionesTableAdapter table = new GD1C2014DataSetTableAdapters.tl_PublicacionesTableAdapter();

            table.FillByDescripcionYRubro(this.gD1C2014DataSet.tl_Publicaciones, armarLike(textBoxDescripcion.Text), Convert.ToInt32(comboBoxRubros.SelectedValue));
            
            table.FillByPaginador(table.GetData(), offset, LIMITE);
            //this.tl_PublicacionesTableAdapter = table;

            this.tl_PublicacionesTableAdapter.Fill(table.GetData());

            //this.tl_PublicacionesTableAdapter.FillByPaginador(this.gD1C2014DataSet.tl_Publicaciones,offset, LIMITE);
        }

        private string armarLike(string descripcion)
        {
            //La consulta del where es LIKE %Descripcion%
            return "%"+textBoxDescripcion.Text.ToString()+"%";
        }

        private void dataGridViewPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si quiero hacer una pregunta
            if (e.ColumnIndex == 8)
            {
                //Cargo en una fila (DataGridViewRow) el registro deseado
                DataGridViewRow fila = dataGridViewPublicaciones.Rows[e.RowIndex];
                //Pregunto si puede preguntar && valido que no sea una auto-pregunta
                if (Convert.ToBoolean(fila.Cells[7].Value) &&  ( !mismoCliente(fila) ))
                {
                    //Creo un formulario de nueva pregunta y le mando el ID de la publicación para cargarlo en la tabla
                    Gestion_de_Preguntas.Nueva_Pregunta frame = new Gestion_de_Preguntas.Nueva_Pregunta();
                    frame.setIDPublicacion(Convert.ToInt32(fila.Cells[0].Value));
                    frame.ShowDialog();
                }
            }
            //si quiero hacer una compra
            if (e.ColumnIndex == 9)
            {
                //Cargo en una fila (DataGridViewRow) el registro deseado
                DataGridViewRow fila = dataGridViewPublicaciones.Rows[e.RowIndex];
                //Verifico que no me quiera auto-comprar
                if (!mismoCliente(fila))
                {
                    
                }
            }
        }




        private bool mismoCliente(DataGridViewRow registro)
        { 
            if (registro.Cells[10].Equals(DBNull.Value))
                return (Convert.ToInt32(registro.Cells[11].Value) == this.UserID);
            else
                return (Convert.ToInt32(registro.Cells[10].Value) == this.UserID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            offset = 0;
            llenarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            offset -= LIMITE;
            llenarTabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            offset += LIMITE;
            llenarTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            offset = Convert.ToInt32(this.tl_PublicacionesTableAdapter.qtyRegistros()) - LIMITE;
            llenarTabla();
        }
    }
}
