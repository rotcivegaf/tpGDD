﻿using System;
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
        GD1C2014DataSet.tl_PublicacionesDataTable publicacionAEditar;
        private int? nuevaPublicacionID = -1;
        //HARDCODEADO
        //HARDCODEADO
        //HARDCODEADO
        //HARDCODEADO
        //HARDCODEADO
        private int userID=70;
        //HARDCODEADO
        //HARDCODEADO
        //HARDCODEADO
        //HARDCODEADO
        //HARDCODEADO
        private int publicacionID;
        private int edicion=0;
        public Generar_Publicacion_form()
        {
            InitializeComponent();
        }
        public void setID(int userID)
        {
            this.userID = userID;
        }
        public void editPublicidad (int publicacionID)
        {
            this.publicacionID = publicacionID;
            edicion = 1;
        }
        private void Publicacion_Load(object sender, EventArgs e)
        {
            
            //Cargo rubros y visibilidades
            this.tl_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Rubros);
            this.tl_VisibilidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Visibilidades);
            //Selecciono por default
            comboBoxEstadoDeLaPublicacion.SelectedIndex = 0;
            comboBoxTipoDePublicacion.SelectedIndex = 0;
            setFechaVencimiento();
            //Si voy a editar una publicación ya existente cargo los datos en el formulario
            if (edicion == 1)
            { 
                //Cargo el data table con los datos de la publicación a editar
                publicacionAEditar = this.tl_PublicacionesTableAdapter.GetDataByCode(publicacionID);
                //Completo el form con los valores de la publicación
                this.inputDescripcion.Text = publicacionAEditar.Rows[0]["Descripcion"].ToString();
                this.numericUpDownStock.Value = Convert.ToInt32(publicacionAEditar.Rows[0]["Stock"]);
                this.dateTimePickerFechaInicio.Value =Convert.ToDateTime(publicacionAEditar.Rows[0]["Fecha"]);
                this.dateTimePickerFechaVencimiento.Value = Convert.ToDateTime(publicacionAEditar.Rows[0]["Fecha_Vencimiento"]);
                this.numericUpDownPrecio.Value = Convert.ToInt32(publicacionAEditar.Rows[0]["Precio"]);
                this.comboBoxVisiblidad.SelectedValue = Convert.ToInt32(publicacionAEditar.Rows[0]["Visibilidad_Codigo"]);
                this.comboBoxTipoDePublicacion.ValueMember = publicacionAEditar.Rows[0]["Tipo"].ToString();
                this.comboBoxEstadoDeLaPublicacion.ValueMember = publicacionAEditar.Rows[0]["Estado"].ToString();
                this.checkBoxAceptaPreguntas.Enabled =Convert.ToBoolean(publicacionAEditar.Rows[0]["Permite_Preguntas"]);
            }
        }

        private bool validar()
        {
            
            return (!(commons.algunoVacio(inputDescripcion) || commons.algunoVacio(listBoxRubro)));
            
        }
        //Me fijo si el ID de usuario pertenece a una empresa o a un cliente
        private bool esEmpresa(int ID)
        {
            int cantidad = Convert.ToInt32(this.tl_ClientesTableAdapter1.CountPorID(ID));
            return cantidad == 0;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            this.tl_Publicaciones_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Publicaciones_Rubros);
            //Si pasa la validación
            if (this.validar())
            {
                //Y si no es un registro nuevo entonces ejecuto el método nuevaPublicación
                if (edicion == 0)
                    nuevaPublicacion();
                else
                    //Caso contrario ejecuto el método editarPublicación
                    editarPublicacion();
            }
        }

        private void editarPublicacion()
        { 
            
        }

        private void nuevaPublicacion()
        {
            if (esEmpresa(this.userID))
            {
                //En este stored procedure hago un INSERT para las publicaciones
                //Insertando el ID de el cliente particular
                this.tl_PublicacionesTableAdapter.sp_CrearPublicacion(null, this.userID, inputDescripcion.Text,
                dateTimePickerFechaInicio.Value,
                Convert.ToDecimal(numericUpDownStock.Value),
                dateTimePickerFechaVencimiento.Value,
                Convert.ToDecimal(numericUpDownPrecio.Value),
                comboBoxTipoDePublicacion.SelectedItem.ToString(),
                Convert.ToDecimal(comboBoxVisiblidad.SelectedValue),
                comboBoxEstadoDeLaPublicacion.SelectedItem.ToString(),
                checkBoxAceptaPreguntas.Checked, ref nuevaPublicacionID, commons.getDate()
                , Convert.ToInt32(this.tl_VisibilidadesTableAdapter1.PrecioVisibilidadQuery(Convert.ToInt32(comboBoxVisiblidad.SelectedValue))));
                //Con el ref tengo el parámetro que me devuelve el SP, en este caso el ID de publicación que voy a usar
                //en la tabla rubros_publicaciones
                //Recorro el listBox y por cada item de tipo DataRowView hago un insert
            }
            else
            {
                //En este stored procedure hago un INSERT para las publicaciones
                //Insertando el ID de la empresa
                this.tl_PublicacionesTableAdapter.sp_CrearPublicacion(this.userID, null, inputDescripcion.Text,
                dateTimePickerFechaInicio.Value,
                Convert.ToDecimal(numericUpDownStock.Value),
                dateTimePickerFechaVencimiento.Value,
                Convert.ToDecimal(numericUpDownPrecio.Value),
                comboBoxTipoDePublicacion.SelectedItem.ToString(),
                Convert.ToDecimal(comboBoxVisiblidad.SelectedValue),
                comboBoxEstadoDeLaPublicacion.SelectedItem.ToString(),
                checkBoxAceptaPreguntas.Checked, ref nuevaPublicacionID, commons.getDate()
                , Convert.ToInt32(this.tl_VisibilidadesTableAdapter1.PrecioVisibilidadQuery(Convert.ToInt32(comboBoxVisiblidad.SelectedValue))));
                //Con el ref tengo el parámetro que me devuelve el SP, en este caso el ID de publicación que voy a usar
                //en la tabla rubros_publicaciones
                //Recorro el listBox y por cada item de tipo DataRowView hago un insert
            }
            //HAgo las entradas correspondientes en la tabla de relaciones entre publicaciones y rubros
            foreach (DataRowView item in listBoxRubro.SelectedItems)
            {
                this.tl_Publicaciones_RubrosTableAdapter.Insert(Convert.ToInt32(nuevaPublicacionID), Convert.ToInt32(item["ID"].ToString()));
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
