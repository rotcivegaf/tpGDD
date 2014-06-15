namespace FrbaCommerce.Listado_Estadistico
{
    partial class Listado_Estadistico_form
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
            this.tipoListadoGroup = new System.Windows.Forms.GroupBox();
            this.activarFiltroMes = new System.Windows.Forms.CheckBox();
            this.activarFiltroVisibilidad = new System.Windows.Forms.CheckBox();
            this.inputVisibilidad = new System.Windows.Forms.ComboBox();
            this.tlVisibilidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.inputMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputAnio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTrimestre = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tl_VisibilidadesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tipoListadoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlVisibilidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoListadoGroup
            // 
            this.tipoListadoGroup.Controls.Add(this.activarFiltroMes);
            this.tipoListadoGroup.Controls.Add(this.activarFiltroVisibilidad);
            this.tipoListadoGroup.Controls.Add(this.inputVisibilidad);
            this.tipoListadoGroup.Controls.Add(this.inputMes);
            this.tipoListadoGroup.Controls.Add(this.label1);
            this.tipoListadoGroup.Controls.Add(this.radioButton4);
            this.tipoListadoGroup.Controls.Add(this.radioButton3);
            this.tipoListadoGroup.Controls.Add(this.radioButton2);
            this.tipoListadoGroup.Controls.Add(this.radioButton1);
            this.tipoListadoGroup.Enabled = false;
            this.tipoListadoGroup.Location = new System.Drawing.Point(256, 12);
            this.tipoListadoGroup.Name = "tipoListadoGroup";
            this.tipoListadoGroup.Size = new System.Drawing.Size(340, 189);
            this.tipoListadoGroup.TabIndex = 1;
            this.tipoListadoGroup.TabStop = false;
            this.tipoListadoGroup.Text = "Tipo de listado";
            // 
            // activarFiltroMes
            // 
            this.activarFiltroMes.AutoSize = true;
            this.activarFiltroMes.Enabled = false;
            this.activarFiltroMes.Location = new System.Drawing.Point(186, 79);
            this.activarFiltroMes.Name = "activarFiltroMes";
            this.activarFiltroMes.Size = new System.Drawing.Size(46, 17);
            this.activarFiltroMes.TabIndex = 11;
            this.activarFiltroMes.Text = "Mes";
            this.activarFiltroMes.UseVisualStyleBackColor = true;
            this.activarFiltroMes.CheckedChanged += new System.EventHandler(this.activarFiltroMes_CheckedChanged);
            // 
            // activarFiltroVisibilidad
            // 
            this.activarFiltroVisibilidad.AutoSize = true;
            this.activarFiltroVisibilidad.Enabled = false;
            this.activarFiltroVisibilidad.Location = new System.Drawing.Point(9, 79);
            this.activarFiltroVisibilidad.Name = "activarFiltroVisibilidad";
            this.activarFiltroVisibilidad.Size = new System.Drawing.Size(72, 17);
            this.activarFiltroVisibilidad.TabIndex = 10;
            this.activarFiltroVisibilidad.Text = "Visibilidad";
            this.activarFiltroVisibilidad.UseVisualStyleBackColor = true;
            this.activarFiltroVisibilidad.CheckedChanged += new System.EventHandler(this.activarFiltroVisibilidad_CheckedChanged);
            // 
            // inputVisibilidad
            // 
            this.inputVisibilidad.DataSource = this.tlVisibilidadesBindingSource;
            this.inputVisibilidad.DisplayMember = "Descripcion";
            this.inputVisibilidad.Enabled = false;
            this.inputVisibilidad.FormattingEnabled = true;
            this.inputVisibilidad.Location = new System.Drawing.Point(81, 77);
            this.inputVisibilidad.Name = "inputVisibilidad";
            this.inputVisibilidad.Size = new System.Drawing.Size(99, 21);
            this.inputVisibilidad.TabIndex = 8;
            this.inputVisibilidad.ValueMember = "Codigo";
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
            // inputMes
            // 
            this.inputMes.Enabled = false;
            this.inputMes.FormattingEnabled = true;
            this.inputMes.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero"});
            this.inputMes.Location = new System.Drawing.Point(232, 77);
            this.inputMes.Name = "inputMes";
            this.inputMes.Size = new System.Drawing.Size(97, 21);
            this.inputMes.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el tipo de listado que desea:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 153);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(299, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Clientes con mayor cantidad de publicaciones sin calificar.";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.tipoListado_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 130);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(215, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Vendedores con mayores calificaciones.";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.tipoListado_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 107);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(193, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vendedores con mayor facturacion.";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.tipoListado_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(307, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Vendedores con mayor cantidad de productos no vendidos.";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.tipoListado_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.inputAnio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.inputTrimestre);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 189);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Año";
            // 
            // inputAnio
            // 
            this.inputAnio.Location = new System.Drawing.Point(9, 48);
            this.inputAnio.Maximum = new decimal(new int[] {
            3013,
            0,
            0,
            0});
            this.inputAnio.Minimum = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            this.inputAnio.Name = "inputAnio";
            this.inputAnio.Size = new System.Drawing.Size(199, 20);
            this.inputAnio.TabIndex = 2;
            this.inputAnio.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trimestre";
            // 
            // inputTrimestre
            // 
            this.inputTrimestre.FormattingEnabled = true;
            this.inputTrimestre.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto"});
            this.inputTrimestre.Location = new System.Drawing.Point(12, 126);
            this.inputTrimestre.Name = "inputTrimestre";
            this.inputTrimestre.Size = new System.Drawing.Size(199, 21);
            this.inputTrimestre.TabIndex = 0;
            this.inputTrimestre.SelectedIndexChanged += new System.EventHandler(this.inputTrimestre_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Location = new System.Drawing.Point(12, 207);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(290, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar Top 5";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // tl_VisibilidadesTableAdapter
            // 
            this.tl_VisibilidadesTableAdapter.ClearBeforeFill = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(306, 207);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(290, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Listado_Estadistico_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 384);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tipoListadoGroup);
            this.Name = "Listado_Estadistico_form";
            this.Text = "Listado Estadistico";
            this.Load += new System.EventHandler(this.Listado_Estadistico_form_Load);
            this.tipoListadoGroup.ResumeLayout(false);
            this.tipoListadoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlVisibilidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tipoListadoGroup;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox inputTrimestre;
        private System.Windows.Forms.NumericUpDown inputAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox inputVisibilidad;
        private System.Windows.Forms.ComboBox inputMes;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tlVisibilidadesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter tl_VisibilidadesTableAdapter;
        private System.Windows.Forms.CheckBox activarFiltroMes;
        private System.Windows.Forms.CheckBox activarFiltroVisibilidad;
        private System.Windows.Forms.Button btnLimpiar;
    }
}