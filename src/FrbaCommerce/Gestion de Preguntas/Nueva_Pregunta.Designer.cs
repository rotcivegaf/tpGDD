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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.buttonPreguntar = new System.Windows.Forms.Button();
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.tl_PreguntasTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PreguntasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta:";
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(64, 12);
            this.textBoxPregunta.MaxLength = 255;
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(354, 20);
            this.textBoxPregunta.TabIndex = 1;
            // 
            // buttonPreguntar
            // 
            this.buttonPreguntar.Location = new System.Drawing.Point(172, 62);
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
            // tl_PreguntasTableAdapter
            // 
            this.tl_PreguntasTableAdapter.ClearBeforeFill = true;
            // 
            // Nueva_Pregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 99);
            this.Controls.Add(this.buttonPreguntar);
            this.Controls.Add(this.textBoxPregunta);
            this.Controls.Add(this.label1);
            this.Name = "Nueva_Pregunta";
            this.Text = "Nueva_Pregunta";
            this.Load += new System.EventHandler(this.Nueva_Pregunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.Button buttonPreguntar;
        private GD1C2014DataSet gD1C2014DataSet;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_PreguntasTableAdapter tl_PreguntasTableAdapter;
    }
}