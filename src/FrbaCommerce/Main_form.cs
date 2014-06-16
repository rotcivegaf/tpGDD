using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrbaCommerce.Login;
using FrbaCommerce.ABM_Rol;
using FrbaCommerce.ABM_Visibilidad;
using FrbaCommerce.Generar_Publicacion;
using FrbaCommerce.Listado_Estadistico;


/////////////////////////////////////////////
using FrbaCommerce.Abm_Cliente;
using FrbaCommerce.Abm_Empresa;
/////////////////////////////////////////////


namespace FrbaCommerce
{
    public partial class Main_form : Form
    {
        int usuario_ID;
        int rol_ID;

        public Main_form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formLogin frame = new formLogin();
            frame.ShowDialog();
            usuario_ID = frame.getUsuarioLogueadoID() ;
            rol_ID = frame.getRolID();
        }

        private void btnABM_Rol_Click(object sender, EventArgs e)
        {
            ABM_Rol_Form frame = new ABM_Rol_Form();
            frame.ShowDialog();
        }

        private void btnABM_Visibilidades_Click(object sender, EventArgs e)
        {
            ABM_Visibilidad_Form frame = new ABM_Visibilidad_Form();
            frame.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generar_Publicacion_form frame = new Generar_Publicacion_form();
            frame.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Comprar_Ofertar.Comprar_Ofertar frame = new Comprar_Ofertar.Comprar_Ofertar();
            frame.setID(usuario_ID);
            frame.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Listado_Estadistico_form frame = new Listado_Estadistico_form();
            frame.ShowDialog();
        }

        private void btnABMCliente_Click(object sender, EventArgs e)
        {
            Clientes frmClientes = new Clientes();
            frmClientes.abrir();
        }

        private void btnABMEmpresa_Click(object sender, EventArgs e)
        {
            Empresas frmEmpresa = new Empresas();
            frmEmpresa.abrir();
        }
    }
}
