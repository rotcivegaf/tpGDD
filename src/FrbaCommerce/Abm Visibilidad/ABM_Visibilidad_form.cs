using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.ABM_Visibilidad
{
    public partial class ABM_Visibilidad_Form : Form
    {
        public ABM_Visibilidad_Form()
        {
            InitializeComponent();
        }

        private void ABM_Visibilidad_Form_Load(object sender, EventArgs e)
        {
            this.tl_VisibilidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Visibilidades);

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Edit_Visibilidad_Form editForm = new Edit_Visibilidad_Form();
            editForm.FormClosed += new FormClosedEventHandler(editForm_FormClosed);
            
            //Mostramos el formulario.
            editForm.ShowDialog(); 
        }

        private void editForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tl_VisibilidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Visibilidades);
        }

    }
}
