﻿namespace FrbaCommerce.Generar_Publicacion
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.tl_PublicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_PublicacionesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PublicacionesTableAdapter();
            this.tl_VisibilidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_VisibilidadesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.comboBoxEstadoDeLaPublicacion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxAceptaPreguntas = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.listBoxRubro = new System.Windows.Forms.ListBox();
            this.tlRubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_RubrosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RubrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlVisibilidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PublicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_VisibilidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inputDescripcion
            // 
            this.inputDescripcion.Location = new System.Drawing.Point(133, 39);
            this.inputDescripcion.Name = "inputDescripcion";
            this.inputDescripcion.Size = new System.Drawing.Size(113, 20);
            this.inputDescripcion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de vencimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de inicio:";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(133, 103);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerFechaInicio.TabIndex = 8;
            this.dateTimePickerFechaInicio.ValueChanged += new System.EventHandler(this.dateTimePickerFechaInicio_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 206);
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
            this.numericUpDownPrecio.Location = new System.Drawing.Point(135, 172);
            this.numericUpDownPrecio.Name = "numericUpDownPrecio";
            this.numericUpDownPrecio.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrecio.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 315);
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
            this.comboBoxVisiblidad.FormattingEnabled = true;
            this.comboBoxVisiblidad.Location = new System.Drawing.Point(137, 315);
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
            this.comboBoxTipoDePublicacion.FormattingEnabled = true;
            this.comboBoxTipoDePublicacion.Items.AddRange(new object[] {
            "Oferta",
            "Subasta"});
            this.comboBoxTipoDePublicacion.Location = new System.Drawing.Point(137, 359);
            this.comboBoxTipoDePublicacion.Name = "comboBoxTipoDePublicacion";
            this.comboBoxTipoDePublicacion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoDePublicacion.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tipo de publicación:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Preguntas:";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(506, 107);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(128, 283);
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
            this.numericUpDownStock.Location = new System.Drawing.Point(133, 70);
            this.numericUpDownStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.comboBoxEstadoDeLaPublicacion.FormattingEnabled = true;
            this.comboBoxEstadoDeLaPublicacion.Items.AddRange(new object[] {
            "Borrador",
            "Activa",
            "Pausada",
            "Finalizada"});
            this.comboBoxEstadoDeLaPublicacion.Location = new System.Drawing.Point(135, 397);
            this.comboBoxEstadoDeLaPublicacion.Name = "comboBoxEstadoDeLaPublicacion";
            this.comboBoxEstadoDeLaPublicacion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstadoDeLaPublicacion.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Estado de la Publicacion:";
            // 
            // checkBoxAceptaPreguntas
            // 
            this.checkBoxAceptaPreguntas.AutoSize = true;
            this.checkBoxAceptaPreguntas.Location = new System.Drawing.Point(138, 436);
            this.checkBoxAceptaPreguntas.Name = "checkBoxAceptaPreguntas";
            this.checkBoxAceptaPreguntas.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAceptaPreguntas.TabIndex = 25;
            this.checkBoxAceptaPreguntas.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaVencimiento
            // 
            this.dateTimePickerFechaVencimiento.Enabled = false;
            this.dateTimePickerFechaVencimiento.Location = new System.Drawing.Point(133, 137);
            this.dateTimePickerFechaVencimiento.Name = "dateTimePickerFechaVencimiento";
            this.dateTimePickerFechaVencimiento.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerFechaVencimiento.TabIndex = 26;
            // 
            // listBoxRubro
            // 
            this.listBoxRubro.DataSource = this.tlRubrosBindingSource;
            this.listBoxRubro.DisplayMember = "Descripcion";
            this.listBoxRubro.FormattingEnabled = true;
            this.listBoxRubro.Location = new System.Drawing.Point(135, 206);
            this.listBoxRubro.Name = "listBoxRubro";
            this.listBoxRubro.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxRubro.Size = new System.Drawing.Size(120, 95);
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
            // Generar_Publicacion_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 470);
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
            this.Text = "Seleccionar";
            this.Load += new System.EventHandler(this.Publicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlVisibilidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PublicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_VisibilidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRubrosBindingSource)).EndInit();
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
    }
}