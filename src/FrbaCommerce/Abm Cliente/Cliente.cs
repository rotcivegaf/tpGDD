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
        bool guardado = false;
        bool allowClosing = true;

        public Cliente()
        {
            InitializeComponent();
        }

        public void nuevo(int cliente_ID)
        {
            nuevoCliente = true;
            crearUsuario = false;
            ID = cliente_ID;
            allowClosing = false;

            this.ShowDialog();
        }

        public bool editar(int cliente_ID)
        {
            nuevoCliente = false;
            crearUsuario = false;
            ID = cliente_ID;
            cargarDatos();
            this.ShowDialog();

            return guardado;
        }

        public bool nuevoByAdmin()
        {
            nuevoCliente = true;
            crearUsuario = true;
            ID = 0;
            this.ShowDialog();

            return guardado;
        }

        public bool editarByAdmin(int cliente_ID)
        {
            nuevoCliente = false;
            crearUsuario = false;
            ID = cliente_ID;
            chkHabilitado.Visible = true;
            cargarDatos();
            this.ShowDialog();

            return guardado;
        }

        public void ver(int cliente_ID)
        {
            ID = cliente_ID;
            btnGuardar.Visible = false;
            cargarDatos();

            this.ShowDialog();
        }

        private void cargarDatos()
        {
            GD1C2014DataSet.tl_ClientesDataTable clienteDataTable = new GD1C2014DataSet.tl_ClientesDataTable();
            clienteDataTable = this.tl_ClientesTableAdapter.getByID(ID);
            DataRow cliente = clienteDataTable.Rows[0];

            cmbTipoDocumento.Text = cliente["Tipo_Documento"].ToString();
            numNroDocumento.Value= Convert.ToInt32(cliente["Nro_Documento"].ToString());
            txtApellido.Text = cliente["Apellido"].ToString();
            txtNombre.Text = cliente["Nombre"].ToString();
            txtCUIL.Text = cliente["CUIL"].ToString();
            dateFechaNacimiento.Value = Convert.ToDateTime(cliente["Fecha_Nac"].ToString());
            txtMail.Text = cliente["Mail"].ToString();
            txtCalle.Text = cliente["Dom_Calle"].ToString();
            numNroCalle.Value = Convert.ToInt32(cliente["Nro_Calle"].ToString());
            numPiso.Value = Convert.ToInt32(cliente["Piso"].ToString());
            txtDepto.Text = cliente["Depto"].ToString();
            txtCodigoPostal.Text = cliente["Cod_Postal"].ToString();
            txtTelefono.Text = cliente["Telefono"].ToString();

            GD1C2014DataSet.tl_Usuarios_RolesDataTable usuarioRolDataTable = new GD1C2014DataSet.tl_Usuarios_RolesDataTable();
            usuarioRolDataTable = this.tl_Usuarios_RolesTableAdapter.getByUsuarioRolIDs(ID,2);
            DataRow usuarioRol = usuarioRolDataTable.Rows[0];

            chkHabilitado.Checked = Convert.ToBoolean(usuarioRol["Habilitado"]);
        }

        private bool faltanCampos()
        {
            bool algunoVacio = commons.algunoVacio(cmbTipoDocumento);
            algunoVacio |= commons.algunoVacio(txtNombre,txtApellido, txtCUIL, txtMail, txtCalle, txtDepto, txtCodigoPostal);
            algunoVacio |= commons.algunoVacio(numNroDocumento,numNroCalle, numPiso);

            return algunoVacio;
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
                   cmbTipoDocumento.Text,
                   (int)numNroDocumento.Value,
                   txtCUIL.Text,
                   txtApellido.Text,
                   txtNombre.Text,
                   dateFechaNacimiento.Value,
                   txtMail.Text,
                   txtCalle.Text,
                   Convert.ToInt32(numNroCalle.Value),
                   Convert.ToInt32(numPiso.Value),
                   txtDepto.Text,
                   txtCodigoPostal.Text,
                   (txtTelefono.Text == "") ? (int?)null : Convert.ToInt32(txtTelefono.Text),
                   chkHabilitado.Checked
                   );
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            MessageBox.Show("Cliente Guardado");
            guardado = true;
            this.Close();
        }

        void Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowClosing && !guardado)
            {
                MessageBox.Show("Debe crear un Cliente");
                e.Cancel = true;
            }
        }
    }
}
