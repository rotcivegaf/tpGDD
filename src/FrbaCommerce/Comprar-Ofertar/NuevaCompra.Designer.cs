namespace FrbaCommerce.Comprar_Ofertar
{
    partial class NuevaCompra
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
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tl_ClientesyEmpresasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tl_ClientesyEmpresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.tl_ClientesyEmpresasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ClientesyEmpresasTableAdapter();
            this.tableAdapterManager = new FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager();
            this.tl_ComprasTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ComprasTableAdapter();
            this.tl_VisibilidadesTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_ClientesyEmpresasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_ClientesyEmpresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(181, 22);
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStock.TabIndex = 0;
            this.numericUpDownStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca Cantidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datos del vendedor:";
            // 
            // tl_ClientesyEmpresasDataGridView
            // 
            this.tl_ClientesyEmpresasDataGridView.AutoGenerateColumns = false;
            this.tl_ClientesyEmpresasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tl_ClientesyEmpresasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tl_ClientesyEmpresasDataGridView.DataSource = this.tl_ClientesyEmpresasBindingSource;
            this.tl_ClientesyEmpresasDataGridView.Location = new System.Drawing.Point(15, 75);
            this.tl_ClientesyEmpresasDataGridView.Name = "tl_ClientesyEmpresasDataGridView";
            this.tl_ClientesyEmpresasDataGridView.Size = new System.Drawing.Size(1097, 64);
            this.tl_ClientesyEmpresasDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Dom_Calle";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dom_Calle";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nro_Calle";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nro_Calle";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Piso";
            this.dataGridViewTextBoxColumn7.HeaderText = "Piso";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Depto";
            this.dataGridViewTextBoxColumn8.HeaderText = "Depto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cod_Postal";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cod_Postal";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn10.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // tl_ClientesyEmpresasBindingSource
            // 
            this.tl_ClientesyEmpresasBindingSource.DataMember = "tl_ClientesyEmpresas";
            this.tl_ClientesyEmpresasBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tl_ClientesyEmpresasTableAdapter
            // 
            this.tl_ClientesyEmpresasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tl_ClientesTableAdapter = null;
            this.tableAdapterManager.tl_ComprasTableAdapter = null;
            this.tableAdapterManager.tl_EmpresasTableAdapter = null;
            this.tableAdapterManager.tl_Facturas_ItemsTableAdapter = null;
            this.tableAdapterManager.tl_FacturasTableAdapter = null;
            this.tableAdapterManager.tl_FuncionalidadesTableAdapter = null;
            this.tableAdapterManager.tl_OfertasTableAdapter = null;
            this.tableAdapterManager.tl_PendientesTableAdapter = null;
            this.tableAdapterManager.tl_PreguntasTableAdapter = null;
            this.tableAdapterManager.tl_Publicaciones_RubrosTableAdapter = null;
            this.tableAdapterManager.tl_PublicacionesTableAdapter = null;
            this.tableAdapterManager.tl_Roles_FuncionalidadesTableAdapter = null;
            this.tableAdapterManager.tl_RolesTableAdapter = null;
            this.tableAdapterManager.tl_RubrosTableAdapter = null;
            this.tableAdapterManager.tl_Usuarios_RolesTableAdapter = null;
            this.tableAdapterManager.tl_UsuariosTableAdapter = null;
            this.tableAdapterManager.tl_VisibilidadesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tl_ComprasTableAdapter1
            // 
            this.tl_ComprasTableAdapter1.ClearBeforeFill = true;
            // 
            // tl_VisibilidadesTableAdapter1
            // 
            this.tl_VisibilidadesTableAdapter1.ClearBeforeFill = true;
            // 
            // NuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 363);
            this.Controls.Add(this.tl_ClientesyEmpresasDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownStock);
            this.Name = "NuevaCompra";
            this.Text = "NuevaCompra";
            this.Load += new System.EventHandler(this.NuevaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_ClientesyEmpresasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_ClientesyEmpresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tl_ClientesyEmpresasBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ClientesyEmpresasTableAdapter tl_ClientesyEmpresasTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tl_ClientesyEmpresasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_ComprasTableAdapter tl_ComprasTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter tl_VisibilidadesTableAdapter1;
    }
}