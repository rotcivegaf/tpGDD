﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class Generar_Publicacion_form : Form
    {
        GD1C2014DataSet.tl_PublicacionesDataTable publicacionAEditar;
        private int? nuevaPublicacionID = -1;
        private int userID;
        private int rolID;
        private int publicacionID;
        private int edicion = 0;

        public Generar_Publicacion_form()
        {
            InitializeComponent();
        }

        public void generarPublicacion(int user_ID, int rol_ID)
        {
            this.userID = user_ID;
            this.rolID = rol_ID;

            this.ShowDialog();
        }

        public void editarPublicacion (int user_ID, int rol_ID, int publicacionID)
        {
            this.userID = user_ID;
            this.rolID = rol_ID; 
            this.publicacionID = publicacionID;
            edicion = 1;

            this.ShowDialog();
        }

        private void Publicacion_Load(object sender, EventArgs e)
        {
            //Cargo Rubros, Visibilidades, Tipos y Estados
            this.tl_RubrosTableAdapter.FillWithHabilitados(this.gD1C2014DataSet.tl_Rubros);
            this.tl_VisibilidadesTableAdapter.FillWithHabilitadas(this.gD1C2014DataSet.tl_Visibilidades);
            this.tl_Publicacion_TiposTableAdapter.FillWithHabilitados(this.gD1C2014DataSet.tl_Publicacion_Tipos);
            this.tl_Publicacion_EstadosTableAdapter.FillWithHabilitados(this.gD1C2014DataSet.tl_Publicacion_Estados);
            //Si voy a editar una publicación ya existente
            if (edicion == 1)
            {
                //cargo los datos en el formulario
                cargarDatos();
                switch (Convert.ToInt32(publicacionAEditar.Rows[0]["Estado_ID"]))
                {
                    case 1: //Publicada
                        //Deshabilito los campos que no se pueden editar según los requerimientos
                        this.dateTimePickerFechaInicio.Enabled = false;
                        this.dateTimePickerFechaVencimiento.Enabled = false;
                        this.numericUpDownPrecio.Enabled = false;
                        this.listBoxRubro.Enabled = false;
                        this.comboBoxVisiblidad.Enabled = false;
                        this.comboBoxTipoDePublicacion.Enabled = false;
                        this.checkBoxAceptaPreguntas.Enabled = false;
                        this.numericUpDownStock.Minimum = Convert.ToInt32(publicacionAEditar.Rows[0]["Stock"]);
                        break;
                    case 2: //Pausada
                        //Deshabilito los campos que no se pueden editar según los requerimientos
                        this.inputDescripcion.Enabled = false;
                        this.numericUpDownStock.Enabled = false;
                        this.dateTimePickerFechaInicio.Enabled = false;
                        this.dateTimePickerFechaVencimiento.Enabled = false;
                        this.numericUpDownPrecio.Enabled = false;
                        this.listBoxRubro.Enabled = false;
                        this.comboBoxVisiblidad.Enabled = false;
                        this.comboBoxTipoDePublicacion.Enabled = false;
                        this.checkBoxAceptaPreguntas.Enabled = false;
                        break;
                    case 3: //Borrador
                        if (DateTime.Compare(dateTimePickerFechaInicio.Value, commons.getDate()) < 0)
                        {
                            dateTimePickerFechaInicio.Value = commons.getDate();            
                        }
                        dateTimePickerFechaInicio.MinDate = commons.getDate();
                        comboBoxVisiblidad.Enabled = false;
                        break;

                    case 4: //Finalizada
                        //Deshabilito los campos que no se pueden editar según los requerimientos
                        this.inputDescripcion.Enabled = false;
                        this.numericUpDownStock.Enabled = false;
                        this.dateTimePickerFechaInicio.Enabled = false;
                        this.dateTimePickerFechaVencimiento.Enabled = false;
                        this.numericUpDownPrecio.Enabled = false;
                        this.listBoxRubro.Enabled = false;
                        this.comboBoxVisiblidad.Enabled = false;
                        this.comboBoxTipoDePublicacion.Enabled = false;
                        this.checkBoxAceptaPreguntas.Enabled = false;
                        this.comboBoxEstadoDeLaPublicacion.Enabled = false;
                        this.Guardar.Enabled = false;
                        break;
                    default:
                        break;
                }
                //Si la publicación es de tipo subasta no se permite modificación de stock alguna
                if (Convert.ToInt32(publicacionAEditar.Rows[0]["Tipo_ID"]) == 2 && !esBorrador())
                {
                    this.numericUpDownStock.Enabled = false;
                }
            }
            else //Nueva Publicacion
            { 
                //Selecciono por default
                dateTimePickerFechaInicio.MinDate = commons.getDate();
                dateTimePickerFechaInicio.Value = commons.getDate();
            }
        }

        private void cargarDatos()
        {
            //Cargo el data table con los datos de la publicación a editar
            publicacionAEditar = this.tl_PublicacionesTableAdapter.getByCodigo(publicacionID);
            //Completo el form con los valores de la publicación
            this.inputDescripcion.Text = publicacionAEditar.Rows[0]["Descripcion"].ToString();
            if (Convert.ToInt32(publicacionAEditar.Rows[0]["Stock"]) == 0)
            {
                numericUpDownStock.Minimum = 0;
            }
            this.numericUpDownStock.Value = Convert.ToInt32(publicacionAEditar.Rows[0]["Stock"]);
            this.dateTimePickerFechaInicio.Value = Convert.ToDateTime(publicacionAEditar.Rows[0]["Fecha"]);
            this.dateTimePickerFechaVencimiento.Value = Convert.ToDateTime(publicacionAEditar.Rows[0]["Fecha_Vencimiento"]);
            this.numericUpDownPrecio.Value = Convert.ToDecimal(publicacionAEditar.Rows[0]["Precio"]);
            //RUBROS
            GD1C2014DataSet.tl_Publicaciones_RubrosDataTable rubros = new GD1C2014DataSet.tl_Publicaciones_RubrosDataTable();
            rubros = this.tl_Publicaciones_RubrosTableAdapter.getDataByPublicacionCodigo(this.publicacionID);
            foreach (GD1C2014DataSet.tl_Publicaciones_RubrosRow rubro in rubros.Rows)
            {
                listBoxRubro.SelectedValue = Convert.ToInt32(rubro["Rubro_ID"].ToString());
                listBoxRubro.SetSelected(listBoxRubro.SelectedIndex, true);
            }
            this.comboBoxVisiblidad.SelectedValue = Convert.ToInt32(publicacionAEditar.Rows[0]["Visibilidad_Codigo"]);
            this.comboBoxTipoDePublicacion.SelectedValue = Convert.ToInt32(publicacionAEditar.Rows[0]["Tipo_ID"]);
            this.comboBoxEstadoDeLaPublicacion.SelectedValue = Convert.ToInt32(publicacionAEditar.Rows[0]["Estado_ID"]);
            this.checkBoxAceptaPreguntas.Checked = Convert.ToBoolean(publicacionAEditar.Rows[0]["Permite_Preguntas"]);
        }

        private bool validar()
        {
            
            return (!(commons.algunoVacio(inputDescripcion) || commons.algunoVacio(listBoxRubro)));
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            this.tl_Publicaciones_RubrosTableAdapter.Fill(this.gD1C2014DataSet.tl_Publicaciones_Rubros);
            //Si pasa la validación
            if (this.validar())
            {
                if (edicion == 0) //Es una Nueva Publicacion
                {
                    try
                    {
                        nuevaPublicacion();
                        Guardar.Enabled = false; //LO DESHABILITO ASI NO SE PUEDE APRETAR DE NUEVO
                    }
                    catch (SqlException sqlE)
                    {
                        MessageBox.Show(sqlE.Message);
                    }
                }
                else
                    //Caso contrario ejecuto el método editarPublicación
                    editarPublicacion();
            }
        }

        private void editarPublicacion()
        {
            //Si se quiere cambiar el estado de una publicación a Borrador
            if (this.comboBoxEstadoDeLaPublicacion.Text.Equals("Borrador") && (esPublicada() || esPausada() || esFinalizada()))
                MessageBox.Show("No se puede cambiar el estado a borrador");
            else
                {
                    //Edición en la tabla de publicaciones
                    this.tl_PublicacionesTableAdapter.sp_EditarPublicacion(publicacionID,
                        inputDescripcion.Text,
                        dateTimePickerFechaInicio.Value,
                        Convert.ToDecimal(numericUpDownStock.Value),
                        dateTimePickerFechaVencimiento.Value,
                        Convert.ToDecimal(numericUpDownPrecio.Value),
                        Convert.ToInt32(comboBoxTipoDePublicacion.SelectedValue),
                        Convert.ToDecimal(comboBoxVisiblidad.SelectedValue),
                        Convert.ToInt32(comboBoxEstadoDeLaPublicacion.SelectedValue),
                        checkBoxAceptaPreguntas.Checked);
                    //Solamente en el caso de borrador voy a poder editar los rubros, por lo tanto...
                    if (esBorrador())
                    {
                        //Borro los antiguos registros de la tabla de relaciones de rubros y publicaciones
                        this.tl_Publicaciones_RubrosTableAdapter.DeletePorPublicacion(this.publicacionID);
                        //Agrego los nuevos rubros a la tabla de relaciones
                        foreach (DataRowView item in listBoxRubro.SelectedItems)
                        {
                            this.tl_Publicaciones_RubrosTableAdapter.Insert(Convert.ToInt32(this.publicacionID), Convert.ToInt32(item["ID"].ToString()));
                        }    
                    }
                    MessageBox.Show("Edición de publicación exitosa");
                    //SP para modificar la publicación
                }
        }
        
        private bool esPublicada()
        {
            return Convert.ToInt32(publicacionAEditar.Rows[0]["Estado_ID"]) == 1;
        }

        private bool esPausada()
        {
            return Convert.ToInt32(publicacionAEditar.Rows[0]["Estado_ID"]) == 2;
        }

        private bool esBorrador()
        {
            return Convert.ToInt32(publicacionAEditar.Rows[0]["Estado_ID"]) == 3;
        }
        
        private bool esFinalizada()
        {
            return Convert.ToInt32(publicacionAEditar.Rows[0]["Estado_ID"]) == 4;
        }

        private void nuevaPublicacion()
        {
            if (!(comboBoxEstadoDeLaPublicacion.Text.Equals("Finalizada")))
            {
                this.tl_PublicacionesTableAdapter.sp_CrearPublicacion(this.userID, inputDescripcion.Text,
                    dateTimePickerFechaInicio.Value,
                    Convert.ToDecimal(numericUpDownStock.Value),
                    dateTimePickerFechaVencimiento.Value,
                    Convert.ToDecimal(numericUpDownPrecio.Value),
                    Convert.ToInt32(comboBoxTipoDePublicacion.SelectedValue),
                    Convert.ToDecimal(comboBoxVisiblidad.SelectedValue),
                    Convert.ToInt32(comboBoxEstadoDeLaPublicacion.SelectedValue),
                    checkBoxAceptaPreguntas.Checked, commons.getDate(), ref nuevaPublicacionID);
                //Con el ref tengo el parámetro que me devuelve el SP, en este caso el ID de publicación que voy a usar
                //en la tabla rubros_publicaciones

                //Hago las entradas correspondientes en la tabla de relaciones entre publicaciones y rubros
                foreach (DataRowView item in listBoxRubro.SelectedItems)
                {
                    this.tl_Publicaciones_RubrosTableAdapter.Insert(Convert.ToInt32(nuevaPublicacionID), Convert.ToInt32(item["ID"].ToString()));
                }
                MessageBox.Show("Publicación creada exitosamente");
            }
            else
                MessageBox.Show("No se puede crear una publicación como finalizada");
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

        private void comboBoxTipoDePublicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTipoDePublicacion.Text)
            {
                case "Compra Inmediata":
                    numericUpDownStock.Enabled = true;
                    break;
                case "Subasta":
                    numericUpDownStock.Value = 1;
                    numericUpDownStock.Enabled = false;
                    break;
            }
        }
    }
}
