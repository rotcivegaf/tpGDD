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
using FrbaCommerce.Editar_Publicacion;
using FrbaCommerce.Gestion_de_Preguntas;

namespace FrbaCommerce
{
    public partial class Main_form : Form
    {
        int usuario_ID;
        int rol_ID;

        public Main_form()
        {
            InitializeComponent();
            hideGroupControls();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            toolStripDate.Text = commons.getDate().ToString();
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

                int calificacionesPendientes = (int)queriesTableAdapter1.calificacionesPendientesDeUsuario(usuario_ID);
                if (calificacionesPendientes > 5)
                {
                    CalificarVendedor frmCalificar = new CalificarVendedor();
                    frmCalificar.abrir(usuario_ID, true);
                }
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
                        btnGenerarPublicacion.Visible = true;
                        break;
                    case "Editar Publicacion":
                        btnEditarPublicaciones.Visible = true;
                        break;
                    case "Gestion de Preguntas":
                        btnResponderPreguntas.Visible = true;
                        btnVerRespuestas.Visible = true;
                        break;
                    case "Comprar/Ofertar":
                        btnComprarOfertar.Visible = true;
                        break;
                    case "Historial del Cliente":
                        btnHistorial.Visible = true;
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

        private void btnGenerarPublicacion_Click(object sender, EventArgs e)
        {
            Generar_Publicacion_form frame = new Generar_Publicacion_form();
            frame.setIDs(usuario_ID,rol_ID);
            frame.ShowDialog();
        }

        private void btnComprarOfertar_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.Comprar_Ofertar frame = new Comprar_Ofertar.Comprar_Ofertar();
            frame.abrir(usuario_ID);
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
            CalificarVendedor frmCalificarVendedor = new CalificarVendedor();
            int calificacionesPendientes = (int)queriesTableAdapter1.calificacionesPendientesDeUsuario(usuario_ID);
            if (calificacionesPendientes > 5)
                frmCalificarVendedor.abrir(usuario_ID, true);
            else
                frmCalificarVendedor.abrir(usuario_ID, false);
        }

        private void btnFacturarPublicaciones_Click(object sender, EventArgs e)
        {
            FacturarPublicaciones frmFacturarPublicaciones = new FacturarPublicaciones();
            frmFacturarPublicaciones.abrir(usuario_ID, rol_ID);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Historial frmHistorial = new Historial();
            frmHistorial.abrir(usuario_ID, rol_ID);
        }

        private void btnEditarPublicaciones_Click(object sender, EventArgs e)
        {
            EditarPublicacion frame = new FrbaCommerce.Editar_Publicacion.EditarPublicacion();
            frame.abrir(usuario_ID, rol_ID);
        }

        private void toolStripUsuario_Click(object sender, EventArgs e)
        {
            if (usuario_ID != 0)
                if (rol_ID == commons.Rol_Cliente_ID)
                { 
                    Cliente frmCliente = new Cliente();
                    frmCliente.ver(usuario_ID);
                }
                else
                {
                    Empresa frmEmpresa = new Empresa();
                    frmEmpresa.ver(usuario_ID);
                }
        }

        private void btnVerRespuestas_Click(object sender, EventArgs e)
        {
            VerRespuestas frmVerRespuestas = new VerRespuestas();
            frmVerRespuestas.abrir(usuario_ID);
        }

        private void btnResponderPreguntas_Click(object sender, EventArgs e)
        {
            ResponderPreguntas frmResponderPreguntas = new ResponderPreguntas();
            frmResponderPreguntas.abrir(usuario_ID);
        }
    }
}
