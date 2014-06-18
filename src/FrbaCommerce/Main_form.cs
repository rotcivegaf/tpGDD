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
using FrbaCommerce.Abm_Cliente;
using FrbaCommerce.Abm_Empresa;
using FrbaCommerce.Calificar_Vendedor;
using FrbaCommerce.Facturar_Publicaciones;
using FrbaCommerce.Historial_Cliente;

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
            formLogin frmLogin = new formLogin();
            if (frmLogin.login())
            {
                usuario_ID = frmLogin.getUsuarioLogueadoID();
                rol_ID = frmLogin.getRolID();
                DataRow usuario = this.tl_UsuariosTableAdapter.getByID(usuario_ID).Rows[0];
                toolStripUsuario.Text = "Username: " + usuario["Username"].ToString();
                DataRow rol = this.tl_RolesTableAdapter.getByID(rol_ID).Rows[0];
                toolStripRol.Text = "Rol: " + rol["Nombre"].ToString();
                acomodarFuncionalidades(rol_ID);
            }
        }

        private void hideGroupControls()
        {
            foreach (Control insideControl in groupBox1.Controls)
            {
                insideControl.Visible = false;
            }
        }

        private void acomodarFuncionalidades(int rolID)
        {
            btnLogin.Visible = false;
            hideGroupControls();
            DataTable funcionalidadesByRol = this.tl_FuncionalidadesTableAdapter.FuncionalidadesPorRol(rol_ID);
            foreach (DataRow fila in funcionalidadesByRol.Rows)
            {
                switch (fila["Nombre"].ToString())
                {
                    case "ABM de Rol":
                        btnABM_Rol.Visible = true;
                        break;
                    case "ABM de Cliente":
                        btnABMCliente.Visible = true;
                        break;
                    case "ABM de Empresa":
                        btnABMEmpresa.Visible = true;
                        break;
                    case "ABM de Rubro":
                        btnABMRubro.Visible = true;
                        break;
                    case "ABM Visibilidad de Publicacion":
                        btnABM_Visibilidades.Visible = true;
                        break;
                    case "Generar Publicacion":
                        button1.Visible = true;
                        break;
                    case "Editar Publicacion":
                        MessageBox.Show("FALTA EL BOTON PARA EditarPublicacion si es que va");
                        break;
                    case "Gestion de Preguntas":
                        MessageBox.Show("FALTA EL BOTON PARA GestionarPreguntas si es que va");
                        break;
                    case "Comprar/Ofertar":
                        button3.Visible = true;
                        break;
                    case "Historial del Cliente":
                        btnHistorialCliente.Visible = true;
                        break;
                    case "Calificar al Vendedor":
                        btnCalificarVendedor.Visible = true;
                        break;
                    case "Facturar Publicaciones":
                        btnFacturarPublicaciones.Visible = true;
                        break;
                    case "Listado Estadistico":
                        btnListadoEstadistico.Visible = true;
                        break;
                }
            }
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

        private void btnListadoEstadistico_Click(object sender, EventArgs e)
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

        private void btnCalificarVendedor_Click(object sender, EventArgs e)
        {
            if (logueado())
            {
                CalificarVendedor frmCalificarVendedor = new CalificarVendedor();
                frmCalificarVendedor.abrir(usuario_ID);
            }
        }

        private bool logueado()
        {
            if (usuario_ID != 0)
                return true;
            else
            {
                MessageBox.Show("Debe Loguearse al Sistema");
                return false;
            }
        }

        private void btnFacturarPublicaciones_Click(object sender, EventArgs e)
        {
            if (logueado())
            {
                FacturarPublicaciones frmFacturarPublicaciones = new FacturarPublicaciones();
                frmFacturarPublicaciones.abrir(usuario_ID, rol_ID);
            }
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            toolStripDate.Text = commons.getDate().ToString();
        }

        private void btnHistorialCliente_Click(object sender, EventArgs e)
        {
            HistorialCliente frmHistorialCliente = new HistorialCliente();
            frmHistorialCliente.abrir(usuario_ID, rol_ID);
        }
    }
}
