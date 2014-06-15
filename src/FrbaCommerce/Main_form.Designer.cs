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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tl_UsuariosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_UsuariosTableAdapter();
            this.tl_RolesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RolesTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.button2);
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
            // tl_UsuariosTableAdapter
            // 
            this.tl_UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tl_RolesTableAdapter
            // 
            this.tl_RolesTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Comprar Ofertar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main_form";
            this.Text = "TP GDD";
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2;
    }
}

