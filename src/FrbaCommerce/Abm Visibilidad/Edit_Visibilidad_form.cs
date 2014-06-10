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
                bool ok = true;
                try
                {
                    
                    int codigo = Convert.ToInt32(inputCodigo.Text);
                    string descripcion = inputDescripcion.Text;
                    string precio = inputPrecio.Text;
                    Decimal porcentaje = Convert.ToDecimal(inputPorcentaje.Text);
                    this.tl_VisibilidadesTableAdapter1.sp_NuevaVisibilidad(codigo, descripcion, precio, porcentaje);
                }
                catch (SqlException sqEx)
                {
                    ok = false;
                    MessageBox.Show(sqEx.Message);
                }
                if (ok)
                {
                    this.Close();
                }
                
            }
        }
    }
}
