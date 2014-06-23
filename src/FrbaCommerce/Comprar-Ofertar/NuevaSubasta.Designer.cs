namespace FrbaCommerce.Comprar_Ofertar
{
    partial class NuevaSubasta
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
            this.buttonOfertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownOferta = new System.Windows.Forms.NumericUpDown();
            this.tl_OfertasTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_OfertasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOferta)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOfertar
            // 
            this.buttonOfertar.Location = new System.Drawing.Point(309, 28);
            this.buttonOfertar.Name = "buttonOfertar";
            this.buttonOfertar.Size = new System.Drawing.Size(75, 23);
            this.buttonOfertar.TabIndex = 5;
            this.buttonOfertar.Text = "Ofertar";
            this.buttonOfertar.UseVisualStyleBackColor = true;
            this.buttonOfertar.Click += new System.EventHandler(this.buttonOfertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduzca Oferta:";
            // 
            // numericUpDownOferta
            // 
            this.numericUpDownOferta.Location = new System.Drawing.Point(156, 31);
            this.numericUpDownOferta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownOferta.Name = "numericUpDownOferta";
            this.numericUpDownOferta.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownOferta.TabIndex = 3;
            this.numericUpDownOferta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tl_OfertasTableAdapter1
            // 
            this.tl_OfertasTableAdapter1.ClearBeforeFill = true;
            // 
            // NuevaSubasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 82);
            this.Controls.Add(this.buttonOfertar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownOferta);
            this.Name = "NuevaSubasta";
            this.Text = "NuevaOferta";
            this.Load += new System.EventHandler(this.NuevaSubasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOferta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOfertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownOferta;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_OfertasTableAdapter tl_OfertasTableAdapter1;
    }
}