using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class Listado_Estadistico_form : Form
    {
        public Listado_Estadistico_form()
        {
            InitializeComponent();
            this.inputMes.SelectedIndex = 0;
        }

        private void inputTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sender.ToString() == "") return;
            this.tipoListadoGroup.Enabled = true;
            this.btnGenerar.Enabled = true;
            this.inputAnio.Enabled = false;
            this.inputTrimestre.Enabled = false;
            this.radioButton1.Select();
        }

        private void Listado_Estadistico_form_Load(object sender, EventArgs e)
        {
            this.tl_VisibilidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Visibilidades);
        }

        private void tipoListado_CheckedChanged(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Name == "radioButton1")
            {
                this.activarFiltroMes.Enabled = true;
                this.activarFiltroVisibilidad.Enabled = true;
            }
            else
            {
                this.activarFiltroMes.Checked = false;
                this.activarFiltroMes.Enabled = false;
                this.activarFiltroVisibilidad.Checked = false;
                this.activarFiltroVisibilidad.Enabled = false;
            }
        }

        private void activarFiltroVisibilidad_CheckedChanged(object sender, EventArgs e)
        {
            this.inputVisibilidad.Enabled = !this.inputVisibilidad.Enabled;
        }

        private void activarFiltroMes_CheckedChanged(object sender, EventArgs e)
        {
            this.inputMes.Enabled = !this.inputMes.Enabled;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.inputAnio.Enabled = true;
            this.inputTrimestre.SelectedText = "";
            this.inputTrimestre.Enabled = true;
            this.tipoListadoGroup.Enabled = false;
            this.activarFiltroVisibilidad.Checked = false;
            this.activarFiltroVisibilidad.Enabled = false;
            this.activarFiltroMes.Checked = false;
            this.activarFiltroMes.Enabled = false;
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            this.radioButton3.Checked = false;
            this.radioButton4.Checked = false;
            this.btnGenerar.Enabled = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.tipoListadoGroup.Enabled = false;

        }

    }
}
