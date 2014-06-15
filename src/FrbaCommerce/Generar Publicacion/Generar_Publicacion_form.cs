using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class Generar_Publicacion_form : Form
    {
        private int? nuevaPublicacionID = -1;

        public Generar_Publicacion_form()
        {
            InitializeComponent();
        }


        private void Publicacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2014DataSet.tl_Publicaciones_Rubros' table. You can move, or remove it, as needed.
            this.tl_Publicaciones_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Publicaciones_Rubros);
           
            //Cargo rubros y visibilidades
            this.tl_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Rubros);
            this.tl_VisibilidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Visibilidades);
            this.tl_Publicaciones_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Publicaciones_Rubros);


            //Selecciono por default
            comboBoxEstadoDeLaPublicacion.SelectedIndex = 0;
            comboBoxTipoDePublicacion.SelectedIndex = 0;
        }

        private bool validar()
        {
            
            return (!(commons.algunoVacio(inputDescripcion) || commons.algunoVacio(listBoxRubro)));
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (this.validar())
            { 
                //En este stored procedure hago un INSERT para las publicidades
                this.tl_PublicacionesTableAdapter.sp_CrearPublicacion(inputDescripcion.Text,
                    dateTimePickerFechaInicio.Value, 
                    Convert.ToDecimal(numericUpDownStock.Value),
                    dateTimePickerFechaVencimiento.Value,
                    Convert.ToDecimal(numericUpDownPrecio.Value),
                    comboBoxTipoDePublicacion.SelectedItem.ToString(),
                    Convert.ToDecimal(comboBoxVisiblidad.SelectedValue),
                    comboBoxEstadoDeLaPublicacion.SelectedItem.ToString(),
                    checkBoxAceptaPreguntas.Checked, ref nuevaPublicacionID);

                //Con el ref tengo el parámetro que me devuelve el SP, en este caso el ID de publicación que voy a usar
                //en la tabla rubros_publicaciones

                //Recorro el listBox y por cada item de tipo DataRowView hago un insert
                foreach (DataRowView item in listBoxRubro.SelectedItems)
                {
                    this.tl_Publicaciones_RubrosTableAdapter.Insert(Convert.ToInt32(nuevaPublicacionID), Convert.ToInt32(item["ID"].ToString()));
                }  
            }
        }

        private void comboBoxVisiblidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            setFechaVencimiento();
        }

        private void setFechaVencimiento()
        {
            
            //Creo un DataSet que es la representación de la tabla
            GD1C2014DataSet.tl_VisibilidadesDataTable visibilidad;
            //A esa tabla le ejecuto una consulta que está en un table adapter
            visibilidad = this.tl_VisibilidadesTableAdapter.GetPorCodigo(Convert.ToDecimal(comboBoxVisiblidad.SelectedValue));
            //A la table que la consulta me devuelve tengo que llamarla como una matriz de la forma tabla[registro][campo]
            int duracion = Convert.ToInt32(visibilidad.Rows[0]["Duracion"]);
            //sumo utilizando una funcion de fechas de C#
            dateTimePickerFechaVencimiento.Value = dateTimePickerFechaInicio.Value.AddDays(duracion);
        }

        private void dateTimePickerFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            setFechaVencimiento();
        }
        

    }
}
