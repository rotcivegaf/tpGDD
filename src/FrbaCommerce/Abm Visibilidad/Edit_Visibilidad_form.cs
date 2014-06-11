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
        public Edit_Visibilidad_Form()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (!commons.algunoVacio(inputCodigo, inputPorcentaje, inputPrecio, inputDescripcion))
            {
                Decimal porcentaje;
                int codigo;
                string descripcion = inputDescripcion.Text;
                string precio = inputPrecio.Text;

                //Validaciones
                try
                {
                    porcentaje = Convert.ToDecimal(inputPorcentaje.Text);
                }
                catch
                {
                    MessageBox.Show("El porcentaje debe ser numerico");
                    return;
                }
                try 
                {
                    codigo = Convert.ToInt32(inputCodigo.Text);
                }
                catch 
                {
                    MessageBox.Show("El codigo debe ser numerico");
                    return;
                }
                try 
                {
                    Convert.ToDecimal(inputPrecio.Text);
                }
                catch 
                {
                    MessageBox.Show("El precio debe ser numerico");
                    return;
                }
                 
                //Ejecutamos stored procedure para dar de alta visibilidad, checkeamos si hubo error.
                try
                {
                    this.tl_VisibilidadesTableAdapter1.sp_NuevaVisibilidad(codigo, descripcion, precio, porcentaje);
                }
                catch (SqlException sqEx)
                {
                    MessageBox.Show(sqEx.Message);
                    return;
                }
                
                this.Close();
                
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.inputDescripcion.Clear();
            this.inputCodigo.Clear();
            this.inputPorcentaje.Clear();
            this.inputPrecio.Clear();
        }
    }
}
