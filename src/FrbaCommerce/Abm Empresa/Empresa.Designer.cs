namespace FrbaCommerce.Abm_Empresa
{
    partial class Empresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDireccion = new System.Windows.Forms.GroupBox();
            this.numPiso = new System.Windows.Forms.NumericUpDown();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.numNroCalle = new System.Windows.Forms.NumericUpDown();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.dateFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tl_EmpresasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_EmpresasTableAdapter();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.lblNombreContacto = new System.Windows.Forms.Label();
            this.tl_Usuarios_RolesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Usuarios_RolesTableAdapter();
            this.chkHabilitada = new System.Windows.Forms.CheckBox();
            this.grpDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNroCalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDireccion
            // 
            this.grpDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpDireccion.Controls.Add(this.numPiso);
            this.grpDireccion.Controls.Add(this.txtCodigoPostal);
            this.grpDireccion.Controls.Add(this.txtDepto);
            this.grpDireccion.Controls.Add(this.lblCodigoPostal);
            this.grpDireccion.Controls.Add(this.lblDepto);
            this.grpDireccion.Controls.Add(this.lblPiso);
            this.grpDireccion.Controls.Add(this.numNroCalle);
            this.grpDireccion.Controls.Add(this.lblNroCalle);
            this.grpDireccion.Controls.Add(this.txtCalle);
            this.grpDireccion.Controls.Add(this.lblCalle);
            this.grpDireccion.Location = new System.Drawing.Point(12, 177);
            this.grpDireccion.Name = "grpDireccion";
            this.grpDireccion.Size = new System.Drawing.Size(297, 168);
            this.grpDireccion.TabIndex = 12;
            this.grpDireccion.TabStop = false;
            this.grpDireccion.Text = "Direccion";
            // 
            // numPiso
            // 
            this.numPiso.Location = new System.Drawing.Point(97, 78);
            this.numPiso.Name = "numPiso";
            this.numPiso.Size = new System.Drawing.Size(194, 20);
            this.numPiso.TabIndex = 7;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(96, 136);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(195, 20);
            this.txtCodigoPostal.TabIndex = 9;
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(96, 105);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(195, 20);
            this.txtDepto.TabIndex = 8;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(7, 136);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodigoPostal.TabIndex = 6;
            this.lblCodigoPostal.Text = "Codigo Postal";
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(7, 105);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(36, 13);
            this.lblDepto.TabIndex = 5;
            this.lblDepto.Text = "Depto";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(7, 78);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(27, 13);
            this.lblPiso.TabIndex = 4;
            this.lblPiso.Text = "Piso";
            // 
            // numNroCalle
            // 
            this.numNroCalle.Location = new System.Drawing.Point(97, 48);
            this.numNroCalle.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numNroCalle.Name = "numNroCalle";
            this.numNroCalle.Size = new System.Drawing.Size(194, 20);
            this.numNroCalle.TabIndex = 6;
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.Location = new System.Drawing.Point(7, 48);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(44, 13);
            this.lblNroCalle.TabIndex = 2;
            this.lblNroCalle.Text = "Numero";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(97, 20);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(194, 20);
            this.txtCalle.TabIndex = 5;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(7, 20);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "Calle";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(111, 38);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(201, 20);
            this.txtCUIT.TabIndex = 1;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(12, 41);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 24;
            this.lblCUIT.Text = "CUIT";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(111, 103);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(201, 20);
            this.txtMail.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 106);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 23;
            this.lblMail.Text = "Mail";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(12, 75);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(82, 13);
            this.lblFechaCreacion.TabIndex = 22;
            this.lblFechaCreacion.Text = "Fecha Creacion";
            // 
            // dateFechaCreacion
            // 
            this.dateFechaCreacion.Location = new System.Drawing.Point(112, 71);
            this.dateFechaCreacion.MaxDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateFechaCreacion.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateFechaCreacion.Name = "dateFechaCreacion";
            this.dateFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.dateFechaCreacion.TabIndex = 2;
            this.dateFechaCreacion.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(111, 9);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(200, 20);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(12, 12);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 20;
            this.lblRazonSocial.Tag = "";
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(268, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tl_EmpresasTableAdapter
            // 
            this.tl_EmpresasTableAdapter.ClearBeforeFill = true;
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Location = new System.Drawing.Point(112, 135);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(201, 20);
            this.txtNombreContacto.TabIndex = 4;
            // 
            // lblNombreContacto
            // 
            this.lblNombreContacto.AutoSize = true;
            this.lblNombreContacto.Location = new System.Drawing.Point(12, 138);
            this.lblNombreContacto.Name = "lblNombreContacto";
            this.lblNombreContacto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreContacto.TabIndex = 27;
            this.lblNombreContacto.Text = "Nombre Contacto";
            // 
            // tl_Usuarios_RolesTableAdapter
            // 
            this.tl_Usuarios_RolesTableAdapter.ClearBeforeFill = true;
            // 
            // chkHabilitada
            // 
            this.chkHabilitada.AutoSize = true;
            this.chkHabilitada.Checked = true;
            this.chkHabilitada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHabilitada.Location = new System.Drawing.Point(12, 364);
            this.chkHabilitada.Name = "chkHabilitada";
            this.chkHabilitada.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitada.TabIndex = 28;
            this.chkHabilitada.Text = "Habilitada";
            this.chkHabilitada.UseVisualStyleBackColor = true;
            this.chkHabilitada.Visible = false;
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(352, 413);
            this.Controls.Add(this.chkHabilitada);
            this.Controls.Add(this.txtNombreContacto);
            this.Controls.Add(this.lblNombreContacto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.dateFechaCreacion);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.grpDireccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Empresa";
            this.Text = "Empresa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Empresa_FormClosing);
            this.grpDireccion.ResumeLayout(false);
            this.grpDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNroCalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDireccion;
        private System.Windows.Forms.NumericUpDown numPiso;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.NumericUpDown numNroCalle;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.DateTimePicker dateFechaCreacion;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Button btnGuardar;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_EmpresasTableAdapter tl_EmpresasTableAdapter;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Label lblNombreContacto;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Usuarios_RolesTableAdapter tl_Usuarios_RolesTableAdapter;
        private System.Windows.Forms.CheckBox chkHabilitada;
    }
}