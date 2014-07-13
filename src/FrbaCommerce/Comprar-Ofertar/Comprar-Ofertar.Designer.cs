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
            this.buttonBuscarPublicacion = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.dataGridViewPublicaciones = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visibilidad_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibilidadDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permite_Preguntas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Preguntar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Comprar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.publicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRubros = new System.Windows.Forms.ComboBox();
            this.tlRubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPrincipio = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.tl_PublicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_PublicacionesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PublicacionesTableAdapter();
            this.tableAdapterManager = new FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager();
            this.tl_RubrosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RubrosTableAdapter();
            this.tlRubrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tl_Publicaciones_RubrosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Publicaciones_RubrosTableAdapter();
            this.publicacionesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.PublicacionesTableAdapter();
            this.queriesTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PublicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscarPublicacion
            // 
            this.buttonBuscarPublicacion.Location = new System.Drawing.Point(489, 12);
            this.buttonBuscarPublicacion.Name = "buttonBuscarPublicacion";
            this.buttonBuscarPublicacion.Size = new System.Drawing.Size(114, 35);
            this.buttonBuscarPublicacion.TabIndex = 2;
            this.buttonBuscarPublicacion.Text = "Buscar Publicacion";
            this.buttonBuscarPublicacion.UseVisualStyleBackColor = true;
            this.buttonBuscarPublicacion.Click += new System.EventHandler(this.buttonBuscarPublicacion_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(135, 20);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(90, 20);
            this.textBoxDescripcion.TabIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(50, 23);
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
            this.Codigo,
            this.Usuario_ID,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.Stock,
            this.fechaVencimientoDataGridViewTextBoxColumn,
            this.Precio,
            this.Tipo,
            this.Visibilidad_Codigo,
            this.visibilidadDescripcionDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.Permite_Preguntas,
            this.Preguntar,
            this.Comprar});
            this.dataGridViewPublicaciones.DataSource = this.publicacionesBindingSource;
            this.dataGridViewPublicaciones.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewPublicaciones.Name = "dataGridViewPublicaciones";
            this.dataGridViewPublicaciones.ReadOnly = true;
            this.dataGridViewPublicaciones.Size = new System.Drawing.Size(949, 365);
            this.dataGridViewPublicaciones.TabIndex = 3;
            this.dataGridViewPublicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPublicaciones_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Usuario_ID
            // 
            this.Usuario_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Usuario_ID.DataPropertyName = "Usuario_ID";
            this.Usuario_ID.HeaderText = "Usuario_ID";
            this.Usuario_ID.Name = "Usuario_ID";
            this.Usuario_ID.ReadOnly = true;
            this.Usuario_ID.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
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
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 60;
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Vencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Vencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            this.fechaVencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVencimientoDataGridViewTextBoxColumn.Width = 126;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 62;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 53;
            // 
            // Visibilidad_Codigo
            // 
            this.Visibilidad_Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Visibilidad_Codigo.DataPropertyName = "Visibilidad_Codigo";
            this.Visibilidad_Codigo.HeaderText = "Visibilidad_Codigo";
            this.Visibilidad_Codigo.Name = "Visibilidad_Codigo";
            this.Visibilidad_Codigo.ReadOnly = true;
            this.Visibilidad_Codigo.Visible = false;
            // 
            // visibilidadDescripcionDataGridViewTextBoxColumn
            // 
            this.visibilidadDescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.visibilidadDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Visibilidad_Descripcion";
            this.visibilidadDescripcionDataGridViewTextBoxColumn.HeaderText = "Visibilidad_Descripcion";
            this.visibilidadDescripcionDataGridViewTextBoxColumn.Name = "visibilidadDescripcionDataGridViewTextBoxColumn";
            this.visibilidadDescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.visibilidadDescripcionDataGridViewTextBoxColumn.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn2.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // Permite_Preguntas
            // 
            this.Permite_Preguntas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Permite_Preguntas.DataPropertyName = "Permite_Preguntas";
            this.Permite_Preguntas.HeaderText = "Permite_Preguntas";
            this.Permite_Preguntas.Name = "Permite_Preguntas";
            this.Permite_Preguntas.ReadOnly = true;
            this.Permite_Preguntas.Width = 102;
            // 
            // Preguntar
            // 
            this.Preguntar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Preguntar.HeaderText = "Preguntar";
            this.Preguntar.Name = "Preguntar";
            this.Preguntar.ReadOnly = true;
            this.Preguntar.Width = 59;
            // 
            // Comprar
            // 
            this.Comprar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Comprar.HeaderText = "Comprar/Ofertar";
            this.Comprar.Name = "Comprar";
            this.Comprar.ReadOnly = true;
            this.Comprar.Width = 89;
            // 
            // publicacionesBindingSource
            // 
            this.publicacionesBindingSource.DataMember = "Publicaciones";
            this.publicacionesBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 20);
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
            this.comboBoxRubros.Location = new System.Drawing.Point(324, 20);
            this.comboBoxRubros.Name = "comboBoxRubros";
            this.comboBoxRubros.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRubros.TabIndex = 1;
            this.comboBoxRubros.ValueMember = "ID";
            // 
            // tlRubrosBindingSource
            // 
            this.tlRubrosBindingSource.DataMember = "tl_Rubros";
            this.tlRubrosBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // buttonPrincipio
            // 
            this.buttonPrincipio.Location = new System.Drawing.Point(13, 424);
            this.buttonPrincipio.Name = "buttonPrincipio";
            this.buttonPrincipio.Size = new System.Drawing.Size(75, 23);
            this.buttonPrincipio.TabIndex = 7;
            this.buttonPrincipio.Text = "<<";
            this.buttonPrincipio.UseVisualStyleBackColor = true;
            this.buttonPrincipio.Click += new System.EventHandler(this.buttonPrincipio_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(94, 424);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(75, 23);
            this.buttonAnterior.TabIndex = 8;
            this.buttonAnterior.Text = "<";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(175, 424);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.buttonSiguiente.TabIndex = 9;
            this.buttonSiguiente.Text = ">";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(256, 424);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(75, 23);
            this.buttonFin.TabIndex = 10;
            this.buttonFin.Text = ">>";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // tl_PublicacionesBindingSource
            // 
            this.tl_PublicacionesBindingSource.DataMember = "tl_Publicaciones";
            this.tl_PublicacionesBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // tl_PublicacionesTableAdapter
            // 
            this.tl_PublicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tl_CalificacionesTableAdapter = null;
            this.tableAdapterManager.tl_ClientesTableAdapter = null;
            this.tableAdapterManager.tl_ComprasTableAdapter = null;
            this.tableAdapterManager.tl_EmpresasTableAdapter = null;
            this.tableAdapterManager.tl_Facturas_ItemsTableAdapter = null;
            this.tableAdapterManager.tl_FacturasTableAdapter = null;
            this.tableAdapterManager.tl_FuncionalidadesTableAdapter = null;
            this.tableAdapterManager.tl_OfertasTableAdapter = null;
            this.tableAdapterManager.tl_PendientesTableAdapter = null;
            this.tableAdapterManager.tl_PreguntasTableAdapter = null;
            this.tableAdapterManager.tl_Publicacion_EstadosTableAdapter = null;
            this.tableAdapterManager.tl_Publicacion_TiposTableAdapter = null;
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
            // tl_RubrosTableAdapter
            // 
            this.tl_RubrosTableAdapter.ClearBeforeFill = true;
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
            // publicacionesTableAdapter
            // 
            this.publicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // Comprar_Ofertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(973, 459);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.buttonPrincipio);
            this.Controls.Add(this.comboBoxRubros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPublicaciones);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.buttonBuscarPublicacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Comprar_Ofertar";
            this.Text = "Comprar_Ofertar";
            this.Load += new System.EventHandler(this.Comprar_Ofertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PublicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarPublicacion;
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
        private System.Windows.Forms.Button buttonPrincipio;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonFin;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PublicacionesTableAdapter publicacionesTableAdapter;
        private System.Windows.Forms.BindingSource publicacionesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visibilidad_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn visibilidadDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Permite_Preguntas;
        private System.Windows.Forms.DataGridViewButtonColumn Preguntar;
        private System.Windows.Forms.DataGridViewButtonColumn Comprar;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}