namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class VerRespuestas
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
            this.dgvPreguntas = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicacionCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preguntaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuestaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preguntasRespuestasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.preguntas_RespuestasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.Preguntas_RespuestasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preguntasRespuestasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreguntas
            // 
            this.dgvPreguntas.AllowUserToAddRows = false;
            this.dgvPreguntas.AllowUserToDeleteRows = false;
            this.dgvPreguntas.AllowUserToResizeColumns = false;
            this.dgvPreguntas.AllowUserToResizeRows = false;
            this.dgvPreguntas.AutoGenerateColumns = false;
            this.dgvPreguntas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.publicacionCodigoDataGridViewTextBoxColumn,
            this.usuarioIDDataGridViewTextBoxColumn,
            this.preguntaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.respuestaIDDataGridViewTextBoxColumn});
            this.dgvPreguntas.DataSource = this.preguntasRespuestasBindingSource;
            this.dgvPreguntas.Location = new System.Drawing.Point(13, 13);
            this.dgvPreguntas.Name = "dgvPreguntas";
            this.dgvPreguntas.ReadOnly = true;
            this.dgvPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreguntas.Size = new System.Drawing.Size(1047, 507);
            this.dgvPreguntas.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // publicacionCodigoDataGridViewTextBoxColumn
            // 
            this.publicacionCodigoDataGridViewTextBoxColumn.DataPropertyName = "Publicacion_Codigo";
            this.publicacionCodigoDataGridViewTextBoxColumn.HeaderText = "Publicacion_Codigo";
            this.publicacionCodigoDataGridViewTextBoxColumn.Name = "publicacionCodigoDataGridViewTextBoxColumn";
            this.publicacionCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.publicacionCodigoDataGridViewTextBoxColumn.Width = 126;
            // 
            // usuarioIDDataGridViewTextBoxColumn
            // 
            this.usuarioIDDataGridViewTextBoxColumn.DataPropertyName = "Usuario_ID";
            this.usuarioIDDataGridViewTextBoxColumn.HeaderText = "Usuario_ID";
            this.usuarioIDDataGridViewTextBoxColumn.Name = "usuarioIDDataGridViewTextBoxColumn";
            this.usuarioIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioIDDataGridViewTextBoxColumn.Visible = false;
            this.usuarioIDDataGridViewTextBoxColumn.Width = 85;
            // 
            // preguntaDataGridViewTextBoxColumn
            // 
            this.preguntaDataGridViewTextBoxColumn.DataPropertyName = "Pregunta";
            this.preguntaDataGridViewTextBoxColumn.HeaderText = "Pregunta";
            this.preguntaDataGridViewTextBoxColumn.Name = "preguntaDataGridViewTextBoxColumn";
            this.preguntaDataGridViewTextBoxColumn.ReadOnly = true;
            this.preguntaDataGridViewTextBoxColumn.Width = 75;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha Respuesta";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 106;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Respuesta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Respuesta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 83;
            // 
            // respuestaIDDataGridViewTextBoxColumn
            // 
            this.respuestaIDDataGridViewTextBoxColumn.DataPropertyName = "Respuesta_ID";
            this.respuestaIDDataGridViewTextBoxColumn.HeaderText = "Respuesta_ID";
            this.respuestaIDDataGridViewTextBoxColumn.Name = "respuestaIDDataGridViewTextBoxColumn";
            this.respuestaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.respuestaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // preguntasRespuestasBindingSource
            // 
            this.preguntasRespuestasBindingSource.DataMember = "Preguntas_Respuestas";
            this.preguntasRespuestasBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preguntas_RespuestasTableAdapter
            // 
            this.preguntas_RespuestasTableAdapter.ClearBeforeFill = true;
            // 
            // VerRespuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 532);
            this.Controls.Add(this.dgvPreguntas);
            this.Name = "VerRespuestas";
            this.Text = "Ver Respuestas";
            this.Load += new System.EventHandler(this.VerRespuestas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preguntasRespuestasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreguntas;
        private GD1C2014DataSet gD1C2014DataSet;
        //private System.Windows.Forms.DataGridViewTextBoxColumn fechaRespuestaDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn respuestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource preguntasRespuestasBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.Preguntas_RespuestasTableAdapter preguntas_RespuestasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preguntaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuestaIDDataGridViewTextBoxColumn;
    }
}