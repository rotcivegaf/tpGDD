﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class VerRespuestas : Form
    {
        private int userID;

        public VerRespuestas()
        {
            InitializeComponent();
        }

        public void abrir(int usuario_ID)
        {
            userID = usuario_ID;

            this.ShowDialog();
        }

        private void VerRespuestas_Load(object sender, EventArgs e)
        {
            llenarPreguntas();
        }

        private void llenarPreguntas()
        {
            this.preguntasRespuestasBindingSource.DataSource = this.preguntas_RespuestasTableAdapter.getByUsuario(userID);
        }
    }
}
