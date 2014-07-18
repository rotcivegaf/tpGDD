namespace FrbaCommerce.Abm_Cliente
{
    partial class Clientes
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
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.numNroDocumento = new System.Windows.Forms.NumericUpDown();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domCalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.optMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.ClientesTableAdapter();
            this.tl_ClientesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ClientesTableAdapter();
            this.grpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNroDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpBusqueda.Controls.Add(this.numNroDocumento);
            this.grpBusqueda.Controls.Add(this.txtMail);
            this.grpBusqueda.Controls.Add(this.cmbTipoDocumento);
            this.grpBusqueda.Controls.Add(this.txtApellido);
            this.grpBusqueda.Controls.Add(this.txtNombre);
            this.grpBusqueda.Controls.Add(this.lblMail);
            this.grpBusqueda.Controls.Add(this.lblDocumento);
            this.grpBusqueda.Controls.Add(this.lblApellido);
            this.grpBusqueda.Controls.Add(this.lblNombre);
            this.grpBusqueda.Controls.Add(this.btnBuscar);
            this.grpBusqueda.Controls.Add(this.btnLimpiar);
            this.grpBusqueda.Location = new System.Drawing.Point(12, 27);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(611, 137);
            this.grpBusqueda.TabIndex = 8;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Busqueda";
            // 
            // numNroDocumento
            // 
            this.numNroDocumento.Location = new System.Drawing.Point(149, 77);
            this.numNroDocumento.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numNroDocumento.Name = "numNroDocumento";
            this.numNroDocumento.Size = new System.Drawing.Size(145, 20);
            this.numNroDocumento.TabIndex = 3;
            this.numNroDocumento.GotFocus += new System.EventHandler(this.numNroDocumento_GotFocus);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(74, 103);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(220, 20);
            this.txtMail.TabIndex = 4;
            this.txtMail.GotFocus += new System.EventHandler(this.txtMail_GotFocus);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "*",
            "DNI",
            "PAS",
            "LE"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(74, 77);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(69, 21);
            this.cmbTipoDocumento.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(74, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.GotFocus += new System.EventHandler(this.txtApellido_GotFocus);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.GotFocus += new System.EventHandler(this.txtNombre_GotFocus);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 106);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mail";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(6, 80);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 11;
            this.lblDocumento.Text = "Documento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 54);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(529, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(529, 108);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tipoDocumentoDataGridViewTextBoxColumn,
            this.nroDocumentoDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cUILDataGridViewTextBoxColumn,
            this.fechaNacDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.domCalleDataGridViewTextBoxColumn,
            this.nroCalleDataGridViewTextBoxColumn,
            this.pisoDataGridViewTextBoxColumn,
            this.deptoDataGridViewTextBoxColumn,
            this.codPostalDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.habilitadoDataGridViewCheckBoxColumn,
            this.Seleccionar,
            this.Deshabilitar});
            this.dgvClientes.DataSource = this.clientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(12, 172);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(611, 314);
            this.dgvClientes.TabIndex = 7;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Documento";
            this.tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "Tipo_Documento";
            this.tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            this.tipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDocumentoDataGridViewTextBoxColumn.Width = 114;
            // 
            // nroDocumentoDataGridViewTextBoxColumn
            // 
            this.nroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Nro_Documento";
            this.nroDocumentoDataGridViewTextBoxColumn.HeaderText = "Nro_Documento";
            this.nroDocumentoDataGridViewTextBoxColumn.Name = "nroDocumentoDataGridViewTextBoxColumn";
            this.nroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroDocumentoDataGridViewTextBoxColumn.Width = 110;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 69;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // cUILDataGridViewTextBoxColumn
            // 
            this.cUILDataGridViewTextBoxColumn.DataPropertyName = "CUIL";
            this.cUILDataGridViewTextBoxColumn.HeaderText = "CUIL";
            this.cUILDataGridViewTextBoxColumn.Name = "cUILDataGridViewTextBoxColumn";
            this.cUILDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUILDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaNacDataGridViewTextBoxColumn
            // 
            this.fechaNacDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nac";
            this.fechaNacDataGridViewTextBoxColumn.HeaderText = "Fecha_Nac";
            this.fechaNacDataGridViewTextBoxColumn.Name = "fechaNacDataGridViewTextBoxColumn";
            this.fechaNacDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaNacDataGridViewTextBoxColumn.Width = 88;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailDataGridViewTextBoxColumn.Width = 51;
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
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Visible = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Deshabilitar";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Deshabilitar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Deshabilitar.HeaderText = "Deshabilitar";
            this.Deshabilitar.Name = "Deshabilitar";
            this.Deshabilitar.ReadOnly = true;
            this.Deshabilitar.Text = "Deshabilitar";
            this.Deshabilitar.ToolTipText = "Deshabilitar Cliente";
            this.Deshabilitar.Width = 68;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(635, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "Menu";
            // 
            // optMenu
            // 
            this.optMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optNuevo,
            this.toolStripSeparator1,
            this.optSalir});
            this.optMenu.Name = "optMenu";
            this.optMenu.Size = new System.Drawing.Size(45, 20);
            this.optMenu.Text = "Menu";
            // 
            // optNuevo
            // 
            this.optNuevo.Name = "optNuevo";
            this.optNuevo.Size = new System.Drawing.Size(152, 22);
            this.optNuevo.Text = "Nuevo";
            this.optNuevo.Click += new System.EventHandler(this.optNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // optSalir
            // 
            this.optSalir.Name = "optSalir";
            this.optSalir.Size = new System.Drawing.Size(152, 22);
            this.optSalir.Text = "Salir";
            this.optSalir.Click += new System.EventHandler(this.optSalir_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tl_ClientesTableAdapter
            // 
            this.tl_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(635, 498);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.Resize += new System.EventHandler(this.Clientes_Resize);
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNroDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.NumericUpDown numNroDocumento;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem optMenu;
        private System.Windows.Forms.ToolStripMenuItem optNuevo;
        private System.Windows.Forms.ToolStripMenuItem optSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ClientesTableAdapter tl_ClientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domCalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn Deshabilitar;
    }
}