namespace FrbaCommerce.Calificar_Vendedor
{
    partial class CalificarVendedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.tlComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.tl_ComprasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ComprasTableAdapter();
            this.grpCalificacion = new System.Windows.Forms.GroupBox();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.numCantidadEstrellas = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadEstrellas = new System.Windows.Forms.Label();
            this.grpCompras = new System.Windows.Forms.GroupBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicacionCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.grpCalificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadEstrellas)).BeginInit();
            this.grpCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AutoGenerateColumns = false;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.publicacionCodigoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.Calificar});
            this.dgvCompras.DataSource = this.tlComprasBindingSource;
            this.dgvCompras.Location = new System.Drawing.Point(6, 19);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.Size = new System.Drawing.Size(640, 234);
            this.dgvCompras.TabIndex = 0;
            this.dgvCompras.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCompras_CellMouseClick);
            // 
            // tlComprasBindingSource
            // 
            this.tlComprasBindingSource.DataMember = "tl_Compras";
            this.tlComprasBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tl_ComprasTableAdapter
            // 
            this.tl_ComprasTableAdapter.ClearBeforeFill = true;
            // 
            // grpCalificacion
            // 
            this.grpCalificacion.Controls.Add(this.cmbDescripcion);
            this.grpCalificacion.Controls.Add(this.lblDescripcion);
            this.grpCalificacion.Controls.Add(this.btnCalificar);
            this.grpCalificacion.Controls.Add(this.numCantidadEstrellas);
            this.grpCalificacion.Controls.Add(this.lblCantidadEstrellas);
            this.grpCalificacion.Enabled = false;
            this.grpCalificacion.Location = new System.Drawing.Point(12, 277);
            this.grpCalificacion.Name = "grpCalificacion";
            this.grpCalificacion.Size = new System.Drawing.Size(652, 144);
            this.grpCalificacion.TabIndex = 1;
            this.grpCalificacion.TabStop = false;
            this.grpCalificacion.Text = "Calificacion";
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(571, 115);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 2;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // numCantidadEstrellas
            // 
            this.numCantidadEstrellas.Location = new System.Drawing.Point(103, 24);
            this.numCantidadEstrellas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCantidadEstrellas.Name = "numCantidadEstrellas";
            this.numCantidadEstrellas.Size = new System.Drawing.Size(201, 20);
            this.numCantidadEstrellas.TabIndex = 1;
            // 
            // lblCantidadEstrellas
            // 
            this.lblCantidadEstrellas.AutoSize = true;
            this.lblCantidadEstrellas.Location = new System.Drawing.Point(6, 26);
            this.lblCantidadEstrellas.Name = "lblCantidadEstrellas";
            this.lblCantidadEstrellas.Size = new System.Drawing.Size(91, 13);
            this.lblCantidadEstrellas.TabIndex = 0;
            this.lblCantidadEstrellas.Text = "Cantidad Estrellas";
            // 
            // grpCompras
            // 
            this.grpCompras.Controls.Add(this.dgvCompras);
            this.grpCompras.Location = new System.Drawing.Point(12, 12);
            this.grpCompras.Name = "grpCompras";
            this.grpCompras.Size = new System.Drawing.Size(652, 259);
            this.grpCompras.TabIndex = 2;
            this.grpCompras.TabStop = false;
            this.grpCompras.Text = "Compras";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // publicacionCodigoDataGridViewTextBoxColumn
            // 
            this.publicacionCodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.publicacionCodigoDataGridViewTextBoxColumn.DataPropertyName = "Publicacion_Codigo";
            this.publicacionCodigoDataGridViewTextBoxColumn.HeaderText = "Publicacion Codigo";
            this.publicacionCodigoDataGridViewTextBoxColumn.Name = "publicacionCodigoDataGridViewTextBoxColumn";
            this.publicacionCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.publicacionCodigoDataGridViewTextBoxColumn.Width = 113;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 74;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 62;
            // 
            // Calificar
            // 
            this.Calificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "Calificar";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Calificar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Calificar.DividerWidth = 10;
            this.Calificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calificar.HeaderText = "Calificar";
            this.Calificar.Name = "Calificar";
            this.Calificar.ReadOnly = true;
            this.Calificar.Width = 60;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 65);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Items.AddRange(new object[] {
            "Calificacion Positiva",
            "Calificacion Neutral",
            "Calificacion Negativa"});
            this.cmbDescripcion.Location = new System.Drawing.Point(103, 62);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(543, 21);
            this.cmbDescripcion.TabIndex = 4;
            // 
            // CalificarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 433);
            this.Controls.Add(this.grpCompras);
            this.Controls.Add(this.grpCalificacion);
            this.Name = "CalificarVendedor";
            this.Text = "Calificar Vendedor";
            this.Load += new System.EventHandler(this.CalificarVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.grpCalificacion.ResumeLayout(false);
            this.grpCalificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadEstrellas)).EndInit();
            this.grpCompras.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tlComprasBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ComprasTableAdapter tl_ComprasTableAdapter;
        private System.Windows.Forms.GroupBox grpCalificacion;
        private System.Windows.Forms.NumericUpDown numCantidadEstrellas;
        private System.Windows.Forms.Label lblCantidadEstrellas;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.GroupBox grpCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Calificar;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}