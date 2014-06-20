namespace FrbaCommerce.Historial_Cliente
{
    partial class Historial
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
            this.optCompras = new System.Windows.Forms.RadioButton();
            this.optOfertas = new System.Windows.Forms.RadioButton();
            this.optCalificacionesOtorgadas = new System.Windows.Forms.RadioButton();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.optCalificacionesRecibidas = new System.Windows.Forms.RadioButton();
            this.dgvHistorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_ComprasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ComprasTableAdapter();
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.publicacionCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionCantEstrellasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // optCompras
            // 
            this.optCompras.AutoSize = true;
            this.optCompras.Location = new System.Drawing.Point(45, 12);
            this.optCompras.Name = "optCompras";
            this.optCompras.Size = new System.Drawing.Size(66, 17);
            this.optCompras.TabIndex = 0;
            this.optCompras.TabStop = true;
            this.optCompras.Text = "Compras";
            this.optCompras.UseVisualStyleBackColor = true;
            this.optCompras.CheckedChanged += new System.EventHandler(this.optCompras_CheckedChanged);
            // 
            // optOfertas
            // 
            this.optOfertas.AutoSize = true;
            this.optOfertas.Location = new System.Drawing.Point(225, 12);
            this.optOfertas.Name = "optOfertas";
            this.optOfertas.Size = new System.Drawing.Size(59, 17);
            this.optOfertas.TabIndex = 1;
            this.optOfertas.TabStop = true;
            this.optOfertas.Text = "Ofertas";
            this.optOfertas.UseVisualStyleBackColor = true;
            this.optOfertas.CheckedChanged += new System.EventHandler(this.optOfertas_CheckedChanged);
            // 
            // optCalificacionesOtorgadas
            // 
            this.optCalificacionesOtorgadas.AutoSize = true;
            this.optCalificacionesOtorgadas.Location = new System.Drawing.Point(384, 12);
            this.optCalificacionesOtorgadas.Name = "optCalificacionesOtorgadas";
            this.optCalificacionesOtorgadas.Size = new System.Drawing.Size(142, 17);
            this.optCalificacionesOtorgadas.TabIndex = 2;
            this.optCalificacionesOtorgadas.TabStop = true;
            this.optCalificacionesOtorgadas.Text = "Calificaciones Otorgadas";
            this.optCalificacionesOtorgadas.UseVisualStyleBackColor = true;
            this.optCalificacionesOtorgadas.CheckedChanged += new System.EventHandler(this.optCalificacionesOtorgadas_CheckedChanged);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AutoGenerateColumns = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publicacionCodigoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.calificacionCodigoDataGridViewTextBoxColumn,
            this.calificacionCantEstrellasDataGridViewTextBoxColumn,
            this.calificacionDescripcionDataGridViewTextBoxColumn});
            this.dgvHistorial.DataSource = this.dgvHistorialBindingSource;
            this.dgvHistorial.Location = new System.Drawing.Point(13, 35);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.Size = new System.Drawing.Size(790, 579);
            this.dgvHistorial.TabIndex = 3;
            // 
            // optCalificacionesRecibidas
            // 
            this.optCalificacionesRecibidas.AutoSize = true;
            this.optCalificacionesRecibidas.Location = new System.Drawing.Point(601, 12);
            this.optCalificacionesRecibidas.Name = "optCalificacionesRecibidas";
            this.optCalificacionesRecibidas.Size = new System.Drawing.Size(140, 17);
            this.optCalificacionesRecibidas.TabIndex = 4;
            this.optCalificacionesRecibidas.TabStop = true;
            this.optCalificacionesRecibidas.Text = "Calificaciones Recibidas";
            this.optCalificacionesRecibidas.UseVisualStyleBackColor = true;
            this.optCalificacionesRecibidas.CheckedChanged += new System.EventHandler(this.optCalificacionesRecibidas_CheckedChanged);
            // 
            // dgvHistorialBindingSource
            // 
            this.dgvHistorialBindingSource.DataMember = "tl_Compras";
            this.dgvHistorialBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // tl_ComprasTableAdapter
            // 
            this.tl_ComprasTableAdapter.ClearBeforeFill = true;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // calificacionCodigoDataGridViewTextBoxColumn
            // 
            this.calificacionCodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.calificacionCodigoDataGridViewTextBoxColumn.DataPropertyName = "Calificacion_Codigo";
            this.calificacionCodigoDataGridViewTextBoxColumn.HeaderText = "Calificacion_Codigo";
            this.calificacionCodigoDataGridViewTextBoxColumn.Name = "calificacionCodigoDataGridViewTextBoxColumn";
            this.calificacionCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.calificacionCodigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // calificacionCantEstrellasDataGridViewTextBoxColumn
            // 
            this.calificacionCantEstrellasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.calificacionCantEstrellasDataGridViewTextBoxColumn.DataPropertyName = "Calificacion_Cant_Estrellas";
            this.calificacionCantEstrellasDataGridViewTextBoxColumn.HeaderText = "Calificacion_Cant_Estrellas";
            this.calificacionCantEstrellasDataGridViewTextBoxColumn.Name = "calificacionCantEstrellasDataGridViewTextBoxColumn";
            this.calificacionCantEstrellasDataGridViewTextBoxColumn.ReadOnly = true;
            this.calificacionCantEstrellasDataGridViewTextBoxColumn.Width = 159;
            // 
            // calificacionDescripcionDataGridViewTextBoxColumn
            // 
            this.calificacionDescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.calificacionDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Calificacion_Descripcion";
            this.calificacionDescripcionDataGridViewTextBoxColumn.HeaderText = "Calificacion_Descripcion";
            this.calificacionDescripcionDataGridViewTextBoxColumn.Name = "calificacionDescripcionDataGridViewTextBoxColumn";
            this.calificacionDescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.calificacionDescripcionDataGridViewTextBoxColumn.Width = 148;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 626);
            this.Controls.Add(this.optCalificacionesRecibidas);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.optCalificacionesOtorgadas);
            this.Controls.Add(this.optOfertas);
            this.Controls.Add(this.optCompras);
            this.Name = "Historial";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optCompras;
        private System.Windows.Forms.RadioButton optOfertas;
        private System.Windows.Forms.RadioButton optCalificacionesOtorgadas;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.RadioButton optCalificacionesRecibidas;
        private System.Windows.Forms.BindingSource dgvHistorialBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ComprasTableAdapter tl_ComprasTableAdapter;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionCantEstrellasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionDescripcionDataGridViewTextBoxColumn;
    }
}