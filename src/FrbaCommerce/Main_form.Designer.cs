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
            this.btnHistorialCliente = new System.Windows.Forms.Button();
            this.btnABMRubro = new System.Windows.Forms.Button();
            this.btnFacturarPublicaciones = new System.Windows.Forms.Button();
            this.btnCalificarVendedor = new System.Windows.Forms.Button();
            this.btnABMEmpresa = new System.Windows.Forms.Button();
            this.btnABMCliente = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnListadoEstadistico = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tl_UsuariosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_UsuariosTableAdapter();
            this.tl_RolesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RolesTableAdapter();
            this.tl_FuncionalidadesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_FuncionalidadesTableAdapter();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(578, 23);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(58, 27);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnABM_Rol
            // 
            this.btnABM_Rol.Location = new System.Drawing.Point(37, 38);
            this.btnABM_Rol.Name = "btnABM_Rol";
            this.btnABM_Rol.Size = new System.Drawing.Size(75, 27);
            this.btnABM_Rol.TabIndex = 2;
            this.btnABM_Rol.Text = "ABM Rol";
            this.btnABM_Rol.UseVisualStyleBackColor = true;
            this.btnABM_Rol.Click += new System.EventHandler(this.btnABM_Rol_Click);
            // 
            // btnABM_Visibilidades
            // 
            this.btnABM_Visibilidades.Location = new System.Drawing.Point(136, 38);
            this.btnABM_Visibilidades.Name = "btnABM_Visibilidades";
            this.btnABM_Visibilidades.Size = new System.Drawing.Size(112, 27);
            this.btnABM_Visibilidades.TabIndex = 3;
            this.btnABM_Visibilidades.Text = "ABM Visibilidades";
            this.btnABM_Visibilidades.UseVisualStyleBackColor = true;
            this.btnABM_Visibilidades.Click += new System.EventHandler(this.btnABM_Visibilidades_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHistorialCliente);
            this.groupBox1.Controls.Add(this.btnABMRubro);
            this.groupBox1.Controls.Add(this.btnFacturarPublicaciones);
            this.groupBox1.Controls.Add(this.btnCalificarVendedor);
            this.groupBox1.Controls.Add(this.btnABMEmpresa);
            this.groupBox1.Controls.Add(this.btnABMCliente);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnListadoEstadistico);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnABM_Rol);
            this.groupBox1.Controls.Add(this.btnABM_Visibilidades);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 184);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionaliades";
            // 
            // btnHistorialCliente
            // 
            this.btnHistorialCliente.Location = new System.Drawing.Point(274, 128);
            this.btnHistorialCliente.Name = "btnHistorialCliente";
            this.btnHistorialCliente.Size = new System.Drawing.Size(122, 23);
            this.btnHistorialCliente.TabIndex = 10;
            this.btnHistorialCliente.Text = "Historial Cliente";
            this.btnHistorialCliente.UseVisualStyleBackColor = true;
            this.btnHistorialCliente.Click += new System.EventHandler(this.btnHistorialCliente_Click);
            // 
            // btnABMRubro
            // 
            this.btnABMRubro.Enabled = false;
            this.btnABMRubro.Location = new System.Drawing.Point(136, 128);
            this.btnABMRubro.Name = "btnABMRubro";
            this.btnABMRubro.Size = new System.Drawing.Size(75, 23);
            this.btnABMRubro.TabIndex = 9;
            this.btnABMRubro.Text = "ABM Rubro";
            this.btnABMRubro.UseVisualStyleBackColor = true;
            // 
            // btnFacturarPublicaciones
            // 
            this.btnFacturarPublicaciones.Location = new System.Drawing.Point(37, 128);
            this.btnFacturarPublicaciones.Name = "btnFacturarPublicaciones";
            this.btnFacturarPublicaciones.Size = new System.Drawing.Size(88, 39);
            this.btnFacturarPublicaciones.TabIndex = 8;
            this.btnFacturarPublicaciones.Text = "Facturar Publicaciones";
            this.btnFacturarPublicaciones.UseVisualStyleBackColor = true;
            this.btnFacturarPublicaciones.Click += new System.EventHandler(this.btnFacturarPublicaciones_Click);
            // 
            // btnCalificarVendedor
            // 
            this.btnCalificarVendedor.Location = new System.Drawing.Point(415, 86);
            this.btnCalificarVendedor.Name = "btnCalificarVendedor";
            this.btnCalificarVendedor.Size = new System.Drawing.Size(149, 23);
            this.btnCalificarVendedor.TabIndex = 7;
            this.btnCalificarVendedor.Text = "Calificar Vendedor";
            this.btnCalificarVendedor.UseVisualStyleBackColor = true;
            this.btnCalificarVendedor.Click += new System.EventHandler(this.btnCalificarVendedor_Click);
            // 
            // btnABMEmpresa
            // 
            this.btnABMEmpresa.Location = new System.Drawing.Point(136, 86);
            this.btnABMEmpresa.Name = "btnABMEmpresa";
            this.btnABMEmpresa.Size = new System.Drawing.Size(112, 23);
            this.btnABMEmpresa.TabIndex = 5;
            this.btnABMEmpresa.Text = "ABM Empresa";
            this.btnABMEmpresa.UseVisualStyleBackColor = true;
            this.btnABMEmpresa.Click += new System.EventHandler(this.btnABMEmpresa_Click);
            // 
            // btnABMCliente
            // 
            this.btnABMCliente.Location = new System.Drawing.Point(37, 86);
            this.btnABMCliente.Name = "btnABMCliente";
            this.btnABMCliente.Size = new System.Drawing.Size(75, 23);
            this.btnABMCliente.TabIndex = 5;
            this.btnABMCliente.Text = "ABM Cliente";
            this.btnABMCliente.UseVisualStyleBackColor = true;
            this.btnABMCliente.Click += new System.EventHandler(this.btnABMCliente_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Comprar/Ofertar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnListadoEstadistico
            // 
            this.btnListadoEstadistico.Location = new System.Drawing.Point(415, 38);
            this.btnListadoEstadistico.Name = "btnListadoEstadistico";
            this.btnListadoEstadistico.Size = new System.Drawing.Size(149, 27);
            this.btnListadoEstadistico.TabIndex = 5;
            this.btnListadoEstadistico.Text = "Listado Estadístico";
            this.btnListadoEstadistico.UseVisualStyleBackColor = true;
            this.btnListadoEstadistico.Click += new System.EventHandler(this.btnListadoEstadistico_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar Publicacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 301);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(648, 22);
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
            this.ClientSize = new System.Drawing.Size(648, 323);
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
        private System.Windows.Forms.Button button1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_UsuariosTableAdapter tl_UsuariosTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RolesTableAdapter tl_RolesTableAdapter;
        private System.Windows.Forms.Button btnListadoEstadistico;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Button btnHistorialCliente;
    }
}

