namespace FrbaCommerce.Registro_de_Usuario
{
    partial class RegistroUsuario
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.optCliente = new System.Windows.Forms.RadioButton();
            this.btnCrear = new System.Windows.Forms.Button();
            this.optEmpresa = new System.Windows.Forms.RadioButton();
            this.tl_UsuariosTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_UsuariosTableAdapter();
            this.tl_Usuarios_RolesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Usuarios_RolesTableAdapter();
            this.grp = new System.Windows.Forms.GroupBox();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(13, 13);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(75, 13);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 43);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(75, 43);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // optCliente
            // 
            this.optCliente.AutoSize = true;
            this.optCliente.Location = new System.Drawing.Point(8, 21);
            this.optCliente.Name = "optCliente";
            this.optCliente.Size = new System.Drawing.Size(57, 17);
            this.optCliente.TabIndex = 4;
            this.optCliente.TabStop = true;
            this.optCliente.Text = "Cliente";
            this.optCliente.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(100, 157);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // optEmpresa
            // 
            this.optEmpresa.AutoSize = true;
            this.optEmpresa.Location = new System.Drawing.Point(8, 45);
            this.optEmpresa.Name = "optEmpresa";
            this.optEmpresa.Size = new System.Drawing.Size(66, 17);
            this.optEmpresa.TabIndex = 7;
            this.optEmpresa.TabStop = true;
            this.optEmpresa.Text = "Empresa";
            this.optEmpresa.UseVisualStyleBackColor = true;
            // 
            // tl_UsuariosTableAdapter
            // 
            this.tl_UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tl_Usuarios_RolesTableAdapter
            // 
            this.tl_Usuarios_RolesTableAdapter.ClearBeforeFill = true;
            // 
            // grp
            // 
            this.grp.Controls.Add(this.optEmpresa);
            this.grp.Controls.Add(this.optCliente);
            this.grp.Location = new System.Drawing.Point(16, 69);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(159, 78);
            this.grp.TabIndex = 8;
            this.grp.TabStop = false;
            this.grp.Text = "Rol";
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 192);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "RegistroUsuario";
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton optCliente;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.RadioButton optEmpresa;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_UsuariosTableAdapter tl_UsuariosTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Usuarios_RolesTableAdapter tl_Usuarios_RolesTableAdapter;
        private System.Windows.Forms.GroupBox grp;
    }
}