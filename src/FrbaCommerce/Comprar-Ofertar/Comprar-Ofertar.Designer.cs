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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBuscarPublicacion = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
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
            this.lblRubro = new System.Windows.Forms.Label();
            this.buttonPrincipio = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.tl_PublicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_PublicacionesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PublicacionesTableAdapter();
            this.tableAdapterManager = new FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager();
            this.tl_Publicaciones_RubrosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Publicaciones_RubrosTableAdapter();
            this.publicacionesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.PublicacionesTableAdapter();
            this.tl_UsuariosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_UsuariosTableAdapter();
            this.textBoxRubro = new System.Windows.Forms.TextBox();
            this.btnSeleccionarRubro = new System.Windows.Forms.Button();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.lblCantidadRegistros = new System.Windows.Forms.Label();
            this.cmbCantidadRegistros = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PublicacionesBindingSource)).BeginInit();
            this.grpBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscarPublicacion
            // 
            this.buttonBuscarPublicacion.Location = new System.Drawing.Point(849, 30);
            this.buttonBuscarPublicacion.Name = "buttonBuscarPublicacion";
            this.buttonBuscarPublicacion.Size = new System.Drawing.Size(93, 28);
            this.buttonBuscarPublicacion.TabIndex = 2;
            this.buttonBuscarPublicacion.Text = "Buscar";
            this.buttonBuscarPublicacion.UseVisualStyleBackColor = true;
            this.buttonBuscarPublicacion.Click += new System.EventHandler(this.buttonBuscarPublicacion_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(92, 35);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(658, 20);
            this.textBoxDescripcion.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // dataGridViewPublicaciones
            // 
            this.dataGridViewPublicaciones.AllowUserToAddRows = false;
            this.dataGridViewPublicaciones.AllowUserToDeleteRows = false;
            this.dataGridViewPublicaciones.AllowUserToResizeRows = false;
            this.dataGridViewPublicaciones.AutoGenerateColumns = false;
            this.dataGridViewPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPublicaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dataGridViewPublicaciones.Location = new System.Drawing.Point(12, 134);
            this.dataGridViewPublicaciones.Name = "dataGridViewPublicaciones";
            this.dataGridViewPublicaciones.ReadOnly = true;
            this.dataGridViewPublicaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewPublicaciones.ShowCellErrors = false;
            this.dataGridViewPublicaciones.ShowCellToolTips = false;
            this.dataGridViewPublicaciones.ShowEditingIcon = false;
            this.dataGridViewPublicaciones.Size = new System.Drawing.Size(949, 284);
            this.dataGridViewPublicaciones.TabIndex = 4;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Preguntar";
            this.Preguntar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Preguntar.HeaderText = "Preguntar";
            this.Preguntar.Name = "Preguntar";
            this.Preguntar.ReadOnly = true;
            this.Preguntar.Width = 59;
            // 
            // Comprar
            // 
            this.Comprar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Comprar/Ofertar";
            this.Comprar.DefaultCellStyle = dataGridViewCellStyle2;
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
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(20, 87);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(39, 13);
            this.lblRubro.TabIndex = 5;
            this.lblRubro.Text = "Rubro:";
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
            this.buttonSiguiente.Location = new System.Drawing.Point(373, 424);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.buttonSiguiente.TabIndex = 9;
            this.buttonSiguiente.Text = ">";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(454, 424);
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
            this.tableAdapterManager.tl_RespuestasTableAdapter = null;
            this.tableAdapterManager.tl_Roles_FuncionalidadesTableAdapter = null;
            this.tableAdapterManager.tl_RolesTableAdapter = null;
            this.tableAdapterManager.tl_RubrosTableAdapter = null;
            this.tableAdapterManager.tl_Usuarios_RolesTableAdapter = null;
            this.tableAdapterManager.tl_UsuariosTableAdapter = null;
            this.tableAdapterManager.tl_VisibilidadesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tl_Publicaciones_RubrosTableAdapter
            // 
            this.tl_Publicaciones_RubrosTableAdapter.ClearBeforeFill = true;
            // 
            // publicacionesTableAdapter
            // 
            this.publicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // tl_UsuariosTableAdapter
            // 
            this.tl_UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxRubro
            // 
            this.textBoxRubro.BackColor = System.Drawing.Color.White;
            this.textBoxRubro.Enabled = false;
            this.textBoxRubro.Location = new System.Drawing.Point(65, 84);
            this.textBoxRubro.Name = "textBoxRubro";
            this.textBoxRubro.Size = new System.Drawing.Size(604, 20);
            this.textBoxRubro.TabIndex = 11;
            this.textBoxRubro.Tag = "0";
            // 
            // btnSeleccionarRubro
            // 
            this.btnSeleccionarRubro.Location = new System.Drawing.Point(675, 84);
            this.btnSeleccionarRubro.Name = "btnSeleccionarRubro";
            this.btnSeleccionarRubro.Size = new System.Drawing.Size(75, 20);
            this.btnSeleccionarRubro.TabIndex = 1;
            this.btnSeleccionarRubro.Text = "Seleccionar";
            this.btnSeleccionarRubro.UseVisualStyleBackColor = true;
            this.btnSeleccionarRubro.Click += new System.EventHandler(this.btnSeleccionarRubro_Click);
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpBusqueda.Controls.Add(this.buttonLimpiar);
            this.grpBusqueda.Controls.Add(this.textBoxDescripcion);
            this.grpBusqueda.Controls.Add(this.btnSeleccionarRubro);
            this.grpBusqueda.Controls.Add(this.textBoxRubro);
            this.grpBusqueda.Controls.Add(this.lblDescripcion);
            this.grpBusqueda.Controls.Add(this.lblRubro);
            this.grpBusqueda.Controls.Add(this.buttonBuscarPublicacion);
            this.grpBusqueda.Location = new System.Drawing.Point(13, 12);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(948, 116);
            this.grpBusqueda.TabIndex = 13;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Busqueda";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(849, 79);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(93, 28);
            this.buttonLimpiar.TabIndex = 3;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // lblCantidadRegistros
            // 
            this.lblCantidadRegistros.AutoSize = true;
            this.lblCantidadRegistros.Location = new System.Drawing.Point(175, 429);
            this.lblCantidadRegistros.Name = "lblCantidadRegistros";
            this.lblCantidadRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblCantidadRegistros.TabIndex = 14;
            this.lblCantidadRegistros.Text = "Cantidad Registros";
            // 
            // cmbCantidadRegistros
            // 
            this.cmbCantidadRegistros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidadRegistros.FormattingEnabled = true;
            this.cmbCantidadRegistros.Items.AddRange(new object[] {
            "25",
            "50",
            "75",
            "100"});
            this.cmbCantidadRegistros.Location = new System.Drawing.Point(278, 424);
            this.cmbCantidadRegistros.Name = "cmbCantidadRegistros";
            this.cmbCantidadRegistros.Size = new System.Drawing.Size(83, 21);
            this.cmbCantidadRegistros.TabIndex = 15;
            this.cmbCantidadRegistros.SelectedIndexChanged += new System.EventHandler(this.cmbCantidadRegistros_SelectedIndexChanged);
            // 
            // Comprar_Ofertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(973, 459);
            this.Controls.Add(this.cmbCantidadRegistros);
            this.Controls.Add(this.lblCantidadRegistros);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.buttonPrincipio);
            this.Controls.Add(this.dataGridViewPublicaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Comprar_Ofertar";
            this.Text = "Comprar_Ofertar";
            this.Load += new System.EventHandler(this.Comprar_Ofertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PublicacionesBindingSource)).EndInit();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarPublicacion;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridView dataGridViewPublicaciones;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tl_PublicacionesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PublicacionesTableAdapter tl_PublicacionesTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblRubro;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Publicaciones_RubrosTableAdapter tl_Publicaciones_RubrosTableAdapter;
        private System.Windows.Forms.Button buttonPrincipio;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonFin;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PublicacionesTableAdapter publicacionesTableAdapter;
        private System.Windows.Forms.BindingSource publicacionesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_UsuariosTableAdapter tl_UsuariosTableAdapter;
        private System.Windows.Forms.TextBox textBoxRubro;
        private System.Windows.Forms.Button btnSeleccionarRubro;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label lblCantidadRegistros;
        private System.Windows.Forms.ComboBox cmbCantidadRegistros;
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
    }
}