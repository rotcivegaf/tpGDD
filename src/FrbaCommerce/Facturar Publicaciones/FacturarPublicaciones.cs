using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class FacturarPublicaciones : Form
    {
        int ID;
        int rol_ID;
        int cantidadAFacturar = 0;

        public FacturarPublicaciones()
        {
            InitializeComponent();
        }

        public void abrir(int userID, int rolID)
        {
            ID = userID;
            rol_ID = rolID;

            this.ShowDialog();
        }

        private void llenarGrid()
        {
            if (rol_ID == 2)//Cliente
                this.tlPendientesBindingSource.DataSource = this.tl_PendientesTableAdapter.getByClienteID(ID);
            else //Empresa
                this.tlPendientesBindingSource.DataSource = this.tl_PendientesTableAdapter.getByEmpresaID(ID);
        }

        private void FacturarPublicaciones_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void dgvPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
