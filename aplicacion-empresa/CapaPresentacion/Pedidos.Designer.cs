namespace CapaPresentacion
{
    partial class Pedidos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCodigoBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscarCodigo = new System.Windows.Forms.Label();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.tableLayoutPanelManipulacion = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPaginacionAtras = new System.Windows.Forms.Button();
            this.buttonPaginacionSiguiente = new System.Windows.Forms.Button();
            this.labelPaginacion = new System.Windows.Forms.Label();
            this.labelAreaDeMensajes = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonMarcadoEntregadoPendiente = new System.Windows.Forms.Button();
            this.tabControlPedidos = new System.Windows.Forms.TabControl();
            this.tabPagePendientes = new System.Windows.Forms.TabPage();
            this.tabPageEntregados = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelGeneral.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.groupBoxBuscar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelManipulacion.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControlPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGeneral
            // 
            this.tableLayoutPanelGeneral.ColumnCount = 1;
            this.tableLayoutPanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneral.Controls.Add(this.tableLayoutPanelTop, 0, 0);
            this.tableLayoutPanelGeneral.Controls.Add(this.tableLayoutPanelBottom, 0, 2);
            this.tableLayoutPanelGeneral.Controls.Add(this.tabControlPedidos, 0, 1);
            this.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral";
            this.tableLayoutPanelGeneral.RowCount = 3;
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGeneral.Size = new System.Drawing.Size(865, 404);
            this.tableLayoutPanelGeneral.TabIndex = 0;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 4;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.4514F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5486F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanelTop.Controls.Add(this.labelTitulo, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.groupBoxBuscar, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanelManipulacion, 3, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonMarcadoEntregadoPendiente, 2, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(859, 96);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Candara", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(235, 96);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "PEDIDOS";
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBuscar.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxBuscar.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxBuscar.Location = new System.Drawing.Point(273, 1);
            this.groupBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 6);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(191, 89);
            this.groupBoxBuscar.TabIndex = 2;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar Pedido";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.5F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxCodigoBuscar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBuscarCodigo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRefrescar, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(177, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxCodigoBuscar
            // 
            this.textBoxCodigoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCodigoBuscar.Location = new System.Drawing.Point(71, 3);
            this.textBoxCodigoBuscar.Name = "textBoxCodigoBuscar";
            this.textBoxCodigoBuscar.Size = new System.Drawing.Size(103, 25);
            this.textBoxCodigoBuscar.TabIndex = 0;
            // 
            // labelBuscarCodigo
            // 
            this.labelBuscarCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBuscarCodigo.AutoSize = true;
            this.labelBuscarCodigo.Location = new System.Drawing.Point(0, 6);
            this.labelBuscarCodigo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelBuscarCodigo.Name = "labelBuscarCodigo";
            this.labelBuscarCodigo.Size = new System.Drawing.Size(56, 18);
            this.labelBuscarCodigo.TabIndex = 1;
            this.labelBuscarCodigo.Text = "Código:";
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefrescar.BackColor = System.Drawing.Color.Orange;
            this.buttonRefrescar.Location = new System.Drawing.Point(68, 31);
            this.buttonRefrescar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(109, 29);
            this.buttonRefrescar.TabIndex = 2;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelManipulacion
            // 
            this.tableLayoutPanelManipulacion.ColumnCount = 3;
            this.tableLayoutPanelManipulacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelManipulacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelManipulacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelManipulacion.Controls.Add(this.buttonAgregar, 2, 0);
            this.tableLayoutPanelManipulacion.Controls.Add(this.buttonEliminar, 1, 0);
            this.tableLayoutPanelManipulacion.Controls.Add(this.buttonEditar, 0, 0);
            this.tableLayoutPanelManipulacion.Location = new System.Drawing.Point(641, 3);
            this.tableLayoutPanelManipulacion.Name = "tableLayoutPanelManipulacion";
            this.tableLayoutPanelManipulacion.RowCount = 1;
            this.tableLayoutPanelManipulacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelManipulacion.Size = new System.Drawing.Size(211, 90);
            this.tableLayoutPanelManipulacion.TabIndex = 0;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.52969F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.47031F));
            this.tableLayoutPanelBottom.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.labelAreaDeMensajes, 0, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(3, 364);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(859, 37);
            this.tableLayoutPanelBottom.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.buttonPaginacionAtras, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonPaginacionSiguiente, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPaginacion, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(480, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 31);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonPaginacionAtras
            // 
            this.buttonPaginacionAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginacionAtras.BackColor = System.Drawing.Color.Orange;
            this.buttonPaginacionAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaginacionAtras.Location = new System.Drawing.Point(136, 0);
            this.buttonPaginacionAtras.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPaginacionAtras.Name = "buttonPaginacionAtras";
            this.buttonPaginacionAtras.Size = new System.Drawing.Size(120, 31);
            this.buttonPaginacionAtras.TabIndex = 0;
            this.buttonPaginacionAtras.Text = "<<";
            this.buttonPaginacionAtras.UseVisualStyleBackColor = false;
            // 
            // buttonPaginacionSiguiente
            // 
            this.buttonPaginacionSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginacionSiguiente.BackColor = System.Drawing.Color.Orange;
            this.buttonPaginacionSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaginacionSiguiente.Location = new System.Drawing.Point(256, 0);
            this.buttonPaginacionSiguiente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPaginacionSiguiente.Name = "buttonPaginacionSiguiente";
            this.buttonPaginacionSiguiente.Size = new System.Drawing.Size(120, 31);
            this.buttonPaginacionSiguiente.TabIndex = 1;
            this.buttonPaginacionSiguiente.Text = ">>";
            this.buttonPaginacionSiguiente.UseVisualStyleBackColor = false;
            // 
            // labelPaginacion
            // 
            this.labelPaginacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPaginacion.AutoSize = true;
            this.labelPaginacion.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaginacion.Location = new System.Drawing.Point(33, 6);
            this.labelPaginacion.Name = "labelPaginacion";
            this.labelPaginacion.Size = new System.Drawing.Size(100, 19);
            this.labelPaginacion.TabIndex = 2;
            this.labelPaginacion.Text = "Página X de X";
            // 
            // labelAreaDeMensajes
            // 
            this.labelAreaDeMensajes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAreaDeMensajes.AutoSize = true;
            this.labelAreaDeMensajes.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAreaDeMensajes.Location = new System.Drawing.Point(3, 9);
            this.labelAreaDeMensajes.Name = "labelAreaDeMensajes";
            this.labelAreaDeMensajes.Size = new System.Drawing.Size(452, 19);
            this.labelAreaDeMensajes.TabIndex = 1;
            this.labelAreaDeMensajes.Text = "Bienvenidos al Sistema de Gestión. Este será su Área de Mensajes";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Image = global::CapaPresentacion.Properties.Resources.agregar;
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAgregar.Location = new System.Drawing.Point(143, 3);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(65, 84);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(73, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(64, 84);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditar.Location = new System.Drawing.Point(3, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(64, 84);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonMarcadoEntregadoPendiente
            // 
            this.buttonMarcadoEntregadoPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMarcadoEntregadoPendiente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMarcadoEntregadoPendiente.Font = new System.Drawing.Font("Candara", 9F);
            this.buttonMarcadoEntregadoPendiente.Image = global::CapaPresentacion.Properties.Resources.marcarEntregadoPendiente;
            this.buttonMarcadoEntregadoPendiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMarcadoEntregadoPendiente.Location = new System.Drawing.Point(470, 7);
            this.buttonMarcadoEntregadoPendiente.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonMarcadoEntregadoPendiente.Name = "buttonMarcadoEntregadoPendiente";
            this.buttonMarcadoEntregadoPendiente.Size = new System.Drawing.Size(165, 82);
            this.buttonMarcadoEntregadoPendiente.TabIndex = 3;
            this.buttonMarcadoEntregadoPendiente.Text = "Marcar Pedido Entregado/Pendiente";
            this.buttonMarcadoEntregadoPendiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMarcadoEntregadoPendiente.UseVisualStyleBackColor = false;
            // 
            // tabControlPedidos
            // 
            this.tabControlPedidos.Controls.Add(this.tabPagePendientes);
            this.tabControlPedidos.Controls.Add(this.tabPageEntregados);
            this.tabControlPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPedidos.Location = new System.Drawing.Point(3, 105);
            this.tabControlPedidos.Name = "tabControlPedidos";
            this.tabControlPedidos.SelectedIndex = 0;
            this.tabControlPedidos.Size = new System.Drawing.Size(859, 253);
            this.tabControlPedidos.TabIndex = 2;
            // 
            // tabPagePendientes
            // 
            this.tabPagePendientes.Location = new System.Drawing.Point(4, 22);
            this.tabPagePendientes.Name = "tabPagePendientes";
            this.tabPagePendientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePendientes.Size = new System.Drawing.Size(851, 227);
            this.tabPagePendientes.TabIndex = 0;
            this.tabPagePendientes.Text = "PENDIENTES";
            this.tabPagePendientes.UseVisualStyleBackColor = true;
            // 
            // tabPageEntregados
            // 
            this.tabPageEntregados.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntregados.Name = "tabPageEntregados";
            this.tabPageEntregados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntregados.Size = new System.Drawing.Size(851, 227);
            this.tabPageEntregados.TabIndex = 1;
            this.tabPageEntregados.Text = "ENTREGADOS";
            this.tabPageEntregados.UseVisualStyleBackColor = true;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelGeneral);
            this.Name = "Pedidos";
            this.Size = new System.Drawing.Size(865, 404);
            this.tableLayoutPanelGeneral.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.groupBoxBuscar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelManipulacion.ResumeLayout(false);
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControlPedidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelManipulacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxCodigoBuscar;
        private System.Windows.Forms.Label labelBuscarCodigo;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonPaginacionAtras;
        private System.Windows.Forms.Button buttonPaginacionSiguiente;
        private System.Windows.Forms.Label labelPaginacion;
        private System.Windows.Forms.Label labelAreaDeMensajes;
        private System.Windows.Forms.Button buttonMarcadoEntregadoPendiente;
        private System.Windows.Forms.TabControl tabControlPedidos;
        private System.Windows.Forms.TabPage tabPagePendientes;
        private System.Windows.Forms.TabPage tabPageEntregados;
    }
}
