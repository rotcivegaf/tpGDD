namespace FrbaCommerce.Listado_Estadistico
{
    partial class Listado_Estadistico_form
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
            this.tipoListadoGroup = new System.Windows.Forms.GroupBox();
            this.activarFiltroMes = new System.Windows.Forms.CheckBox();
            this.activarFiltroVisibilidad = new System.Windows.Forms.CheckBox();
            this.inputVisibilidad = new System.Windows.Forms.ComboBox();
            this.tlVisibilidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.inputMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputAnio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTrimestre = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tl_VisibilidadesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDeUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosSinVenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spVendedoresConMasStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_VendedoresConMasStockTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.sp_VendedoresConMasStockTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedoresMayorFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendedoresMayorFacturacionTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.vendedoresMayorFacturacionTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reputacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedoresMayorReputacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendedoresMayorReputacionTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.vendedoresMayorReputacionTableAdapter();
            this.clientesMasPublicacionesSinCalificarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesMasPublicacionesSinCalificarTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.clientesMasPublicacionesSinCalificarTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoListadoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlVisibilidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spVendedoresConMasStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresMayorFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresMayorReputacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesMasPublicacionesSinCalificarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoListadoGroup
            // 
            this.tipoListadoGroup.Controls.Add(this.activarFiltroMes);
            this.tipoListadoGroup.Controls.Add(this.activarFiltroVisibilidad);
            this.tipoListadoGroup.Controls.Add(this.inputVisibilidad);
            this.tipoListadoGroup.Controls.Add(this.inputMes);
            this.tipoListadoGroup.Controls.Add(this.label1);
            this.tipoListadoGroup.Controls.Add(this.radioButton4);
            this.tipoListadoGroup.Controls.Add(this.radioButton3);
            this.tipoListadoGroup.Controls.Add(this.radioButton2);
            this.tipoListadoGroup.Controls.Add(this.radioButton1);
            this.tipoListadoGroup.Enabled = false;
            this.tipoListadoGroup.Location = new System.Drawing.Point(256, 12);
            this.tipoListadoGroup.Name = "tipoListadoGroup";
            this.tipoListadoGroup.Size = new System.Drawing.Size(340, 179);
            this.tipoListadoGroup.TabIndex = 1;
            this.tipoListadoGroup.TabStop = false;
            this.tipoListadoGroup.Text = "Tipo de listado";
            // 
            // activarFiltroMes
            // 
            this.activarFiltroMes.AutoSize = true;
            this.activarFiltroMes.Enabled = false;
            this.activarFiltroMes.Location = new System.Drawing.Point(186, 79);
            this.activarFiltroMes.Name = "activarFiltroMes";
            this.activarFiltroMes.Size = new System.Drawing.Size(46, 17);
            this.activarFiltroMes.TabIndex = 11;
            this.activarFiltroMes.Text = "Mes";
            this.activarFiltroMes.UseVisualStyleBackColor = true;
            this.activarFiltroMes.CheckedChanged += new System.EventHandler(this.activarFiltroMes_CheckedChanged);
            // 
            // activarFiltroVisibilidad
            // 
            this.activarFiltroVisibilidad.AutoSize = true;
            this.activarFiltroVisibilidad.Enabled = false;
            this.activarFiltroVisibilidad.Location = new System.Drawing.Point(9, 79);
            this.activarFiltroVisibilidad.Name = "activarFiltroVisibilidad";
            this.activarFiltroVisibilidad.Size = new System.Drawing.Size(72, 17);
            this.activarFiltroVisibilidad.TabIndex = 10;
            this.activarFiltroVisibilidad.Text = "Visibilidad";
            this.activarFiltroVisibilidad.UseVisualStyleBackColor = true;
            this.activarFiltroVisibilidad.CheckedChanged += new System.EventHandler(this.activarFiltroVisibilidad_CheckedChanged);
            // 
            // inputVisibilidad
            // 
            this.inputVisibilidad.DataSource = this.tlVisibilidadesBindingSource;
            this.inputVisibilidad.DisplayMember = "Descripcion";
            this.inputVisibilidad.Enabled = false;
            this.inputVisibilidad.FormattingEnabled = true;
            this.inputVisibilidad.Location = new System.Drawing.Point(81, 77);
            this.inputVisibilidad.Name = "inputVisibilidad";
            this.inputVisibilidad.Size = new System.Drawing.Size(99, 21);
            this.inputVisibilidad.TabIndex = 8;
            this.inputVisibilidad.ValueMember = "Codigo";
            this.inputVisibilidad.EnabledChanged += new System.EventHandler(this.inputVisibilidad_EnabledChanged);
            // 
            // tlVisibilidadesBindingSource
            // 
            this.tlVisibilidadesBindingSource.DataMember = "tl_Visibilidades";
            this.tlVisibilidadesBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inputMes
            // 
            this.inputMes.Enabled = false;
            this.inputMes.FormattingEnabled = true;
            this.inputMes.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero"});
            this.inputMes.Location = new System.Drawing.Point(232, 77);
            this.inputMes.Name = "inputMes";
            this.inputMes.Size = new System.Drawing.Size(97, 21);
            this.inputMes.TabIndex = 5;
            this.inputMes.EnabledChanged += new System.EventHandler(this.inputMes_EnabledChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el tipo de listado que desea:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 153);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(299, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Clientes con mayor cantidad de publicaciones sin calificar.";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 130);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(215, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Vendedores con mayores calificaciones.";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 107);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(193, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vendedores con mayor facturacion.";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(307, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Vendedores con mayor cantidad de productos no vendidos.";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.inputAnio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.inputTrimestre);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 179);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Año";
            // 
            // inputAnio
            // 
            this.inputAnio.Location = new System.Drawing.Point(9, 48);
            this.inputAnio.Maximum = new decimal(new int[] {
            3013,
            0,
            0,
            0});
            this.inputAnio.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.inputAnio.Name = "inputAnio";
            this.inputAnio.Size = new System.Drawing.Size(202, 20);
            this.inputAnio.TabIndex = 2;
            this.inputAnio.TabStop = false;
            this.inputAnio.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trimestre";
            // 
            // inputTrimestre
            // 
            this.inputTrimestre.FormattingEnabled = true;
            this.inputTrimestre.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto"});
            this.inputTrimestre.Location = new System.Drawing.Point(12, 126);
            this.inputTrimestre.Name = "inputTrimestre";
            this.inputTrimestre.Size = new System.Drawing.Size(199, 21);
            this.inputTrimestre.TabIndex = 0;
            this.inputTrimestre.SelectedIndexChanged += new System.EventHandler(this.inputTrimestre_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Location = new System.Drawing.Point(12, 197);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(290, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar Top 5";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // tl_VisibilidadesTableAdapter
            // 
            this.tl_VisibilidadesTableAdapter.ClearBeforeFill = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(306, 197);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(290, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDeUsuarioDataGridViewTextBoxColumn,
            this.productosSinVenderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spVendedoresConMasStockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(584, 146);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // codigoDeUsuarioDataGridViewTextBoxColumn
            // 
            this.codigoDeUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Codigo de usuario";
            this.codigoDeUsuarioDataGridViewTextBoxColumn.HeaderText = "Codigo de usuario";
            this.codigoDeUsuarioDataGridViewTextBoxColumn.Name = "codigoDeUsuarioDataGridViewTextBoxColumn";
            this.codigoDeUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productosSinVenderDataGridViewTextBoxColumn
            // 
            this.productosSinVenderDataGridViewTextBoxColumn.DataPropertyName = "Productos sin vender";
            this.productosSinVenderDataGridViewTextBoxColumn.HeaderText = "Productos sin vender";
            this.productosSinVenderDataGridViewTextBoxColumn.Name = "productosSinVenderDataGridViewTextBoxColumn";
            this.productosSinVenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spVendedoresConMasStockBindingSource
            // 
            this.spVendedoresConMasStockBindingSource.DataMember = "sp_VendedoresConMasStock";
            this.spVendedoresConMasStockBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // sp_VendedoresConMasStockTableAdapter
            // 
            this.sp_VendedoresConMasStockTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.Facturacion});
            this.dataGridView2.DataSource = this.vendedoresMayorFacturacionBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 226);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(584, 146);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Facturacion
            // 
            this.Facturacion.DataPropertyName = "MontoTotal";
            this.Facturacion.HeaderText = "MontoTotal";
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.ReadOnly = true;
            // 
            // vendedoresMayorFacturacionBindingSource
            // 
            this.vendedoresMayorFacturacionBindingSource.DataMember = "vendedoresMayorFacturacion";
            this.vendedoresMayorFacturacionBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // vendedoresMayorFacturacionTableAdapter
            // 
            this.vendedoresMayorFacturacionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn1,
            this.reputacionDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.vendedoresMayorReputacionBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 226);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(584, 146);
            this.dataGridView3.TabIndex = 7;
            this.dataGridView3.Visible = false;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            this.usernameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // reputacionDataGridViewTextBoxColumn
            // 
            this.reputacionDataGridViewTextBoxColumn.DataPropertyName = "Reputacion";
            this.reputacionDataGridViewTextBoxColumn.HeaderText = "Reputacion";
            this.reputacionDataGridViewTextBoxColumn.Name = "reputacionDataGridViewTextBoxColumn";
            this.reputacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendedoresMayorReputacionBindingSource
            // 
            this.vendedoresMayorReputacionBindingSource.DataMember = "vendedoresMayorReputacion";
            this.vendedoresMayorReputacionBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // vendedoresMayorReputacionTableAdapter
            // 
            this.vendedoresMayorReputacionTableAdapter.ClearBeforeFill = true;
            // 
            // clientesMasPublicacionesSinCalificarBindingSource
            // 
            this.clientesMasPublicacionesSinCalificarBindingSource.DataMember = "clientesMasPublicacionesSinCalificar";
            this.clientesMasPublicacionesSinCalificarBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // clientesMasPublicacionesSinCalificarTableAdapter
            // 
            this.clientesMasPublicacionesSinCalificarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.clientesMasPublicacionesSinCalificarBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(12, 226);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(584, 146);
            this.dataGridView4.TabIndex = 8;
            this.dataGridView4.Visible = false;
            // 
            // usernameDataGridViewTextBoxColumn2
            // 
            this.usernameDataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn2.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn2.Name = "usernameDataGridViewTextBoxColumn2";
            // 
            // usernameDataGridViewTextBoxColumn3
            // 
            this.usernameDataGridViewTextBoxColumn3.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn3.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn3.Name = "usernameDataGridViewTextBoxColumn3";
            this.usernameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sin Calificar";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sin Calificar";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Listado_Estadistico_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 384);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tipoListadoGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Listado_Estadistico_form";
            this.Text = "Listado Estadistico";
            this.Load += new System.EventHandler(this.Listado_Estadistico_form_Load);
            this.tipoListadoGroup.ResumeLayout(false);
            this.tipoListadoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlVisibilidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spVendedoresConMasStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresMayorFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresMayorReputacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesMasPublicacionesSinCalificarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tipoListadoGroup;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox inputTrimestre;
        private System.Windows.Forms.NumericUpDown inputAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox inputVisibilidad;
        private System.Windows.Forms.ComboBox inputMes;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tlVisibilidadesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter tl_VisibilidadesTableAdapter;
        private System.Windows.Forms.CheckBox activarFiltroMes;
        private System.Windows.Forms.CheckBox activarFiltroVisibilidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productosSinVenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spVendedoresConMasStockBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.sp_VendedoresConMasStockTableAdapter sp_VendedoresConMasStockTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource vendedoresMayorFacturacionBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.vendedoresMayorFacturacionTableAdapter vendedoresMayorFacturacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reputacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vendedoresMayorReputacionBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.vendedoresMayorReputacionTableAdapter vendedoresMayorReputacionTableAdapter;
        private System.Windows.Forms.BindingSource clientesMasPublicacionesSinCalificarBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.clientesMasPublicacionesSinCalificarTableAdapter clientesMasPublicacionesSinCalificarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinCalificarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn2;
    }
}