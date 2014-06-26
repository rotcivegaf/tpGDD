namespace FrbaCommerce.Facturar_Publicaciones
{
    partial class FacturarPublicaciones
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
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.lblCantidadPendientesAFacturar = new System.Windows.Forms.Label();
            this.numCantidadPendientesAFacturar = new System.Windows.Forms.NumericUpDown();
            this.lblMontoAFacturar = new System.Windows.Forms.Label();
            this.txtMontoAFacturar = new System.Windows.Forms.Label();
            this.lblModoPago = new System.Windows.Forms.Label();
            this.cmbModoPago = new System.Windows.Forms.ComboBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.tlPendientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.tl_PendientesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PendientesTableAdapter();
            this.tl_FacturasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_FacturasTableAdapter();
            this.tl_Facturas_ItemsTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Facturas_ItemsTableAdapter();
            this.Pendiente_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicacion_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Facturar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadPendientesAFacturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPendientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPendientes
            // 
            this.dgvPendientes.AllowUserToAddRows = false;
            this.dgvPendientes.AllowUserToDeleteRows = false;
            this.dgvPendientes.AllowUserToResizeColumns = false;
            this.dgvPendientes.AllowUserToResizeRows = false;
            this.dgvPendientes.AutoGenerateColumns = false;
            this.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pendiente_ID,
            this.fechaDataGridViewTextBoxColumn,
            this.Monto,
            this.Publicacion_Codigo,
            this.Compra_ID,
            this.compraIDDataGridViewTextBoxColumn,
            this.Facturar});
            this.dgvPendientes.DataSource = this.tlPendientesBindingSource;
            this.dgvPendientes.Enabled = false;
            this.dgvPendientes.Location = new System.Drawing.Point(12, 13);
            this.dgvPendientes.MultiSelect = false;
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.ReadOnly = true;
            this.dgvPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPendientes.Size = new System.Drawing.Size(509, 256);
            this.dgvPendientes.TabIndex = 0;
            // 
            // lblCantidadPendientesAFacturar
            // 
            this.lblCantidadPendientesAFacturar.AutoSize = true;
            this.lblCantidadPendientesAFacturar.Location = new System.Drawing.Point(9, 294);
            this.lblCantidadPendientesAFacturar.Name = "lblCantidadPendientesAFacturar";
            this.lblCantidadPendientesAFacturar.Size = new System.Drawing.Size(156, 13);
            this.lblCantidadPendientesAFacturar.TabIndex = 1;
            this.lblCantidadPendientesAFacturar.Text = "Cantidad Pendientes a Facturar";
            // 
            // numCantidadPendientesAFacturar
            // 
            this.numCantidadPendientesAFacturar.Location = new System.Drawing.Point(171, 292);
            this.numCantidadPendientesAFacturar.Name = "numCantidadPendientesAFacturar";
            this.numCantidadPendientesAFacturar.Size = new System.Drawing.Size(120, 20);
            this.numCantidadPendientesAFacturar.TabIndex = 1;
            this.numCantidadPendientesAFacturar.ValueChanged += new System.EventHandler(this.numCantidadPendientesAFacturar_ValueChanged);
            // 
            // lblMontoAFacturar
            // 
            this.lblMontoAFacturar.AutoSize = true;
            this.lblMontoAFacturar.Location = new System.Drawing.Point(322, 292);
            this.lblMontoAFacturar.Name = "lblMontoAFacturar";
            this.lblMontoAFacturar.Size = new System.Drawing.Size(88, 13);
            this.lblMontoAFacturar.TabIndex = 3;
            this.lblMontoAFacturar.Text = "Monto a Facturar";
            // 
            // txtMontoAFacturar
            // 
            this.txtMontoAFacturar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMontoAFacturar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoAFacturar.Location = new System.Drawing.Point(416, 292);
            this.txtMontoAFacturar.Name = "txtMontoAFacturar";
            this.txtMontoAFacturar.Size = new System.Drawing.Size(100, 23);
            this.txtMontoAFacturar.TabIndex = 2;
            this.txtMontoAFacturar.Text = "-";
            this.txtMontoAFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModoPago
            // 
            this.lblModoPago.AutoSize = true;
            this.lblModoPago.Location = new System.Drawing.Point(9, 337);
            this.lblModoPago.Name = "lblModoPago";
            this.lblModoPago.Size = new System.Drawing.Size(77, 13);
            this.lblModoPago.TabIndex = 5;
            this.lblModoPago.Text = "Modo de Pago";
            // 
            // cmbModoPago
            // 
            this.cmbModoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModoPago.FormattingEnabled = true;
            this.cmbModoPago.Items.AddRange(new object[] {
            "Efectivo",
            "MercadoPago",
            "Tarjeta de Credito",
            "PayPal"});
            this.cmbModoPago.Location = new System.Drawing.Point(92, 334);
            this.cmbModoPago.Name = "cmbModoPago";
            this.cmbModoPago.Size = new System.Drawing.Size(199, 21);
            this.cmbModoPago.TabIndex = 3;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(416, 376);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(100, 23);
            this.btnFacturar.TabIndex = 4;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // tlPendientesBindingSource
            // 
            this.tlPendientesBindingSource.DataMember = "tl_Pendientes";
            this.tlPendientesBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tl_PendientesTableAdapter
            // 
            this.tl_PendientesTableAdapter.ClearBeforeFill = true;
            // 
            // tl_FacturasTableAdapter
            // 
            this.tl_FacturasTableAdapter.ClearBeforeFill = true;
            // 
            // tl_Facturas_ItemsTableAdapter
            // 
            this.tl_Facturas_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // Pendiente_ID
            // 
            this.Pendiente_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pendiente_ID.DataPropertyName = "ID";
            this.Pendiente_ID.HeaderText = "Pendiente ID";
            this.Pendiente_ID.Name = "Pendiente_ID";
            this.Pendiente_ID.ReadOnly = true;
            this.Pendiente_ID.Visible = false;
            this.Pendiente_ID.Width = 94;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 62;
            // 
            // Monto
            // 
            this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle2;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 62;
            // 
            // Publicacion_Codigo
            // 
            this.Publicacion_Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Publicacion_Codigo.DataPropertyName = "Publicacion_Codigo";
            this.Publicacion_Codigo.HeaderText = "Publicacion Codigo";
            this.Publicacion_Codigo.Name = "Publicacion_Codigo";
            this.Publicacion_Codigo.ReadOnly = true;
            this.Publicacion_Codigo.Width = 113;
            // 
            // Compra_ID
            // 
            this.Compra_ID.DataPropertyName = "Compra_ID";
            this.Compra_ID.HeaderText = "Compra ID";
            this.Compra_ID.Name = "Compra_ID";
            this.Compra_ID.ReadOnly = true;
            this.Compra_ID.Visible = false;
            // 
            // compraIDDataGridViewTextBoxColumn
            // 
            this.compraIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.compraIDDataGridViewTextBoxColumn.DataPropertyName = "Compra_ID";
            this.compraIDDataGridViewTextBoxColumn.HeaderText = "Comision";
            this.compraIDDataGridViewTextBoxColumn.Name = "compraIDDataGridViewTextBoxColumn";
            this.compraIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.compraIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.compraIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.compraIDDataGridViewTextBoxColumn.Width = 74;
            // 
            // Facturar
            // 
            this.Facturar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Facturar.HeaderText = "Facturar";
            this.Facturar.Name = "Facturar";
            this.Facturar.ReadOnly = true;
            this.Facturar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Facturar.Width = 52;
            // 
            // FacturarPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 411);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.cmbModoPago);
            this.Controls.Add(this.lblModoPago);
            this.Controls.Add(this.txtMontoAFacturar);
            this.Controls.Add(this.lblMontoAFacturar);
            this.Controls.Add(this.numCantidadPendientesAFacturar);
            this.Controls.Add(this.lblCantidadPendientesAFacturar);
            this.Controls.Add(this.dgvPendientes);
            this.Name = "FacturarPublicaciones";
            this.Text = "Facturar Publicaciones";
            this.Load += new System.EventHandler(this.FacturarPublicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadPendientesAFacturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPendientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PendientesTableAdapter tl_PendientesTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_FacturasTableAdapter tl_FacturasTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Facturas_ItemsTableAdapter tl_Facturas_ItemsTableAdapter;
        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.BindingSource tlPendientesBindingSource;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.Label lblCantidadPendientesAFacturar;
        private System.Windows.Forms.NumericUpDown numCantidadPendientesAFacturar;
        private System.Windows.Forms.Label lblMontoAFacturar;
        private System.Windows.Forms.Label txtMontoAFacturar;
        private System.Windows.Forms.Label lblModoPago;
        private System.Windows.Forms.ComboBox cmbModoPago;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pendiente_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicacion_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra_ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn compraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Facturar;
    }
}