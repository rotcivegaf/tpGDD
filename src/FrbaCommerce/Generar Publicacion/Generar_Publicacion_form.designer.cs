namespace FrbaCommerce.Generar_Publicacion
{
    partial class Generar_Publicacion_form
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
            this.inputDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownPrecio = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxVisiblidad = new System.Windows.Forms.ComboBox();
            this.tlVisibilidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.comboBoxTipoDePublicacion = new System.Windows.Forms.ComboBox();
            this.tlPublicacionTiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.tl_PublicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_PublicacionesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PublicacionesTableAdapter();
            this.tl_VisibilidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_VisibilidadesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.comboBoxEstadoDeLaPublicacion = new System.Windows.Forms.ComboBox();
            this.tlPublicacionEstadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxAceptaPreguntas = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.listBoxRubro = new System.Windows.Forms.ListBox();
            this.tlRubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_RubrosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RubrosTableAdapter();
            this.tl_Publicaciones_RubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_Publicaciones_RubrosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Publicaciones_RubrosTableAdapter();
            this.tableAdapterManager = new FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager();
            this.tl_ClientesTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ClientesTableAdapter();
            this.tl_EmpresasTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_EmpresasTableAdapter();
            this.tl_VisibilidadesTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter();
            this.tl_Publicacion_TiposTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Publicacion_TiposTableAdapter();
            this.tl_Publicacion_EstadosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Publicacion_EstadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlVisibilidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPublicacionTiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PublicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_VisibilidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPublicacionEstadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_Publicaciones_RubrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inputDescripcion
            // 
            this.inputDescripcion.Location = new System.Drawing.Point(136, 28);
            this.inputDescripcion.MaxLength = 255;
            this.inputDescripcion.Name = "inputDescripcion";
            this.inputDescripcion.Size = new System.Drawing.Size(213, 20);
            this.inputDescripcion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de vencimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de inicio:";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(136, 96);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(195, 20);
            this.dateTimePickerFechaInicio.TabIndex = 8;
            this.dateTimePickerFechaInicio.ValueChanged += new System.EventHandler(this.dateTimePickerFechaInicio_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rubro:";
            // 
            // numericUpDownPrecio
            // 
            this.numericUpDownPrecio.DecimalPlaces = 2;
            this.numericUpDownPrecio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPrecio.Location = new System.Drawing.Point(138, 165);
            this.numericUpDownPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrecio.Name = "numericUpDownPrecio";
            this.numericUpDownPrecio.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownPrecio.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Visibilidad:";
            // 
            // comboBoxVisiblidad
            // 
            this.comboBoxVisiblidad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tlVisibilidadesBindingSource, "Codigo", true));
            this.comboBoxVisiblidad.DataSource = this.tlVisibilidadesBindingSource;
            this.comboBoxVisiblidad.DisplayMember = "Descripcion";
            this.comboBoxVisiblidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisiblidad.FormattingEnabled = true;
            this.comboBoxVisiblidad.Location = new System.Drawing.Point(140, 308);
            this.comboBoxVisiblidad.Name = "comboBoxVisiblidad";
            this.comboBoxVisiblidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisiblidad.TabIndex = 15;
            this.comboBoxVisiblidad.ValueMember = "Codigo";
            this.comboBoxVisiblidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisiblidad_SelectedIndexChanged);
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
            // comboBoxTipoDePublicacion
            // 
            this.comboBoxTipoDePublicacion.DataSource = this.tlPublicacionTiposBindingSource;
            this.comboBoxTipoDePublicacion.DisplayMember = "Tipo";
            this.comboBoxTipoDePublicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDePublicacion.FormattingEnabled = true;
            this.comboBoxTipoDePublicacion.Location = new System.Drawing.Point(140, 345);
            this.comboBoxTipoDePublicacion.Name = "comboBoxTipoDePublicacion";
            this.comboBoxTipoDePublicacion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoDePublicacion.TabIndex = 17;
            this.comboBoxTipoDePublicacion.ValueMember = "ID";
            // 
            // tlPublicacionTiposBindingSource
            // 
            this.tlPublicacionTiposBindingSource.DataMember = "tl_Publicacion_Tipos";
            this.tlPublicacionTiposBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tipo de publicación:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Preguntas:";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(634, 422);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(70, 28);
            this.Guardar.TabIndex = 20;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
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
            // tl_VisibilidadesBindingSource
            // 
            this.tl_VisibilidadesBindingSource.DataMember = "tl_Visibilidades";
            this.tl_VisibilidadesBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // tl_VisibilidadesTableAdapter
            // 
            this.tl_VisibilidadesTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(136, 63);
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStock.TabIndex = 22;
            this.numericUpDownStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxEstadoDeLaPublicacion
            // 
            this.comboBoxEstadoDeLaPublicacion.DataSource = this.tlPublicacionEstadosBindingSource;
            this.comboBoxEstadoDeLaPublicacion.DisplayMember = "Estado";
            this.comboBoxEstadoDeLaPublicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoDeLaPublicacion.FormattingEnabled = true;
            this.comboBoxEstadoDeLaPublicacion.Location = new System.Drawing.Point(138, 383);
            this.comboBoxEstadoDeLaPublicacion.Name = "comboBoxEstadoDeLaPublicacion";
            this.comboBoxEstadoDeLaPublicacion.Size = new System.Drawing.Size(123, 21);
            this.comboBoxEstadoDeLaPublicacion.TabIndex = 24;
            this.comboBoxEstadoDeLaPublicacion.ValueMember = "ID";
            // 
            // tlPublicacionEstadosBindingSource
            // 
            this.tlPublicacionEstadosBindingSource.DataMember = "tl_Publicacion_Estados";
            this.tlPublicacionEstadosBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Estado de la Publicacion:";
            // 
            // checkBoxAceptaPreguntas
            // 
            this.checkBoxAceptaPreguntas.AutoSize = true;
            this.checkBoxAceptaPreguntas.Location = new System.Drawing.Point(141, 422);
            this.checkBoxAceptaPreguntas.Name = "checkBoxAceptaPreguntas";
            this.checkBoxAceptaPreguntas.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAceptaPreguntas.TabIndex = 25;
            this.checkBoxAceptaPreguntas.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaVencimiento
            // 
            this.dateTimePickerFechaVencimiento.Enabled = false;
            this.dateTimePickerFechaVencimiento.Location = new System.Drawing.Point(136, 130);
            this.dateTimePickerFechaVencimiento.Name = "dateTimePickerFechaVencimiento";
            this.dateTimePickerFechaVencimiento.Size = new System.Drawing.Size(195, 20);
            this.dateTimePickerFechaVencimiento.TabIndex = 26;
            // 
            // listBoxRubro
            // 
            this.listBoxRubro.DataSource = this.tlRubrosBindingSource;
            this.listBoxRubro.DisplayMember = "Descripcion";
            this.listBoxRubro.FormattingEnabled = true;
            this.listBoxRubro.Location = new System.Drawing.Point(138, 199);
            this.listBoxRubro.Name = "listBoxRubro";
            this.listBoxRubro.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxRubro.Size = new System.Drawing.Size(123, 95);
            this.listBoxRubro.TabIndex = 27;
            this.listBoxRubro.ValueMember = "ID";
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
            // tl_Publicaciones_RubrosBindingSource
            // 
            this.tl_Publicaciones_RubrosBindingSource.DataMember = "tl_Publicaciones_Rubros";
            this.tl_Publicaciones_RubrosBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // tl_Publicaciones_RubrosTableAdapter
            // 
            this.tl_Publicaciones_RubrosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tl_Publicaciones_RubrosTableAdapter = this.tl_Publicaciones_RubrosTableAdapter;
            this.tableAdapterManager.tl_PublicacionesTableAdapter = this.tl_PublicacionesTableAdapter;
            this.tableAdapterManager.tl_Roles_FuncionalidadesTableAdapter = null;
            this.tableAdapterManager.tl_RolesTableAdapter = null;
            this.tableAdapterManager.tl_RubrosTableAdapter = this.tl_RubrosTableAdapter;
            this.tableAdapterManager.tl_Usuarios_RolesTableAdapter = null;
            this.tableAdapterManager.tl_UsuariosTableAdapter = null;
            this.tableAdapterManager.tl_VisibilidadesTableAdapter = this.tl_VisibilidadesTableAdapter;
            this.tableAdapterManager.UpdateOrder = FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tl_ClientesTableAdapter1
            // 
            this.tl_ClientesTableAdapter1.ClearBeforeFill = true;
            // 
            // tl_EmpresasTableAdapter1
            // 
            this.tl_EmpresasTableAdapter1.ClearBeforeFill = true;
            // 
            // tl_VisibilidadesTableAdapter1
            // 
            this.tl_VisibilidadesTableAdapter1.ClearBeforeFill = true;
            // 
            // tl_Publicacion_TiposTableAdapter
            // 
            this.tl_Publicacion_TiposTableAdapter.ClearBeforeFill = true;
            // 
            // tl_Publicacion_EstadosTableAdapter
            // 
            this.tl_Publicacion_EstadosTableAdapter.ClearBeforeFill = true;
            // 
            // Generar_Publicacion_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 470);
            this.Controls.Add(this.listBoxRubro);
            this.Controls.Add(this.dateTimePickerFechaVencimiento);
            this.Controls.Add(this.checkBoxAceptaPreguntas);
            this.Controls.Add(this.comboBoxEstadoDeLaPublicacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownStock);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxTipoDePublicacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxVisiblidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerFechaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputDescripcion);
            this.Name = "Generar_Publicacion_form";
            this.Text = "Nueva Publicacion";
            this.Load += new System.EventHandler(this.Publicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlVisibilidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPublicacionTiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PublicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_VisibilidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPublicacionEstadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_Publicaciones_RubrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxVisiblidad;
        private System.Windows.Forms.ComboBox comboBoxTipoDePublicacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Guardar;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tl_PublicacionesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PublicacionesTableAdapter tl_PublicacionesTableAdapter;
        private System.Windows.Forms.BindingSource tl_VisibilidadesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter tl_VisibilidadesTableAdapter;
        private System.Windows.Forms.BindingSource tlVisibilidadesBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.ComboBox comboBoxEstadoDeLaPublicacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxAceptaPreguntas;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaVencimiento;
        private System.Windows.Forms.ListBox listBoxRubro;
        private System.Windows.Forms.BindingSource tlRubrosBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RubrosTableAdapter tl_RubrosTableAdapter;
        private System.Windows.Forms.BindingSource tl_Publicaciones_RubrosBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Publicaciones_RubrosTableAdapter tl_Publicaciones_RubrosTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ClientesTableAdapter tl_ClientesTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_EmpresasTableAdapter tl_EmpresasTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter tl_VisibilidadesTableAdapter1;
        private System.Windows.Forms.BindingSource tlPublicacionTiposBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Publicacion_TiposTableAdapter tl_Publicacion_TiposTableAdapter;
        private System.Windows.Forms.BindingSource tlPublicacionEstadosBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Publicacion_EstadosTableAdapter tl_Publicacion_EstadosTableAdapter;
    }
}