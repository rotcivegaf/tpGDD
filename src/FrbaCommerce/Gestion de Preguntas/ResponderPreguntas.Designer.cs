namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class ResponderPreguntas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPreguntas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicacion_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlPreguntasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.grpRespuesta = new System.Windows.Forms.GroupBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.Button();
            this.tl_PreguntasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PreguntasTableAdapter();
            this.tl_RespuestasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RespuestasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPreguntasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.grpRespuesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPreguntas
            // 
            this.dgvPreguntas.AllowUserToAddRows = false;
            this.dgvPreguntas.AllowUserToDeleteRows = false;
            this.dgvPreguntas.AutoGenerateColumns = false;
            this.dgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Publicacion_Codigo,
            this.Pregunta,
            this.Usuario_ID,
            this.Responder});
            this.dgvPreguntas.DataSource = this.tlPreguntasBindingSource;
            this.dgvPreguntas.Location = new System.Drawing.Point(12, 13);
            this.dgvPreguntas.Name = "dgvPreguntas";
            this.dgvPreguntas.ReadOnly = true;
            this.dgvPreguntas.Size = new System.Drawing.Size(581, 252);
            this.dgvPreguntas.TabIndex = 0;
            this.dgvPreguntas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreguntas_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Publicacion_Codigo
            // 
            this.Publicacion_Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Publicacion_Codigo.DataPropertyName = "Publicacion_Codigo";
            this.Publicacion_Codigo.HeaderText = "Publicacion_Codigo";
            this.Publicacion_Codigo.Name = "Publicacion_Codigo";
            this.Publicacion_Codigo.ReadOnly = true;
            this.Publicacion_Codigo.Width = 126;
            // 
            // Pregunta
            // 
            this.Pregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pregunta.DataPropertyName = "Pregunta";
            this.Pregunta.HeaderText = "Pregunta";
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.ReadOnly = true;
            this.Pregunta.Width = 75;
            // 
            // Usuario_ID
            // 
            this.Usuario_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Usuario_ID.DataPropertyName = "Usuario_ID";
            this.Usuario_ID.HeaderText = "Usuario_ID";
            this.Usuario_ID.Name = "Usuario_ID";
            this.Usuario_ID.ReadOnly = true;
            this.Usuario_ID.Visible = false;
            // 
            // Responder
            // 
            this.Responder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Responder";
            this.Responder.DefaultCellStyle = dataGridViewCellStyle1;
            this.Responder.HeaderText = "Responder";
            this.Responder.Name = "Responder";
            this.Responder.ReadOnly = true;
            this.Responder.Width = 65;
            // 
            // tlPreguntasBindingSource
            // 
            this.tlPreguntasBindingSource.DataMember = "tl_Preguntas";
            this.tlPreguntasBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpRespuesta
            // 
            this.grpRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpRespuesta.Controls.Add(this.txtRespuesta);
            this.grpRespuesta.Controls.Add(this.lblRespuesta);
            this.grpRespuesta.Controls.Add(this.btnResponder);
            this.grpRespuesta.Enabled = false;
            this.grpRespuesta.Location = new System.Drawing.Point(12, 271);
            this.grpRespuesta.Name = "grpRespuesta";
            this.grpRespuesta.Size = new System.Drawing.Size(581, 81);
            this.grpRespuesta.TabIndex = 2;
            this.grpRespuesta.TabStop = false;
            this.grpRespuesta.Text = "Respuesta";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Enabled = false;
            this.txtRespuesta.Location = new System.Drawing.Point(70, 20);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(494, 20);
            this.txtRespuesta.TabIndex = 5;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(6, 23);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(58, 13);
            this.lblRespuesta.TabIndex = 3;
            this.lblRespuesta.Text = "Respuesta";
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(500, 52);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(75, 23);
            this.btnResponder.TabIndex = 2;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // tl_PreguntasTableAdapter
            // 
            this.tl_PreguntasTableAdapter.ClearBeforeFill = true;
            // 
            // tl_RespuestasTableAdapter
            // 
            this.tl_RespuestasTableAdapter.ClearBeforeFill = true;
            // 
            // ResponderPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(605, 365);
            this.Controls.Add(this.grpRespuesta);
            this.Controls.Add(this.dgvPreguntas);
            this.Name = "ResponderPreguntas";
            this.Text = "Responder Preguntas";
            this.Load += new System.EventHandler(this.Preguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPreguntasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.grpRespuesta.ResumeLayout(false);
            this.grpRespuesta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreguntas;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource tlPreguntasBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PreguntasTableAdapter tl_PreguntasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicacion_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Respuesta;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Respuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_ID;
        private System.Windows.Forms.DataGridViewButtonColumn Responder;
        private System.Windows.Forms.GroupBox grpRespuesta;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.TextBox txtRespuesta;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_RespuestasTableAdapter tl_RespuestasTableAdapter;
    }
}