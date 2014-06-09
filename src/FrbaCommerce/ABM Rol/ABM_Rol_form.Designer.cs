namespace FrbaCommerce.ABM_Rol
{
    partial class ABM_Rol_Form
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
            this.Roles = new System.Windows.Forms.DataGridView();
            this.NuevoRol = new System.Windows.Forms.Button();
            this.EditarRol = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tlRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.tl_RolesTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RolesTableAdapter();
            this.EliminarRol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Roles
            // 
            this.Roles.AllowUserToAddRows = false;
            this.Roles.AllowUserToDeleteRows = false;
            this.Roles.AutoGenerateColumns = false;
            this.Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.habilitadoDataGridViewCheckBoxColumn});
            this.Roles.DataSource = this.tlRolesBindingSource;
            this.Roles.Location = new System.Drawing.Point(12, 70);
            this.Roles.MultiSelect = false;
            this.Roles.Name = "Roles";
            this.Roles.ReadOnly = true;
            this.Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Roles.Size = new System.Drawing.Size(360, 247);
            this.Roles.TabIndex = 0;
            // 
            // NuevoRol
            // 
            this.NuevoRol.Location = new System.Drawing.Point(12, 24);
            this.NuevoRol.Name = "NuevoRol";
            this.NuevoRol.Size = new System.Drawing.Size(108, 23);
            this.NuevoRol.TabIndex = 1;
            this.NuevoRol.Text = "Nuevo";
            this.NuevoRol.UseVisualStyleBackColor = true;
            this.NuevoRol.Click += new System.EventHandler(this.NuevoRol_Click);
            // 
            // EditarRol
            // 
            this.EditarRol.Location = new System.Drawing.Point(138, 24);
            this.EditarRol.Name = "EditarRol";
            this.EditarRol.Size = new System.Drawing.Size(108, 23);
            this.EditarRol.TabIndex = 2;
            this.EditarRol.Text = "Editar";
            this.EditarRol.UseVisualStyleBackColor = true;
            this.EditarRol.Click += new System.EventHandler(this.EditarRol_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // habilitadoDataGridViewCheckBoxColumn
            // 
            this.habilitadoDataGridViewCheckBoxColumn.DataPropertyName = "Habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.HeaderText = "Habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.Name = "habilitadoDataGridViewCheckBoxColumn";
            this.habilitadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tlRolesBindingSource
            // 
            this.tlRolesBindingSource.DataMember = "tl_Roles";
            this.tlRolesBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tl_RolesTableAdapter
            // 
            this.tl_RolesTableAdapter.ClearBeforeFill = true;
            // 
            // EliminarRol
            // 
            this.EliminarRol.Location = new System.Drawing.Point(263, 24);
            this.EliminarRol.Name = "EliminarRol";
            this.EliminarRol.Size = new System.Drawing.Size(109, 23);
            this.EliminarRol.TabIndex = 3;
            this.EliminarRol.Text = "Eliminar";
            this.EliminarRol.UseVisualStyleBackColor = true;
            this.EliminarRol.Click += new System.EventHandler(this.EliminarRol_Click);
            // 
            // ABM_Rol_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 329);
            this.Controls.Add(this.EliminarRol);
            this.Controls.Add(this.EditarRol);
            this.Controls.Add(this.NuevoRol);
            this.Controls.Add(this.Roles);
            this.Name = "ABM_Rol_Form";
            this.Text = "ABM Rol";
            this.Load += new System.EventHandler(this.ABM_Rol_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Roles;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tlRolesBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RolesTableAdapter tl_RolesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button NuevoRol;
        private System.Windows.Forms.Button EditarRol;
        private System.Windows.Forms.Button EliminarRol;
    }
}