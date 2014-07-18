namespace FrbaCommerce.Abm_Empresa
{
    partial class Empresas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.optMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.opcNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opcSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domCalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.tl_EmpresasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_EmpresasTableAdapter();
            this.empresasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.EmpresasTableAdapter();
            this.menuStrip.SuspendLayout();
            this.grpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(635, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            // 
            // optMenu
            // 
            this.optMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcNueva,
            this.toolStripSeparator1,
            this.opcSalir});
            this.optMenu.Name = "optMenu";
            this.optMenu.Size = new System.Drawing.Size(45, 20);
            this.optMenu.Text = "Menu";
            // 
            // opcNueva
            // 
            this.opcNueva.Name = "opcNueva";
            this.opcNueva.Size = new System.Drawing.Size(116, 22);
            this.opcNueva.Text = "Nueva";
            this.opcNueva.Click += new System.EventHandler(this.opcNueva_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // opcSalir
            // 
            this.opcSalir.Name = "opcSalir";
            this.opcSalir.Size = new System.Drawing.Size(116, 22);
            this.opcSalir.Text = "Salir";
            this.opcSalir.Click += new System.EventHandler(this.opcSalir_Click);
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpBusqueda.Controls.Add(this.txtMail);
            this.grpBusqueda.Controls.Add(this.txtCUIT);
            this.grpBusqueda.Controls.Add(this.txtRazonSocial);
            this.grpBusqueda.Controls.Add(this.lblMail);
            this.grpBusqueda.Controls.Add(this.lblCUIT);
            this.grpBusqueda.Controls.Add(this.lblRazonSocial);
            this.grpBusqueda.Controls.Add(this.btnBuscar);
            this.grpBusqueda.Controls.Add(this.btnLimpiar);
            this.grpBusqueda.Location = new System.Drawing.Point(12, 27);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(611, 107);
            this.grpBusqueda.TabIndex = 9;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Busqueda";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(82, 77);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(220, 20);
            this.txtMail.TabIndex = 4;
            this.txtMail.GotFocus += new System.EventHandler(this.txtMail_GotFocus);
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(82, 51);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(220, 20);
            this.txtCUIT.TabIndex = 1;
            this.txtCUIT.GotFocus += new System.EventHandler(this.txtCUIT_GotFocus);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(82, 22);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(220, 20);
            this.txtRazonSocial.TabIndex = 0;
            this.txtRazonSocial.GotFocus += new System.EventHandler(this.txtRazonSocial_GotFocus);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 80);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mail";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(6, 54);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 10;
            this.lblCUIT.Text = "CUIT";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(6, 25);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 9;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(528, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(528, 74);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AllowUserToAddRows = false;
            this.dgvEmpresas.AllowUserToDeleteRows = false;
            this.dgvEmpresas.AllowUserToResizeColumns = false;
            this.dgvEmpresas.AllowUserToResizeRows = false;
            this.dgvEmpresas.AutoGenerateColumns = false;
            this.dgvEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.razonSocialDataGridViewTextBoxColumn,
            this.cUITDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.nombreContactoDataGridViewTextBoxColumn,
            this.domCalleDataGridViewTextBoxColumn,
            this.nroCalleDataGridViewTextBoxColumn,
            this.pisoDataGridViewTextBoxColumn,
            this.deptoDataGridViewTextBoxColumn,
            this.codPostalDataGridViewTextBoxColumn,
            this.habilitadoDataGridViewCheckBoxColumn,
            this.Seleccionar,
            this.Deshabilitar});
            this.dgvEmpresas.DataSource = this.empresasBindingSource;
            this.dgvEmpresas.Location = new System.Drawing.Point(13, 140);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.ReadOnly = true;
            this.dgvEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresas.Size = new System.Drawing.Size(610, 336);
            this.dgvEmpresas.TabIndex = 10;
            this.dgvEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresas_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "Razon_Social";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "Razon_Social";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razonSocialDataGridViewTextBoxColumn.Width = 98;
            // 
            // cUITDataGridViewTextBoxColumn
            // 
            this.cUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT";
            this.cUITDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cUITDataGridViewTextBoxColumn.Name = "cUITDataGridViewTextBoxColumn";
            this.cUITDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUITDataGridViewTextBoxColumn.Width = 57;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Creacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "Fecha_Creacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCreacionDataGridViewTextBoxColumn.Width = 110;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailDataGridViewTextBoxColumn.Width = 51;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            this.nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Contacto";
            this.nombreContactoDataGridViewTextBoxColumn.HeaderText = "Nombre_Contacto";
            this.nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            this.nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreContactoDataGridViewTextBoxColumn.Width = 118;
            // 
            // domCalleDataGridViewTextBoxColumn
            // 
            this.domCalleDataGridViewTextBoxColumn.DataPropertyName = "Dom_Calle";
            this.domCalleDataGridViewTextBoxColumn.HeaderText = "Dom_Calle";
            this.domCalleDataGridViewTextBoxColumn.Name = "domCalleDataGridViewTextBoxColumn";
            this.domCalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.domCalleDataGridViewTextBoxColumn.Visible = false;
            // 
            // nroCalleDataGridViewTextBoxColumn
            // 
            this.nroCalleDataGridViewTextBoxColumn.DataPropertyName = "Nro_Calle";
            this.nroCalleDataGridViewTextBoxColumn.HeaderText = "Nro_Calle";
            this.nroCalleDataGridViewTextBoxColumn.Name = "nroCalleDataGridViewTextBoxColumn";
            this.nroCalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroCalleDataGridViewTextBoxColumn.Visible = false;
            // 
            // pisoDataGridViewTextBoxColumn
            // 
            this.pisoDataGridViewTextBoxColumn.DataPropertyName = "Piso";
            this.pisoDataGridViewTextBoxColumn.HeaderText = "Piso";
            this.pisoDataGridViewTextBoxColumn.Name = "pisoDataGridViewTextBoxColumn";
            this.pisoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pisoDataGridViewTextBoxColumn.Visible = false;
            // 
            // deptoDataGridViewTextBoxColumn
            // 
            this.deptoDataGridViewTextBoxColumn.DataPropertyName = "Depto";
            this.deptoDataGridViewTextBoxColumn.HeaderText = "Depto";
            this.deptoDataGridViewTextBoxColumn.Name = "deptoDataGridViewTextBoxColumn";
            this.deptoDataGridViewTextBoxColumn.ReadOnly = true;
            this.deptoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codPostalDataGridViewTextBoxColumn
            // 
            this.codPostalDataGridViewTextBoxColumn.DataPropertyName = "Cod_Postal";
            this.codPostalDataGridViewTextBoxColumn.HeaderText = "Cod_Postal";
            this.codPostalDataGridViewTextBoxColumn.Name = "codPostalDataGridViewTextBoxColumn";
            this.codPostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codPostalDataGridViewTextBoxColumn.Visible = false;
            // 
            // habilitadoDataGridViewCheckBoxColumn
            // 
            this.habilitadoDataGridViewCheckBoxColumn.DataPropertyName = "Habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.HeaderText = "Habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.Name = "habilitadoDataGridViewCheckBoxColumn";
            this.habilitadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.habilitadoDataGridViewCheckBoxColumn.Width = 60;
            // 
            // Seleccionar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Seleccionar";
            this.Seleccionar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 69;
            // 
            // Deshabilitar
            // 
            this.Deshabilitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Deshabilitar";
            this.Deshabilitar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Deshabilitar.HeaderText = "Deshabilitar";
            this.Deshabilitar.Name = "Deshabilitar";
            this.Deshabilitar.ReadOnly = true;
            this.Deshabilitar.Text = "";
            this.Deshabilitar.Width = 68;
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tl_EmpresasTableAdapter
            // 
            this.tl_EmpresasTableAdapter.ClearBeforeFill = true;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(635, 488);
            this.Controls.Add(this.dgvEmpresas);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Empresas";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Empresas_Load);
            this.Resize += new System.EventHandler(this.Empresas_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem optMenu;
        private System.Windows.Forms.ToolStripMenuItem opcNueva;
        private System.Windows.Forms.ToolStripMenuItem opcSalir;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private GD1C2014DataSet gD1C2014DataSet;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_EmpresasTableAdapter tl_EmpresasTableAdapter;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domCalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn Deshabilitar;
    }
}