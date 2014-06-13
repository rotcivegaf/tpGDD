using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Cliente : Form
    {
        bool nuevoCliente;
        int ID;
        int usuario_ID;

        public Cliente()
        {
            InitializeComponent();
        }

        private void cargarDatos()
        {
            GD1C2014DataSet.tl_ClientesDataTable clienteDataTable = new GD1C2014DataSet.tl_ClientesDataTable();
            clienteDataTable = this.tl_ClientesTableAdapter.getByID(ID);

            foreach (DataRow cliente in clienteDataTable.Rows)
            {
                txtTipoDocumento.Text = cliente["Tipo_Documento"].ToString();
                txtNroDocumento.Text = cliente["Nro_Documento"].ToString();
                txtApellido.Text = cliente["Apellido"].ToString();
                txtNombre.Text = cliente["Nombre"].ToString();

                txtMail.Text = cliente["Mail"].ToString();
                txtCalle.Text = cliente["Dom_Calle"].ToString();


                txtDepto.Text = cliente["Depto"].ToString();
                txtCodigoPostal.Text = cliente["Cod_Postal"].ToString();
                txtCelular.Text = cliente["Telefono"].ToString();
            }
        }

        public void nuevo(int user_ID)
        {
            nuevoCliente = true;
            usuario_ID = user_ID; 
            
            this.ShowDialog();
        }

        public void editar(int cliente_ID)
        {
            nuevoCliente = false;
            ID = cliente_ID;

            cargarDatos();

            this.ShowDialog();
        }

        public int getClienteID()
        { return ID; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevoCliente)
            { }
            else
            { }
        }

    }
}
