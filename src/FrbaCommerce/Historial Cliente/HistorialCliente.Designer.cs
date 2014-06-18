namespace FrbaCommerce.Historial_Cliente
{
    partial class HistorialCliente
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
            this.optCompras = new System.Windows.Forms.RadioButton();
            this.optOfertas = new System.Windows.Forms.RadioButton();
            this.optCalificaciones = new System.Windows.Forms.RadioButton();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // optCompras
            // 
            this.optCompras.AutoSize = true;
            this.optCompras.Location = new System.Drawing.Point(94, 12);
            this.optCompras.Name = "optCompras";
            this.optCompras.Size = new System.Drawing.Size(66, 17);
            this.optCompras.TabIndex = 0;
            this.optCompras.TabStop = true;
            this.optCompras.Text = "Compras";
            this.optCompras.UseVisualStyleBackColor = true;
            this.optCompras.CheckedChanged += new System.EventHandler(this.optCompras_CheckedChanged);
            // 
            // optOfertas
            // 
            this.optOfertas.AutoSize = true;
            this.optOfertas.Location = new System.Drawing.Point(300, 12);
            this.optOfertas.Name = "optOfertas";
            this.optOfertas.Size = new System.Drawing.Size(59, 17);
            this.optOfertas.TabIndex = 1;
            this.optOfertas.TabStop = true;
            this.optOfertas.Text = "Ofertas";
            this.optOfertas.UseVisualStyleBackColor = true;
            this.optOfertas.CheckedChanged += new System.EventHandler(this.optOfertas_CheckedChanged);
            // 
            // optCalificaciones
            // 
            this.optCalificaciones.AutoSize = true;
            this.optCalificaciones.Location = new System.Drawing.Point(497, 12);
            this.optCalificaciones.Name = "optCalificaciones";
            this.optCalificaciones.Size = new System.Drawing.Size(90, 17);
            this.optCalificaciones.TabIndex = 2;
            this.optCalificaciones.TabStop = true;
            this.optCalificaciones.Text = "Calificaciones";
            this.optCalificaciones.UseVisualStyleBackColor = true;
            this.optCalificaciones.CheckedChanged += new System.EventHandler(this.optCalificaciones_CheckedChanged);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(13, 86);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(790, 528);
            this.dgvHistorial.TabIndex = 3;
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 626);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.optCalificaciones);
            this.Controls.Add(this.optOfertas);
            this.Controls.Add(this.optCompras);
            this.Name = "HistorialCliente";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optCompras;
        private System.Windows.Forms.RadioButton optOfertas;
        private System.Windows.Forms.RadioButton optCalificaciones;
        private System.Windows.Forms.DataGridView dgvHistorial;
    }
}