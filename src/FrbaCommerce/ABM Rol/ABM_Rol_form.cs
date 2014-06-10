﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.ABM_Rol
{
    public partial class ABM_Rol_Form : Form
    {
        public ABM_Rol_Form()
        {
            InitializeComponent();
        }

        private void ABM_Rol_Form_Load(object sender, EventArgs e)
        {
            /* Llenamos el tableAdapter de los Roles, que es source del
             * DataGridView Roles. */
            this.tl_RolesTableAdapter.Fill(this.gD1C2014DataSet.tl_Roles);
        }

        private void NuevoRol_Click(object sender, EventArgs e)
        {
            /* Cuando se clickea el boton "Nuevo", lo que hacemos es instanciar
             * el formulario de edicion, (se reusa tanto para creacion como edicion.
             * Al pasarle -1 como parametro id, le decimos que actue como form de creacion. 
             */
            Edit_Rol_Form editForm = new Edit_Rol_Form(-1, "-1", false);
            
            /* Añadimos un handler al evento close, y lo que hacemos en este handler
             * es volver a hacer el fill del tableAdapter de los Roles, para visualizar
             * el nuevo Rol en caso que haya sido creado. */
            editForm.FormClosed += new FormClosedEventHandler(editForm_FormClosed);
            
            //Mostramos el formulario.
            editForm.ShowDialog(); 
        }

        private void editForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tl_RolesTableAdapter.Fill(this.gD1C2014DataSet.tl_Roles);
        }

        private void EditarRol_Click(object sender, EventArgs e)
        {
            //Instaciamos el form con los datos del Rol a editar.
            Edit_Rol_Form editForm = new Edit_Rol_Form(Convert.ToInt32(Roles.SelectedRows[0].Cells[0].Value),
                Roles.SelectedRows[0].Cells[1].Value.ToString(), 
                Convert.ToBoolean(Roles.SelectedRows[0].Cells[2].Value));
            
            //Suscribimos al evento closed por la misma razon de antes.
            editForm.FormClosed += new FormClosedEventHandler(editForm_FormClosed);
            editForm.ShowDialog();
        }

        private void EliminarRol_Click(object sender, EventArgs e)
        {
            //Llamamos un stored procedure que elimina correctamente el Rol de todas las tablas necesarias.
            this.tl_RolesTableAdapter.sp_EliminarRol(Convert.ToInt32(Roles.SelectedRows[0].Cells[0].Value));
            this.tl_RolesTableAdapter.Fill(this.gD1C2014DataSet.tl_Roles);
        }

    }
}