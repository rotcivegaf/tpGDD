namespace FrbaCommerce.ABM_Visibilidad
{
    partial class ABM_Visibilidad_Form
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
            this.Visibilidades = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlVisibilidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.tl_VisibilidadesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter();
            this.btnNueva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Visibilidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlVisibilidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Visibilidades
            // 
            this.Visibilidades.AllowUserToAddRows = false;
            this.Visibilidades.AllowUserToDeleteRows = false;
            this.Visibilidades.AutoGenerateColumns = false;
            this.Visibilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Visibilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.porcentajeDataGridViewTextBoxColumn,
            this.seleccionar,
            this.Eliminar});
            this.Visibilidades.DataSource = this.tlVisibilidadesBindingSource;
            this.Visibilidades.Location = new System.Drawing.Point(12, 68);
            this.Visibilidades.MultiSelect = false;
            this.Visibilidades.Name = "Visibilidades";
            this.Visibilidades.ReadOnly = true;
            this.Visibilidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Visibilidades.Size = new System.Drawing.Size(663, 186);
            this.Visibilidades.TabIndex = 0;
            this.Visibilidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Visibilidades_CellClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcentajeDataGridViewTextBoxColumn
            // 
            this.porcentajeDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje";
            this.porcentajeDataGridViewTextBoxColumn.HeaderText = "Porcentaje";
            this.porcentajeDataGridViewTextBoxColumn.Name = "porcentajeDataGridViewTextBoxColumn";
            this.porcentajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
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
            // tl_VisibilidadesTableAdapter
            // 
            this.tl_VisibilidadesTableAdapter.ClearBeforeFill = true;
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(12, 21);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(137, 23);
            this.btnNueva.TabIndex = 1;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // ABM_Visibilidad_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 266);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.Visibilidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ABM_Visibilidad_Form";
            this.Text = "ABM Visibilidad";
            this.Load += new System.EventHandler(this.ABM_Visibilidad_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Visibilidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlVisibilidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Visibilidades;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tlVisibilidadesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter tl_VisibilidadesTableAdapter;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn seleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}