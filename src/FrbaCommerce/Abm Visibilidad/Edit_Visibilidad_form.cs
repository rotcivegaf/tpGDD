using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCommerce;

namespace FrbaCommerce.ABM_Visibilidad
{
    public partial class Edit_Visibilidad_Form : Form
    {
        private int Codigo;
        private Decimal Porcentaje;
        private string Descripcion;
        private string Precio;
        private GD1C2014DataSet.tl_VisibilidadesDataTable visibilidadAEditar;
        
        public Edit_Visibilidad_Form(int codigo)
        {
            this.Codigo = codigo;
            InitializeComponent();
        }

        private void Edit_Visibilidad_Form_Load(object sender, EventArgs e) 
        {
            //Si estamos editando una visibilidad, cargamos sus datos
            if (this.Codigo != -1)
            {
                //Cargamos datos de visibilidad a editar
                this.visibilidadAEditar = this.tl_VisibilidadesTableAdapter1.GetPorCodigo(this.Codigo);
                //Deshabilitamos campo codigo, no se puede editar la PK.
                this.inputCodigo.Enabled = false;
                //Completamos los campos con los datos actuales.
                this.inputCodigo.Text = this.visibilidadAEditar.Rows[0]["Codigo"].ToString();
                this.inputDescripcion.Text = this.visibilidadAEditar.Rows[0]["Descripcion"].ToString();
                this.inputPrecio.Text = this.visibilidadAEditar.Rows[0]["Precio"].ToString();
                this.inputPorcentaje.Text = this.visibilidadAEditar.Rows[0]["Porcentaje"].ToString();
            }
        }

        private bool validar()
        {
            if (!commons.algunoVacio(inputCodigo, inputPorcentaje, inputPrecio, inputDescripcion))
            {
                
                this.Descripcion = inputDescripcion.Text;
                this.Precio = inputPrecio.Text;

                //Validaciones
                try
                {
                    this.Porcentaje = Convert.ToDecimal(inputPorcentaje.Text);
                }
                catch
                {
                    MessageBox.Show("El porcentaje debe ser numerico");
                    return false;
                }
                try
                {
                    this.Codigo = Convert.ToInt32(inputCodigo.Text);
                }
                catch
                {
                    MessageBox.Show("El codigo debe ser un entero positivo.");
                    return false;
                }
                try
                {
                    Convert.ToDecimal(inputPrecio.Text);
                    this.Precio = this.Precio.Replace(',', '.');
                }
                catch
                {
                    MessageBox.Show("El precio debe ser numerico");
                    return false;
                }

                return true;

            } else
            {
                return false;
            }

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //validamos los datos
            if(!this.validar()) return;


            
            //Ejecutamos stored procedure para actualizar/crear la visibilidad, checkeamos si hubo error.
            try
            {
                //Si el input codigo esta habilitado significa que el form se esta uando para altas.
                if (this.inputCodigo.Enabled) 
                {
                    this.tl_VisibilidadesTableAdapter1.sp_NuevaVisibilidad(this.Codigo, this.Descripcion, this.Precio, this.Porcentaje);
                    MessageBox.Show("Creacion exitosa");
                }
                else 
                {
                    this.tl_VisibilidadesTableAdapter1.sp_EditarVisibilidad(this.Codigo, this.Descripcion, Convert.ToDecimal(inputPrecio.Text), this.Porcentaje);
                    MessageBox.Show("Modificacion exitosa");
                }
            }
            catch (SqlException sqEx)
            {
                MessageBox.Show(sqEx.Message);
                return;
            }

            this.Close();
            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            if(this.Codigo == -1) this.inputCodigo.Clear();
            this.inputDescripcion.Clear();
            this.inputPorcentaje.Clear();
            this.inputPrecio.Clear();
        }
    }
}
