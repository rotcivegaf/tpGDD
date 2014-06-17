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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tl_PendientesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PendientesTableAdapter();
            this.tl_FacturasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_FacturasTableAdapter();
            this.tl_Facturas_ItemsTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Facturas_ItemsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.tlPendientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicacionCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facturar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPendientesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.publicacionCodigoDataGridViewTextBoxColumn,
            this.compraIDDataGridViewTextBoxColumn,
            this.Facturar});
            this.dataGridView1.DataSource = this.tlPendientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(870, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tlPendientesBindingSource
            // 
            this.tlPendientesBindingSource.DataMember = "tl_Pendientes";
            this.tlPendientesBindingSource.DataSource = this.gD1C2014DataSet;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 62;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.compraIDDataGridViewTextBoxColumn.HeaderText = "Compra_ID";
            this.compraIDDataGridViewTextBoxColumn.Name = "compraIDDataGridViewTextBoxColumn";
            this.compraIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.compraIDDataGridViewTextBoxColumn.Width = 85;
            // 
            // Facturar
            // 
            this.Facturar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Facturar.HeaderText = "Facturar";
            this.Facturar.Name = "Facturar";
            this.Facturar.ReadOnly = true;
            this.Facturar.Width = 52;
            // 
            // FacturarPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 526);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FacturarPublicaciones";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FacturarPublicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPendientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PendientesTableAdapter tl_PendientesTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_FacturasTableAdapter tl_FacturasTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Facturas_ItemsTableAdapter tl_Facturas_ItemsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tlPendientesBindingSource;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Facturar;
    }
}