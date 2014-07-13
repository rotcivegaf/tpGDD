namespace FrbaCommerce
{
    partial class Main_form
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnABM_Rol = new System.Windows.Forms.Button();
            this.btnABM_Visibilidades = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResponderPreguntas = new System.Windows.Forms.Button();
            this.btnVerRespuestas = new System.Windows.Forms.Button();
            this.btnEditarPublicaciones = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnABMRubro = new System.Windows.Forms.Button();
            this.btnFacturarPublicaciones = new System.Windows.Forms.Button();
            this.btnCalificarVendedor = new System.Windows.Forms.Button();
            this.btnABMEmpresa = new System.Windows.Forms.Button();
            this.btnABMCliente = new System.Windows.Forms.Button();
            this.btnComprarOfertar = new System.Windows.Forms.Button();
            this.btnListadoEstadistico = new System.Windows.Forms.Button();
            this.btnGenerarPublicacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tl_UsuariosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_UsuariosTableAdapter();
            this.tl_RolesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RolesTableAdapter();
            this.tl_FuncionalidadesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_FuncionalidadesTableAdapter();
            this.queriesTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.QueriesTableAdapter();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(578, 23);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(58, 27);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnABM_Rol
            // 
            this.btnABM_Rol.Location = new System.Drawing.Point(37, 38);
            this.btnABM_Rol.Name = "btnABM_Rol";
            this.btnABM_Rol.Size = new System.Drawing.Size(75, 27);
            this.btnABM_Rol.TabIndex = 1;
            this.btnABM_Rol.Text = "ABM Rol";
            this.btnABM_Rol.UseVisualStyleBackColor = true;
            this.btnABM_Rol.Click += new System.EventHandler(this.btnABM_Rol_Click);
            // 
            // btnABM_Visibilidades
            // 
            this.btnABM_Visibilidades.Location = new System.Drawing.Point(389, 38);
            this.btnABM_Visibilidades.Name = "btnABM_Visibilidades";
            this.btnABM_Visibilidades.Size = new System.Drawing.Size(112, 27);
            this.btnABM_Visibilidades.TabIndex = 4;
            this.btnABM_Visibilidades.Text = "ABM Visibilidades";
            this.btnABM_Visibilidades.UseVisualStyleBackColor = true;
            this.btnABM_Visibilidades.Click += new System.EventHandler(this.btnABM_Visibilidades_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResponderPreguntas);
            this.groupBox1.Controls.Add(this.btnVerRespuestas);
            this.groupBox1.Controls.Add(this.btnEditarPublicaciones);
            this.groupBox1.Controls.Add(this.btnHistorial);
            this.groupBox1.Controls.Add(this.btnABMRubro);
            this.groupBox1.Controls.Add(this.btnFacturarPublicaciones);
            this.groupBox1.Controls.Add(this.btnCalificarVendedor);
            this.groupBox1.Controls.Add(this.btnABMEmpresa);
            this.groupBox1.Controls.Add(this.btnABMCliente);
            this.groupBox1.Controls.Add(this.btnComprarOfertar);
            this.groupBox1.Controls.Add(this.btnListadoEstadistico);
            this.groupBox1.Controls.Add(this.btnGenerarPublicacion);
            this.groupBox1.Controls.Add(this.btnABM_Rol);
            this.groupBox1.Controls.Add(this.btnABM_Visibilidades);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionaliades";
            // 
            // btnResponderPreguntas
            // 
            this.btnResponderPreguntas.Location = new System.Drawing.Point(328, 120);
            this.btnResponderPreguntas.Name = "btnResponderPreguntas";
            this.btnResponderPreguntas.Size = new System.Drawing.Size(80, 39);
            this.btnResponderPreguntas.TabIndex = 12;
            this.btnResponderPreguntas.Text = "Responder Preguntas";
            this.btnResponderPreguntas.UseVisualStyleBackColor = true;
            this.btnResponderPreguntas.Click += new System.EventHandler(this.btnResponderPreguntas_Click);
            // 
            // btnVerRespuestas
            // 
            this.btnVerRespuestas.Location = new System.Drawing.Point(426, 120);
            this.btnVerRespuestas.Name = "btnVerRespuestas";
            this.btnVerRespuestas.Size = new System.Drawing.Size(75, 39);
            this.btnVerRespuestas.TabIndex = 13;
            this.btnVerRespuestas.Text = "Ver Respuestas";
            this.btnVerRespuestas.UseVisualStyleBackColor = true;
            this.btnVerRespuestas.Click += new System.EventHandler(this.btnVerRespuestas_Click);
            // 
            // btnEditarPublicaciones
            // 
            this.btnEditarPublicaciones.Location = new System.Drawing.Point(478, 79);
            this.btnEditarPublicaciones.Name = "btnEditarPublicaciones";
            this.btnEditarPublicaciones.Size = new System.Drawing.Size(140, 23);
            this.btnEditarPublicaciones.TabIndex = 9;
            this.btnEditarPublicaciones.Text = "Editar Publicaciones";
            this.btnEditarPublicaciones.UseVisualStyleBackColor = true;
            this.btnEditarPublicaciones.Click += new System.EventHandler(this.btnEditarPublicaciones_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(205, 126);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(95, 23);
            this.btnHistorial.TabIndex = 11;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnABMRubro
            // 
            this.btnABMRubro.Enabled = false;
            this.btnABMRubro.Location = new System.Drawing.Point(526, 40);
            this.btnABMRubro.Name = "btnABMRubro";
            this.btnABMRubro.Size = new System.Drawing.Size(75, 23);
            this.btnABMRubro.TabIndex = 5;
            this.btnABMRubro.Text = "ABM Rubro";
            this.btnABMRubro.UseVisualStyleBackColor = true;
            // 
            // btnFacturarPublicaciones
            // 
            this.btnFacturarPublicaciones.Location = new System.Drawing.Point(526, 120);
            this.btnFacturarPublicaciones.Name = "btnFacturarPublicaciones";
            this.btnFacturarPublicaciones.Size = new System.Drawing.Size(88, 39);
            this.btnFacturarPublicaciones.TabIndex = 14;
            this.btnFacturarPublicaciones.Text = "Facturar Publicaciones";
            this.btnFacturarPublicaciones.UseVisualStyleBackColor = true;
            this.btnFacturarPublicaciones.Click += new System.EventHandler(this.btnFacturarPublicaciones_Click);
            // 
            // btnCalificarVendedor
            // 
            this.btnCalificarVendedor.Location = new System.Drawing.Point(151, 81);
            this.btnCalificarVendedor.Name = "btnCalificarVendedor";
            this.btnCalificarVendedor.Size = new System.Drawing.Size(149, 23);
            this.btnCalificarVendedor.TabIndex = 7;
            this.btnCalificarVendedor.Text = "Calificar Vendedor";
            this.btnCalificarVendedor.UseVisualStyleBackColor = true;
            this.btnCalificarVendedor.Click += new System.EventHandler(this.btnCalificarVendedor_Click);
            // 
            // btnABMEmpresa
            // 
            this.btnABMEmpresa.Location = new System.Drawing.Point(245, 40);
            this.btnABMEmpresa.Name = "btnABMEmpresa";
            this.btnABMEmpresa.Size = new System.Drawing.Size(112, 23);
            this.btnABMEmpresa.TabIndex = 3;
            this.btnABMEmpresa.Text = "ABM Empresa";
            this.btnABMEmpresa.UseVisualStyleBackColor = true;
            this.btnABMEmpresa.Click += new System.EventHandler(this.btnABMEmpresa_Click);
            // 
            // btnABMCliente
            // 
            this.btnABMCliente.Location = new System.Drawing.Point(151, 40);
            this.btnABMCliente.Name = "btnABMCliente";
            this.btnABMCliente.Size = new System.Drawing.Size(75, 23);
            this.btnABMCliente.TabIndex = 2;
            this.btnABMCliente.Text = "ABM Cliente";
            this.btnABMCliente.UseVisualStyleBackColor = true;
            this.btnABMCliente.Click += new System.EventHandler(this.btnABMCliente_Click);
            // 
            // btnComprarOfertar
            // 
            this.btnComprarOfertar.Location = new System.Drawing.Point(37, 81);
            this.btnComprarOfertar.Name = "btnComprarOfertar";
            this.btnComprarOfertar.Size = new System.Drawing.Size(99, 32);
            this.btnComprarOfertar.TabIndex = 6;
            this.btnComprarOfertar.Text = "Comprar/Ofertar";
            this.btnComprarOfertar.UseVisualStyleBackColor = true;
            this.btnComprarOfertar.Click += new System.EventHandler(this.btnComprarOfertar_Click);
            // 
            // btnListadoEstadistico
            // 
            this.btnListadoEstadistico.Location = new System.Drawing.Point(37, 124);
            this.btnListadoEstadistico.Name = "btnListadoEstadistico";
            this.btnListadoEstadistico.Size = new System.Drawing.Size(149, 27);
            this.btnListadoEstadistico.TabIndex = 10;
            this.btnListadoEstadistico.Text = "Listado Estadístico";
            this.btnListadoEstadistico.UseVisualStyleBackColor = true;
            this.btnListadoEstadistico.Click += new System.EventHandler(this.btnListadoEstadistico_Click);
            // 
            // btnGenerarPublicacion
            // 
            this.btnGenerarPublicacion.Location = new System.Drawing.Point(328, 77);
            this.btnGenerarPublicacion.Name = "btnGenerarPublicacion";
            this.btnGenerarPublicacion.Size = new System.Drawing.Size(122, 27);
            this.btnGenerarPublicacion.TabIndex = 8;
            this.btnGenerarPublicacion.Text = "Generar Publicacion";
            this.btnGenerarPublicacion.UseVisualStyleBackColor = true;
            this.btnGenerarPublicacion.Click += new System.EventHandler(this.btnGenerarPublicacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido!";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsuario,
            this.toolStripRol,
            this.toolStripDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 244);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(648, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripUsuario
            // 
            this.toolStripUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripUsuario.Name = "toolStripUsuario";
            this.toolStripUsuario.Size = new System.Drawing.Size(211, 17);
            this.toolStripUsuario.Spring = true;
            this.toolStripUsuario.Click += new System.EventHandler(this.toolStripUsuario_Click);
            // 
            // toolStripRol
            // 
            this.toolStripRol.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripRol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripRol.Name = "toolStripRol";
            this.toolStripRol.Size = new System.Drawing.Size(211, 17);
            this.toolStripRol.Spring = true;
            // 
            // toolStripDate
            // 
            this.toolStripDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDate.Name = "toolStripDate";
            this.toolStripDate.Size = new System.Drawing.Size(211, 17);
            this.toolStripDate.Spring = true;
            // 
            // tl_UsuariosTableAdapter
            // 
            this.tl_UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tl_RolesTableAdapter
            // 
            this.tl_RolesTableAdapter.ClearBeforeFill = true;
            // 
            // tl_FuncionalidadesTableAdapter
            // 
            this.tl_FuncionalidadesTableAdapter.ClearBeforeFill = true;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 266);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main_form";
            this.Text = "TP GDD";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnABM_Rol;
        private System.Windows.Forms.Button btnABM_Visibilidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarPublicacion;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_UsuariosTableAdapter tl_UsuariosTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RolesTableAdapter tl_RolesTableAdapter;
        private System.Windows.Forms.Button btnListadoEstadistico;
        private System.Windows.Forms.Button btnComprarOfertar;
        private System.Windows.Forms.Button btnABMEmpresa;
        private System.Windows.Forms.Button btnABMCliente;
        private System.Windows.Forms.Button btnCalificarVendedor;
        private System.Windows.Forms.Button btnFacturarPublicaciones;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripRol;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_FuncionalidadesTableAdapter tl_FuncionalidadesTableAdapter;
        private System.Windows.Forms.Button btnABMRubro;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnEditarPublicaciones;
        private System.Windows.Forms.Button btnVerRespuestas;
        private System.Windows.Forms.Button btnResponderPreguntas;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}

