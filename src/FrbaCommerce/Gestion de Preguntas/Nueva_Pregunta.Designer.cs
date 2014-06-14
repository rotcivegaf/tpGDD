namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class Nueva_Pregunta
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.buttonPreguntar = new System.Windows.Forms.Button();
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.tl_PreguntasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tl_PreguntasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PreguntasTableAdapter();
            this.tableAdapterManager = new FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PreguntasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta:";
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(67, 104);
            this.textBoxPregunta.MaxLength = 255;
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(213, 20);
            this.textBoxPregunta.TabIndex = 1;
            // 
            // buttonPreguntar
            // 
            this.buttonPreguntar.Location = new System.Drawing.Point(97, 192);
            this.buttonPreguntar.Name = "buttonPreguntar";
            this.buttonPreguntar.Size = new System.Drawing.Size(75, 23);
            this.buttonPreguntar.TabIndex = 2;
            this.buttonPreguntar.Text = "Preguntar";
            this.buttonPreguntar.UseVisualStyleBackColor = true;
            this.buttonPreguntar.Click += new System.EventHandler(this.buttonPreguntar_Click);
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tl_PreguntasBindingSource
            // 
            this.tl_PreguntasBindingSource.DataMember = "tl_Preguntas";
            this.tl_PreguntasBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // tl_PreguntasTableAdapter
            // 
            this.tl_PreguntasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tl_ClientesTableAdapter = null;
            this.tableAdapterManager.tl_ComprasTableAdapter = null;
            this.tableAdapterManager.tl_EmpresasTableAdapter = null;
            this.tableAdapterManager.tl_Facturas_ItemsTableAdapter = null;
            this.tableAdapterManager.tl_FacturasTableAdapter = null;
            this.tableAdapterManager.tl_FuncionalidadesTableAdapter = null;
            this.tableAdapterManager.tl_OfertasTableAdapter = null;
            this.tableAdapterManager.tl_PendientesTableAdapter = null;
            this.tableAdapterManager.tl_PreguntasTableAdapter = this.tl_PreguntasTableAdapter;
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
            // Nueva_Pregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 291);
            this.Controls.Add(this.buttonPreguntar);
            this.Controls.Add(this.textBoxPregunta);
            this.Controls.Add(this.label1);
            this.Name = "Nueva_Pregunta";
            this.Text = "Nueva_Pregunta";
            this.Load += new System.EventHandler(this.Nueva_Pregunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_PreguntasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.Button buttonPreguntar;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tl_PreguntasBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PreguntasTableAdapter tl_PreguntasTableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}