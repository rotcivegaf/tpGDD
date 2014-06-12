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
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(58, 27);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnABM_Rol
            // 
            this.btnABM_Rol.Location = new System.Drawing.Point(76, 12);
            this.btnABM_Rol.Name = "btnABM_Rol";
            this.btnABM_Rol.Size = new System.Drawing.Size(75, 27);
            this.btnABM_Rol.TabIndex = 2;
            this.btnABM_Rol.Text = "ABM Rol";
            this.btnABM_Rol.UseVisualStyleBackColor = true;
            this.btnABM_Rol.Click += new System.EventHandler(this.btnABM_Rol_Click);
            // 
            // btnABM_Visibilidades
            // 
            this.btnABM_Visibilidades.Location = new System.Drawing.Point(157, 12);
            this.btnABM_Visibilidades.Name = "btnABM_Visibilidades";
            this.btnABM_Visibilidades.Size = new System.Drawing.Size(112, 27);
            this.btnABM_Visibilidades.TabIndex = 3;
            this.btnABM_Visibilidades.Text = "ABM Visibilidades";
            this.btnABM_Visibilidades.UseVisualStyleBackColor = true;
            this.btnABM_Visibilidades.Click += new System.EventHandler(this.btnABM_Visibilidades_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnABM_Visibilidades);
            this.Controls.Add(this.btnABM_Rol);
            this.Controls.Add(this.btnLogin);
            this.Name = "Main_form";
            this.Text = "TP GDD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnABM_Rol;
        private System.Windows.Forms.Button btnABM_Visibilidades;
    }
}

