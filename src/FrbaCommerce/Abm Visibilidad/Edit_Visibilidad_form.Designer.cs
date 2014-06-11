namespace FrbaCommerce.ABM_Visibilidad
{
    partial class Edit_Visibilidad_Form
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
            this.inputCodigo = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.tl_VisibilidadesTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter();
            this.inputDescripcion = new System.Windows.Forms.TextBox();
            this.inputPrecio = new System.Windows.Forms.TextBox();
            this.inputPorcentaje = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbPorcentaje = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputCodigo
            // 
            this.inputCodigo.Location = new System.Drawing.Point(12, 33);
            this.inputCodigo.Name = "inputCodigo";
            this.inputCodigo.Size = new System.Drawing.Size(228, 20);
            this.inputCodigo.TabIndex = 0;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(138, 227);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(104, 23);
            this.Guardar.TabIndex = 1;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // tl_VisibilidadesTableAdapter1
            // 
            this.tl_VisibilidadesTableAdapter1.ClearBeforeFill = true;
            // 
            // inputDescripcion
            // 
            this.inputDescripcion.Location = new System.Drawing.Point(12, 87);
            this.inputDescripcion.Name = "inputDescripcion";
            this.inputDescripcion.Size = new System.Drawing.Size(230, 20);
            this.inputDescripcion.TabIndex = 2;
            // 
            // inputPrecio
            // 
            this.inputPrecio.Location = new System.Drawing.Point(12, 140);
            this.inputPrecio.Name = "inputPrecio";
            this.inputPrecio.Size = new System.Drawing.Size(228, 20);
            this.inputPrecio.TabIndex = 4;
            // 
            // inputPorcentaje
            // 
            this.inputPorcentaje.AcceptsReturn = true;
            this.inputPorcentaje.Location = new System.Drawing.Point(12, 191);
            this.inputPorcentaje.Name = "inputPorcentaje";
            this.inputPorcentaje.Size = new System.Drawing.Size(228, 20);
            this.inputPorcentaje.TabIndex = 5;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(9, 17);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 6;
            this.lbCodigo.Text = "Codigo";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(9, 71);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 7;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(9, 124);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(67, 13);
            this.lbPrecio.TabIndex = 8;
            this.lbPrecio.Text = "Precio en ($)";
            // 
            // lbPorcentaje
            // 
            this.lbPorcentaje.AutoSize = true;
            this.lbPorcentaje.Location = new System.Drawing.Point(9, 175);
            this.lbPorcentaje.Name = "lbPorcentaje";
            this.lbPorcentaje.Size = new System.Drawing.Size(58, 13);
            this.lbPorcentaje.TabIndex = 9;
            this.lbPorcentaje.Text = "Porcentaje";
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(12, 227);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(104, 23);
            this.Limpiar.TabIndex = 10;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Edit_Visibilidad_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 278);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.lbPorcentaje);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.inputPorcentaje);
            this.Controls.Add(this.inputPrecio);
            this.Controls.Add(this.inputDescripcion);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.inputCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Edit_Visibilidad_Form";
            this.Text = "Crear/Editar Visibilidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputCodigo;
        private System.Windows.Forms.Button Guardar;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.tl_VisibilidadesTableAdapter tl_VisibilidadesTableAdapter1;
        private System.Windows.Forms.TextBox inputDescripcion;
        private System.Windows.Forms.TextBox inputPrecio;
        private System.Windows.Forms.TextBox inputPorcentaje;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbPorcentaje;
        private System.Windows.Forms.Button Limpiar;
    }
}