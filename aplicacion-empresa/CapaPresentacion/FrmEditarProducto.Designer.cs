namespace CapaPresentacion
{
    partial class FrmEditarProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxDetalles = new System.Windows.Forms.TextBox();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Detalles:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(196, 12);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(319, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(196, 83);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(319, 20);
            this.textBoxPrecio.TabIndex = 6;
            // 
            // textBoxDetalles
            // 
            this.textBoxDetalles.Location = new System.Drawing.Point(196, 124);
            this.textBoxDetalles.Multiline = true;
            this.textBoxDetalles.Name = "textBoxDetalles";
            this.textBoxDetalles.Size = new System.Drawing.Size(319, 124);
            this.textBoxDetalles.TabIndex = 7;
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(196, 47);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(319, 21);
            this.comboBoxCategorias.TabIndex = 8;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(380, 254);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 34);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(232, 254);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(100, 34);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 300);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.textBoxDetalles);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxDetalles;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}