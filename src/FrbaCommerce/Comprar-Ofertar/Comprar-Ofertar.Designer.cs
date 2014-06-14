namespace FrbaCommerce.Comprar_Ofertar
{
    partial class Comprar_Ofertar
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.dataGridViewPublicaciones = new System.Windows.Forms.DataGridView();
            this.tl_PublicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.tl_PublicacionesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PublicacionesTableAdapter();
            this.tableAdapterManager = new FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager();
            this.tlRubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_RubrosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RubrosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRubros = new System.Windows.Forms.ComboBox();
            this.tlRubrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tl_Publicaciones_RubrosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Publicaciones_RubrosTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permitePreguntasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Preguntar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PublicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar Publicacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(135, 39);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(90, 20);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(50, 42);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(66, 13);
            this.Descripcion.TabIndex = 2;
            this.Descripcion.Text = "Descripcion:";
            // 
            // dataGridViewPublicaciones
            // 
            this.dataGridViewPublicaciones.AllowUserToAddRows = false;
            this.dataGridViewPublicaciones.AllowUserToDeleteRows = false;
            this.dataGridViewPublicaciones.AutoGenerateColumns = false;
            this.dataGridViewPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.descripcionDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.fechaVencimientoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.permitePreguntasDataGridViewCheckBoxColumn,
            this.Preguntar});
            this.dataGridViewPublicaciones.DataSource = this.tl_PublicacionesBindingSource;
            this.dataGridViewPublicaciones.Location = new System.Drawing.Point(12, 226);
            this.dataGridViewPublicaciones.Name = "dataGridViewPublicaciones";
            this.dataGridViewPublicaciones.ReadOnly = true;
            this.dataGridViewPublicaciones.Size = new System.Drawing.Size(562, 191);
            this.dataGridViewPublicaciones.TabIndex = 3;
            this.dataGridViewPublicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPublicaciones_CellContentClick);
            // 
            // tl_PublicacionesBindingSource
            // 
            this.tl_PublicacionesBindingSource.DataMember = "tl_Publicaciones";
            this.tl_PublicacionesBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tl_PublicacionesTableAdapter
            // 
            this.tl_PublicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tl_ClientesTableAdapter = null;
            this.tableAdapterManager.tl_ComprasTableAdapter = null;
            this.tableAdapterManager.tl_EmpresasTableAdapter = null;
            this.tableAdapterManager.tl_Facturas_ItemsTableAdapter = null;
            this.tableAdapterManager.tl_FacturasTableAdapter = null;
            this.tableAdapterManager.tl_FuncionalidadesTableAdapter = null;
            this.tableAdapterManager.tl_OfertasTableAdapter = null;
            this.tableAdapterManager.tl_PendientesTableAdapter = null;
            this.tableAdapterManager.tl_PreguntasTableAdapter = null;
            this.tableAdapterManager.tl_Publicaciones_RubrosTableAdapter = null;
            this.tableAdapterManager.tl_PublicacionesTableAdapter = this.tl_PublicacionesTableAdapter;
            this.tableAdapterManager.tl_Roles_FuncionalidadesTableAdapter = null;
            this.tableAdapterManager.tl_RolesTableAdapter = null;
            this.tableAdapterManager.tl_RubrosTableAdapter = null;
            this.tableAdapterManager.tl_Usuarios_RolesTableAdapter = null;
            this.tableAdapterManager.tl_UsuariosTableAdapter = null;
            this.tableAdapterManager.tl_VisibilidadesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tlRubrosBindingSource
            // 
            this.tlRubrosBindingSource.DataMember = "tl_Rubros";
            this.tlRubrosBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // tl_RubrosTableAdapter
            // 
            this.tl_RubrosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rubros:";
            // 
            // comboBoxRubros
            // 
            this.comboBoxRubros.DataSource = this.tlRubrosBindingSource;
            this.comboBoxRubros.DisplayMember = "Descripcion";
            this.comboBoxRubros.FormattingEnabled = true;
            this.comboBoxRubros.Location = new System.Drawing.Point(324, 39);
            this.comboBoxRubros.Name = "comboBoxRubros";
            this.comboBoxRubros.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRubros.TabIndex = 6;
            this.comboBoxRubros.ValueMember = "ID";
            // 
            // tlRubrosBindingSource1
            // 
            this.tlRubrosBindingSource1.DataMember = "tl_Rubros";
            this.tlRubrosBindingSource1.DataSource = this.gD1C2014DataSet;
            // 
            // tl_Publicaciones_RubrosTableAdapter
            // 
            this.tl_Publicaciones_RubrosTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Codigo";
            this.Column1.HeaderText = "IDPublicacion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Vencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Vencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            this.fechaVencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permitePreguntasDataGridViewCheckBoxColumn
            // 
            this.permitePreguntasDataGridViewCheckBoxColumn.DataPropertyName = "Permite_Preguntas";
            this.permitePreguntasDataGridViewCheckBoxColumn.HeaderText = "Permite_Preguntas";
            this.permitePreguntasDataGridViewCheckBoxColumn.Name = "permitePreguntasDataGridViewCheckBoxColumn";
            this.permitePreguntasDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Preguntar
            // 
            this.Preguntar.HeaderText = "Preguntar";
            this.Preguntar.Name = "Preguntar";
            this.Preguntar.ReadOnly = true;
            // 
            // Comprar_Ofertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 429);
            this.Controls.Add(this.comboBoxRubros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPublicaciones);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.button1);
            this.Name = "Comprar_Ofertar";
            this.Text = "Comprar_Ofertar";
            this.Load += new System.EventHandler(this.Comprar_Ofertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PublicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.DataGridView dataGridViewPublicaciones;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tl_PublicacionesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PublicacionesTableAdapter tl_PublicacionesTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tlRubrosBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RubrosTableAdapter tl_RubrosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRubros;
        private System.Windows.Forms.BindingSource tlRubrosBindingSource1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Publicaciones_RubrosTableAdapter tl_Publicaciones_RubrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permitePreguntasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Preguntar;
    }
}