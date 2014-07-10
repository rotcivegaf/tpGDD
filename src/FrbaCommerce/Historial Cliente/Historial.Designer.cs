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
            this.lblCantidadRegistros = new System.Windows.Forms.Label();
            this.ComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.historialComprasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.HistorialComprasTableAdapter();
            this.historialCalificacionesOtorgadasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.HistorialCalificacionesOtorgadasTableAdapter();
            this.CalificacionesOtorgadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OfertasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialOfertasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.HistorialOfertasTableAdapter();
            this.CalificacionesRecibidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialCalificacionesRecibidasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.HistorialCalificacionesRecibidasTableAdapter();
            this.txtCantidadRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionesOtorgadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfertasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionesRecibidasBindingSource)).BeginInit();
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
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(13, 35);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // lblCantidadRegistros
            // 
            this.lblCantidadRegistros.AutoSize = true;
            this.lblCantidadRegistros.Location = new System.Drawing.Point(13, 629);
            this.lblCantidadRegistros.Name = "lblCantidadRegistros";
            this.lblCantidadRegistros.Size = new System.Drawing.Size(99, 13);
            this.lblCantidadRegistros.TabIndex = 6;
            this.lblCantidadRegistros.Text = "Cantidad Registros:";
            // 
            // ComprasBindingSource
            // 
            this.ComprasBindingSource.DataMember = "HistorialCompras";
            this.ComprasBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialComprasTableAdapter
            // 
            this.historialComprasTableAdapter.ClearBeforeFill = true;
            // 
            // historialCalificacionesOtorgadasTableAdapter
            // 
            this.historialCalificacionesOtorgadasTableAdapter.ClearBeforeFill = true;
            // 
            // CalificacionesOtorgadasBindingSource
            // 
            this.CalificacionesOtorgadasBindingSource.DataMember = "HistorialCalificacionesOtorgadas";
            this.CalificacionesOtorgadasBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // OfertasBindingSource
            // 
            this.OfertasBindingSource.DataMember = "HistorialOfertas";
            this.OfertasBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // historialOfertasTableAdapter
            // 
            this.historialOfertasTableAdapter.ClearBeforeFill = true;
            // 
            // CalificacionesRecibidasBindingSource
            // 
            this.CalificacionesRecibidasBindingSource.DataMember = "HistorialCalificacionesRecibidas";
            this.CalificacionesRecibidasBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // historialCalificacionesRecibidasTableAdapter
            // 
            this.historialCalificacionesRecibidasTableAdapter.ClearBeforeFill = true;
            // 
            // txtCantidadRegistros
            // 
            this.txtCantidadRegistros.Location = new System.Drawing.Point(118, 629);
            this.txtCantidadRegistros.Name = "txtCantidadRegistros";
            this.txtCantidadRegistros.Size = new System.Drawing.Size(100, 13);
            this.txtCantidadRegistros.TabIndex = 8;
            this.txtCantidadRegistros.Text = "####";
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 654);
            this.Controls.Add(this.txtCantidadRegistros);
            this.Controls.Add(this.lblCantidadRegistros);
            this.Controls.Add(this.optCalificacionesRecibidas);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.optCalificacionesOtorgadas);
            this.Controls.Add(this.optOfertas);
            this.Controls.Add(this.optCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Historial";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionesOtorgadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfertasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionesRecibidasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optCompras;
        private System.Windows.Forms.RadioButton optOfertas;
        private System.Windows.Forms.RadioButton optCalificacionesOtorgadas;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.RadioButton optCalificacionesRecibidas;
        private System.Windows.Forms.BindingSource ComprasBindingSource;
        private GD1C2014DataSet gD1C2014DataSet;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.HistorialComprasTableAdapter historialComprasTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.HistorialCalificacionesOtorgadasTableAdapter historialCalificacionesOtorgadasTableAdapter;
        private System.Windows.Forms.BindingSource CalificacionesOtorgadasBindingSource;
        private System.Windows.Forms.Label lblCantidadRegistros;
        private System.Windows.Forms.BindingSource OfertasBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.HistorialOfertasTableAdapter historialOfertasTableAdapter;
        private System.Windows.Forms.BindingSource CalificacionesRecibidasBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.HistorialCalificacionesRecibidasTableAdapter historialCalificacionesRecibidasTableAdapter;
        private System.Windows.Forms.Label txtCantidadRegistros;
    }
}