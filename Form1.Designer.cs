namespace Trabajo_Final_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarFactura = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.nudCuit = new System.Windows.Forms.NumericUpDown();
            this.nudFactura = new System.Windows.Forms.NumericUpDown();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.gbDetalleCompra = new System.Windows.Forms.GroupBox();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.nudCodArticulo = new System.Windows.Forms.NumericUpDown();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.ColCodArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBorrarProdcuto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactura)).BeginInit();
            this.gbDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.btnBuscarFactura);
            this.gbDatosCliente.Controls.Add(this.txtRazonSocial);
            this.gbDatosCliente.Controls.Add(this.nudCuit);
            this.gbDatosCliente.Controls.Add(this.nudFactura);
            this.gbDatosCliente.Controls.Add(this.lblFactura);
            this.gbDatosCliente.Controls.Add(this.lblCuit);
            this.gbDatosCliente.Controls.Add(this.lblRazonSocial);
            this.gbDatosCliente.Location = new System.Drawing.Point(22, 12);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(808, 81);
            this.gbDatosCliente.TabIndex = 0;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente";
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.Location = new System.Drawing.Point(665, 19);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(111, 43);
            this.btnBuscarFactura.TabIndex = 16;
            this.btnBuscarFactura.Text = "Buscar Factura";
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(6, 48);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(114, 20);
            this.txtRazonSocial.TabIndex = 5;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudCuit
            // 
            this.nudCuit.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCuit.Location = new System.Drawing.Point(233, 49);
            this.nudCuit.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCuit.Name = "nudCuit";
            this.nudCuit.Size = new System.Drawing.Size(116, 20);
            this.nudCuit.TabIndex = 4;
            this.nudCuit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // nudFactura
            // 
            this.nudFactura.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFactura.Location = new System.Drawing.Point(475, 49);
            this.nudFactura.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudFactura.Name = "nudFactura";
            this.nudFactura.Size = new System.Drawing.Size(116, 20);
            this.nudFactura.TabIndex = 3;
            this.nudFactura.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(488, 25);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(61, 13);
            this.lblFactura.TabIndex = 2;
            this.lblFactura.Text = "N° Factura:";
            this.lblFactura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(269, 25);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(28, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "Cuit:";
            this.lblCuit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(19, 25);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "Razon Social:";
            this.lblRazonSocial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbDetalleCompra
            // 
            this.gbDetalleCompra.Controls.Add(this.btnCargarProducto);
            this.gbDetalleCompra.Controls.Add(this.nudDescuento);
            this.gbDetalleCompra.Controls.Add(this.lblDescuento);
            this.gbDetalleCompra.Controls.Add(this.nudCantidad);
            this.gbDetalleCompra.Controls.Add(this.lblCantidad);
            this.gbDetalleCompra.Controls.Add(this.nudPrecio);
            this.gbDetalleCompra.Controls.Add(this.lblPrecio);
            this.gbDetalleCompra.Controls.Add(this.txtDescripcion);
            this.gbDetalleCompra.Controls.Add(this.lblDescripcion);
            this.gbDetalleCompra.Controls.Add(this.nudCodArticulo);
            this.gbDetalleCompra.Controls.Add(this.lblCodArticulo);
            this.gbDetalleCompra.Location = new System.Drawing.Point(22, 110);
            this.gbDetalleCompra.Name = "gbDetalleCompra";
            this.gbDetalleCompra.Size = new System.Drawing.Size(808, 92);
            this.gbDetalleCompra.TabIndex = 1;
            this.gbDetalleCompra.TabStop = false;
            this.gbDetalleCompra.Text = "Detalle de compra";
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(665, 26);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(111, 43);
            this.btnCargarProducto.TabIndex = 15;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // nudDescuento
            // 
            this.nudDescuento.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDescuento.Location = new System.Drawing.Point(517, 50);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(116, 20);
            this.nudDescuento.TabIndex = 14;
            this.nudDescuento.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(530, 26);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 13;
            this.lblDescuento.Text = "Descuento:";
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCantidad.Location = new System.Drawing.Point(393, 50);
            this.nudCantidad.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(116, 20);
            this.nudCantidad.TabIndex = 12;
            this.nudCantidad.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(406, 26);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudPrecio.Location = new System.Drawing.Point(265, 50);
            this.nudPrecio.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(116, 20);
            this.nudPrecio.TabIndex = 10;
            this.nudPrecio.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(301, 26);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(138, 49);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(114, 20);
            this.txtDescripcion.TabIndex = 8;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(161, 26);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudCodArticulo
            // 
            this.nudCodArticulo.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCodArticulo.Location = new System.Drawing.Point(10, 50);
            this.nudCodArticulo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCodArticulo.Name = "nudCodArticulo";
            this.nudCodArticulo.Size = new System.Drawing.Size(116, 20);
            this.nudCodArticulo.TabIndex = 6;
            this.nudCodArticulo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Location = new System.Drawing.Point(36, 26);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(70, 13);
            this.lblCodArticulo.TabIndex = 5;
            this.lblCodArticulo.Text = "Cod. Articulo:";
            this.lblCodArticulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodArticulo,
            this.ColDescripcion,
            this.ColPrecio,
            this.ColCantidad,
            this.ColDescuento,
            this.ColSubTotal});
            this.dgvFactura.Location = new System.Drawing.Point(22, 208);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(636, 296);
            this.dgvFactura.TabIndex = 2;
            // 
            // ColCodArticulo
            // 
            this.ColCodArticulo.HeaderText = "Cod.Articulo";
            this.ColCodArticulo.Name = "ColCodArticulo";
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            // 
            // ColDescuento
            // 
            this.ColDescuento.HeaderText = "Descuento";
            this.ColDescuento.Name = "ColDescuento";
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.HeaderText = "SubTotal";
            this.ColSubTotal.Name = "ColSubTotal";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(687, 385);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(111, 43);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBorrarProdcuto
            // 
            this.btnBorrarProdcuto.Location = new System.Drawing.Point(687, 208);
            this.btnBorrarProdcuto.Name = "btnBorrarProdcuto";
            this.btnBorrarProdcuto.Size = new System.Drawing.Size(111, 43);
            this.btnBorrarProdcuto.TabIndex = 17;
            this.btnBorrarProdcuto.Text = "Borrar Producto";
            this.btnBorrarProdcuto.UseVisualStyleBackColor = true;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(687, 306);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(111, 43);
            this.btnModificarProducto.TabIndex = 18;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(687, 461);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 43);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 529);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnBorrarProdcuto);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.gbDetalleCompra);
            this.Controls.Add(this.gbDatosCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactura)).EndInit();
            this.gbDetalleCompra.ResumeLayout(false);
            this.gbDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.NumericUpDown nudCuit;
        private System.Windows.Forms.NumericUpDown nudFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.GroupBox gbDetalleCompra;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.NumericUpDown nudCodArticulo;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Button btnBuscarFactura;
        private System.Windows.Forms.Button btnCargarProducto;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBorrarProdcuto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnSalir;
    }
}

