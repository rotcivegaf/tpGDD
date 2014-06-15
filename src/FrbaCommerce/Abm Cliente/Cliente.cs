using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Cliente : Form
    {
        bool nuevoCliente;
        bool crearUsuario;
        int ID;

        public Cliente()
        {
            InitializeComponent();
        }

        public void nuevo(int cliente_ID)
        {
            nuevoCliente = true;
            crearUsuario = false;
            ID = cliente_ID;

            this.ShowDialog();
        }

        public void editar(int cliente_ID)
        {
            nuevoCliente = false;
            crearUsuario = false;
            ID = cliente_ID;
            cargarDatos();

            this.ShowDialog();
        }

        public void nuevoByAdmin()
        {
            nuevoCliente = true;
            crearUsuario = true;
            ID = 0;

            this.ShowDialog();
        }

        private void cargarDatos()
        {
            GD1C2014DataSet.tl_ClientesDataTable clienteDataTable = new GD1C2014DataSet.tl_ClientesDataTable();
            clienteDataTable = this.tl_ClientesTableAdapter.getByID(ID);
            DataRow cliente = clienteDataTable.Rows[0];

            txtTipoDocumento.Text = cliente["Tipo_Documento"].ToString();
            numNroDocumento.Value= Convert.ToInt32(cliente["Nro_Documento"].ToString());
            txtApellido.Text = cliente["Apellido"].ToString();
            txtNombre.Text = cliente["Nombre"].ToString();
            txtCUIL.Text = cliente["CUIL"].ToString();
            dateFechaNacimiento.Value = Convert.ToDateTime(cliente["Fecha_Nac"].ToString());//,new System.Globalization.CultureInfo("es-AR", true));
            txtMail.Text = cliente["Mail"].ToString();
            txtCalle.Text = cliente["Dom_Calle"].ToString();
            numNroCalle.Value = Convert.ToInt32(cliente["Nro_Calle"].ToString());
            numPiso.Value = Convert.ToInt32(cliente["Piso"].ToString());
            txtDepto.Text = cliente["Depto"].ToString();
            txtCodigoPostal.Text = cliente["Cod_Postal"].ToString();
            txtTelefono.Text = cliente["Telefono"].ToString();
        }

        private bool faltanCampos()
        {
            //FALTA HACER -> VER QUE CHEQUEE TODO DE UNA
            return commons.algunoVacio(txtTipoDocumento,txtApellido, txtNombre);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (faltanCampos()) return;
            try
            {
                this.tl_ClientesTableAdapter.sp_GuardarCliente(
                   nuevoCliente,
                   crearUsuario ? commons.hash(numNroDocumento.Value.ToString()) : "",
                   ID,
                   txtTipoDocumento.Text,
                   (int)numNroDocumento.Value,
                   txtApellido.Text,
                   txtNombre.Text,
                   txtCUIL.Text,
                   dateFechaNacimiento.Value,
                   txtMail.Text,
                   txtCalle.Text,
                   Convert.ToInt32(numNroCalle.Value),
                   Convert.ToInt32(numPiso.Value),
                   txtDepto.Text,
                   txtCodigoPostal.Text,
                   (txtTelefono.Text == "") ? (int?)null : Convert.ToInt32(txtTelefono.Text)
                   );
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            MessageBox.Show("Cliente Creado");
            this.Close();
        }

    }
}
