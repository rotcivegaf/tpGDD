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
        }

        private void Listado_Estadistico_form_Load(object sender, EventArgs e)
        {
            this.tl_VisibilidadesTableAdapter.Fill(this.gD1C2014DataSet.tl_Visibilidades);
            this.inputMes.ResetText();
            this.inputVisibilidad.ResetText();
        }

        private void inputTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.inputAnio.Enabled = false;
            this.inputTrimestre.Enabled = false;
            this.tipoListadoGroup.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.activarFiltroMes.Enabled = true;
                this.activarFiltroVisibilidad.Enabled = true;
                if (!this.btnGenerar.Enabled) this.btnGenerar.Enabled = true; 
            }
            else 
            {
                this.activarFiltroMes.Checked = false;
                this.activarFiltroMes.Enabled = false;
                this.activarFiltroVisibilidad.Checked = false;
                this.activarFiltroVisibilidad.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.btnGenerar.Enabled && this.radioButton2.Checked) this.btnGenerar.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.btnGenerar.Enabled && this.radioButton3.Checked) this.btnGenerar.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.btnGenerar.Enabled && this.radioButton4.Checked) this.btnGenerar.Enabled = true;
        }

        private void activarFiltroVisibilidad_CheckedChanged(object sender, EventArgs e)
        {
            if (this.activarFiltroVisibilidad.Checked)
            {
                this.inputVisibilidad.Enabled = true;
            }
            else
            {
                this.inputVisibilidad.Enabled = false;
            }
        }

        private void activarFiltroMes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.activarFiltroMes.Checked)
            {
                this.inputMes.Enabled = true;
            }
            else
            {
                this.inputMes.Enabled = false;
            }
        }

        private void inputVisibilidad_EnabledChanged(object sender, EventArgs e)
        {
            if (!this.inputVisibilidad.Enabled && this.btnGenerar.Enabled) this.inputVisibilidad.ResetText();
        }

        private void inputMes_EnabledChanged(object sender, EventArgs e)
        {
            if (!this.inputMes.Enabled && this.btnGenerar.Enabled) this.inputMes.ResetText();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.btnGenerar.Enabled = false;
            this.tipoListadoGroup.Enabled = false;

            if (radioButton1.Checked)
            {
                int? visibilidad = null;
                int? mes = null;
                dataGridView1.Visible = true;

                if (inputVisibilidad.Text != "")
                {
                    visibilidad = Convert.ToInt32(inputVisibilidad.SelectedValue);
                }
                if (inputMes.Text != "")
                {
                    mes = inputMes.SelectedIndex;
                }


                sp_VendedoresConMasStockTableAdapter.Fill(this.gD1C2014DataSet.sp_VendedoresConMasStock, Convert.ToInt32(this.inputAnio.Value), (this.inputTrimestre.SelectedIndex * 3) + 1, visibilidad, mes);
            }
            if (radioButton2.Checked)
            {
                this.vendedoresMayorFacturacionTableAdapter.Fill(this.gD1C2014DataSet.vendedoresMayorFacturacion, Convert.ToInt32(this.inputAnio.Value), (this.inputTrimestre.SelectedIndex * 3));
                dataGridView2.Visible = true;
            }
            if (radioButton3.Checked) 
            {
                this.vendedoresMayorReputacionTableAdapter.Fill(this.gD1C2014DataSet.vendedoresMayorReputacion, Convert.ToInt32(this.inputAnio.Value), (this.inputTrimestre.SelectedIndex * 3));
                dataGridView3.Visible = true;
            }
            if (radioButton4.Checked)
            {
                this.clientesMasPublicacionesSinCalificarTableAdapter.Fill(this.gD1C2014DataSet.clientesMasPublicacionesSinCalificar, Convert.ToInt32(this.inputAnio.Value), (this.inputTrimestre.SelectedIndex * 3));
                dataGridView4.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked) this.radioButton1.Checked = false;
            if (this.radioButton2.Checked) this.radioButton2.Checked = false;
            if (this.radioButton3.Checked) this.radioButton3.Checked = false;
            if (this.radioButton4.Checked) this.radioButton4.Checked = false;
            this.inputTrimestre.ResetText();
            if (this.tipoListadoGroup.Enabled) this.tipoListadoGroup.Enabled = false;
            if (this.btnGenerar.Enabled) this.btnGenerar.Enabled = false;
            if (!this.inputTrimestre.Enabled) this.inputTrimestre.Enabled = true;
            if (!this.inputAnio.Enabled) this.inputAnio.Enabled = true;
            inputMes.Text = "";
            inputVisibilidad.Text = "";
            if (dataGridView1.Visible) dataGridView1.Visible = false;
            if (dataGridView2.Visible) dataGridView2.Visible = false;
            if (dataGridView3.Visible) dataGridView3.Visible = false;
            if (dataGridView4.Visible) dataGridView4.Visible = false;
        }

    }
}
