namespace FrbaCommerce.ABM_Rol
{
    partial class Edit_Rol_Form
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
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.listFuncionalidades = new System.Windows.Forms.ListBox();
            this.tlFuncionalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.lbFuncionalidades = new System.Windows.Forms.Label();
            this.tl_FuncionalidadesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_FuncionalidadesTableAdapter();
            this.GuardarRol = new System.Windows.Forms.Button();
            this.tlRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_RolesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RolesTableAdapter();
            this.tl_Roles_FuncionalidadesTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Roles_FuncionalidadesTableAdapter();
            this.Habilitado = new System.Windows.Forms.CheckBox();
            this.tl_Usuarios_RolesTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Usuarios_RolesTableAdapter();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tlFuncionalidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(38, 54);
            this.inputNombre.MaxLength = 50;
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(170, 20);
            this.inputNombre.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(35, 26);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // listFuncionalidades
            // 
            this.listFuncionalidades.DataSource = this.tlFuncionalidadesBindingSource;
            this.listFuncionalidades.DisplayMember = "Nombre";
            this.listFuncionalidades.FormattingEnabled = true;
            this.listFuncionalidades.Location = new System.Drawing.Point(38, 123);
            this.listFuncionalidades.Name = "listFuncionalidades";
            this.listFuncionalidades.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listFuncionalidades.Size = new System.Drawing.Size(170, 173);
            this.listFuncionalidades.TabIndex = 1;
            this.listFuncionalidades.ValueMember = "ID";
            // 
            // tlFuncionalidadesBindingSource
            // 
            this.tlFuncionalidadesBindingSource.DataMember = "tl_Funcionalidades";
            this.tlFuncionalidadesBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbFuncionalidades
            // 
            this.lbFuncionalidades.AutoSize = true;
            this.lbFuncionalidades.Location = new System.Drawing.Point(35, 91);
            this.lbFuncionalidades.Name = "lbFuncionalidades";
            this.lbFuncionalidades.Size = new System.Drawing.Size(84, 13);
            this.lbFuncionalidades.TabIndex = 3;
            this.lbFuncionalidades.Text = "Funcionalidades";
            // 
            // tl_FuncionalidadesTableAdapter
            // 
            this.tl_FuncionalidadesTableAdapter.ClearBeforeFill = true;
            // 
            // GuardarRol
            // 
            this.GuardarRol.Location = new System.Drawing.Point(127, 359);
            this.GuardarRol.Name = "GuardarRol";
            this.GuardarRol.Size = new System.Drawing.Size(81, 23);
            this.GuardarRol.TabIndex = 4;
            this.GuardarRol.Text = "Guardar";
            this.GuardarRol.UseVisualStyleBackColor = true;
            this.GuardarRol.Click += new System.EventHandler(this.GuardarRol_Click);
            // 
            // tlRolesBindingSource
            // 
            this.tlRolesBindingSource.DataMember = "tl_Roles";
            this.tlRolesBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // tl_RolesTableAdapter
            // 
            this.tl_RolesTableAdapter.ClearBeforeFill = true;
            // 
            // tl_Roles_FuncionalidadesTableAdapter1
            // 
            this.tl_Roles_FuncionalidadesTableAdapter1.ClearBeforeFill = true;
            // 
            // Habilitado
            // 
            this.Habilitado.AutoSize = true;
            this.Habilitado.Location = new System.Drawing.Point(38, 321);
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.Size = new System.Drawing.Size(73, 17);
            this.Habilitado.TabIndex = 5;
            this.Habilitado.Text = "Habilitado";
            this.Habilitado.UseVisualStyleBackColor = true;
            // 
            // tl_Usuarios_RolesTableAdapter1
            // 
            this.tl_Usuarios_RolesTableAdapter1.ClearBeforeFill = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(38, 359);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Edit_Rol_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 411);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Habilitado);
            this.Controls.Add(this.GuardarRol);
            this.Controls.Add(this.lbFuncionalidades);
            this.Controls.Add(this.listFuncionalidades);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.inputNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Edit_Rol_Form";
            this.Text = "Crear/Editar Rol";
            this.Load += new System.EventHandler(this.Edit_Rol_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlFuncionalidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.ListBox listFuncionalidades;
        private System.Windows.Forms.Label lbFuncionalidades;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tlFuncionalidadesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_FuncionalidadesTableAdapter tl_FuncionalidadesTableAdapter;
        private System.Windows.Forms.Button GuardarRol;
        private System.Windows.Forms.BindingSource tlRolesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RolesTableAdapter tl_RolesTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Roles_FuncionalidadesTableAdapter tl_Roles_FuncionalidadesTableAdapter1;
        private System.Windows.Forms.CheckBox Habilitado;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_Usuarios_RolesTableAdapter tl_Usuarios_RolesTableAdapter1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}