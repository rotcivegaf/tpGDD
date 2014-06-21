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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.tlPendientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.tl_PendientesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PendientesTableAdapter();
            this.tl_FacturasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_FacturasTableAdapter();
            this.tl_Facturas_ItemsTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Facturas_ItemsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicacionCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Facturar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
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
            this.iDDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.publicacionCodigoDataGridViewTextBoxColumn,
            this.compraIDDataGridViewTextBoxColumn,
            this.Facturar});
            this.dgvPendientes.DataSource = this.tlPendientesBindingSource;
            this.dgvPendientes.Location = new System.Drawing.Point(13, 13);
            this.dgvPendientes.MultiSelect = false;
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendientes.Size = new System.Drawing.Size(870, 256);
            this.dgvPendientes.TabIndex = 0;
            this.dgvPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendientes_CellContentClick);
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 62;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.Width = 62;
            // 
            // publicacionCodigoDataGridViewTextBoxColumn
            // 
            this.publicacionCodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.publicacionCodigoDataGridViewTextBoxColumn.DataPropertyName = "Publicacion_Codigo";
            this.publicacionCodigoDataGridViewTextBoxColumn.HeaderText = "Publicacion_Codigo";
            this.publicacionCodigoDataGridViewTextBoxColumn.Name = "publicacionCodigoDataGridViewTextBoxColumn";
            this.publicacionCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.publicacionCodigoDataGridViewTextBoxColumn.Width = 126;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Facturar";
            this.Facturar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Facturar.HeaderText = "Facturar";
            this.Facturar.Name = "Facturar";
            this.Facturar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Facturar.Width = 52;
            // 
            // FacturarPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 526);
            this.Controls.Add(this.dgvPendientes);
            this.Name = "FacturarPublicaciones";
            this.Text = "Facturar Publicaciones";
            this.Load += new System.EventHandler(this.FacturarPublicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPendientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PendientesTableAdapter tl_PendientesTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_FacturasTableAdapter tl_FacturasTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Facturas_ItemsTableAdapter tl_Facturas_ItemsTableAdapter;
        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.BindingSource tlPendientesBindingSource;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn compraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Facturar;
    }
}