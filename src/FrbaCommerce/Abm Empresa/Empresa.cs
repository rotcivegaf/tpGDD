using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Empresa : Form
    {
        bool nuevaEmpresa;
        bool crearUsuario;
        int ID;
        bool guardada = false;

        public Empresa()
        {
            InitializeComponent();
        }

        public void nueva(int empresa_ID)
        {
            nuevaEmpresa = true;
            crearUsuario = false;
            ID = empresa_ID;

            this.ShowDialog();
        }

        public bool editar(int empresa_ID)
        {
            nuevaEmpresa = false;
            crearUsuario = false;
            ID = empresa_ID;
            cargarDatos();
            this.ShowDialog();

            return guardada;
        }

        public bool nuevaByAdmin()
        {
            nuevaEmpresa = true;
            crearUsuario = true;
            ID = 0;
            this.ShowDialog();

            return guardada;
        }

        public void ver(int empresa_ID)
        {
            ID = empresa_ID;
            btnGuardar.Visible = false;
            cargarDatos();

            this.ShowDialog();
        }

        private void cargarDatos()
        {
            GD1C2014DataSet.tl_EmpresasDataTable empresaDeTabla = new GD1C2014DataSet.tl_EmpresasDataTable();
            empresaDeTabla = this.tl_EmpresasTableAdapter.getByID(ID);
            DataRow empresa = empresaDeTabla.Rows[0];

            txtRazonSocial.Text = empresa["Razon_Social"].ToString();
            txtCUIT.Text = empresa["CUIT"].ToString();
            dateFechaCreacion.Value = Convert.ToDateTime(empresa["Fecha_Creacion"].ToString());//,new System.Globalization.CultureInfo("es-AR", true));
            txtMail.Text = empresa["Mail"].ToString();
            txtCalle.Text = empresa["Dom_Calle"].ToString();
            numNroCalle.Value = Convert.ToInt32(empresa["Nro_Calle"].ToString());
            numPiso.Value = Convert.ToInt32(empresa["Piso"].ToString());
            txtDepto.Text = empresa["Depto"].ToString();
            txtCodigoPostal.Text = empresa["Cod_Postal"].ToString();
        }

        private bool faltanCampos()
        {
            bool algunoVacio = commons.algunoVacio(txtRazonSocial, txtCUIT, txtMail, txtCalle, txtDepto, txtCodigoPostal);
            algunoVacio |= commons.algunoVacio(numNroCalle, numPiso); 

            return algunoVacio;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (faltanCampos()) return;
            try
            {
                this.tl_EmpresasTableAdapter.sp_GuardarEmpresa(
                   nuevaEmpresa,
                   crearUsuario ? commons.hash(txtCUIT.Text) : "",
                   ID,
                   txtRazonSocial.Text,
                   txtCUIT.Text,
                   dateFechaCreacion.Value,
                   txtMail.Text,
                   txtCalle.Text,
                   Convert.ToInt32(numNroCalle.Value),
                   Convert.ToInt32(numPiso.Value),
                   txtDepto.Text,
                   txtCodigoPostal.Text,
                   true
                   );
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            MessageBox.Show("Empresa Guardada");
            guardada = true;
            this.Close();
        }
    }
}
