namespace PuntoVentaISOF
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            btnCompletarVenta = new Button();
            txtTotalPagar = new TextBox();
            lblTotalPagar = new Label();
            listRegistrarVenta = new ListBox();
            button2 = new Button();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            txtPrecioVenta = new TextBox();
            lblPrecioVenta = new Label();
            txtPrecioCompra = new TextBox();
            lblPrecioCompra = new Label();
            button1 = new Button();
            txtNombre = new TextBox();
            lblNombredelProducto = new Label();
            txtIDProducto = new TextBox();
            label2 = new Label();
            lvlTipodeDocumento = new Label();
            txtIDCliente = new TextBox();
            lblID = new Label();
            lblInfoProveedor = new Label();
            txtDocumento = new TextBox();
            lblTipo = new Label();
            txtFecha = new TextBox();
            lblFecha = new Label();
            lblInfo = new Label();
            lblRegistrarCenta = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCompletarVenta
            // 
            btnCompletarVenta.Image = (Image)resources.GetObject("btnCompletarVenta.Image");
            btnCompletarVenta.Location = new Point(858, 538);
            btnCompletarVenta.Name = "btnCompletarVenta";
            btnCompletarVenta.Size = new Size(53, 47);
            btnCompletarVenta.TabIndex = 58;
            btnCompletarVenta.UseVisualStyleBackColor = true;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(695, 558);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(145, 27);
            txtTotalPagar.TabIndex = 55;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Location = new Point(695, 535);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(100, 20);
            lblTotalPagar.TabIndex = 54;
            lblTotalPagar.Text = "Total a pagar:";
            // 
            // listRegistrarVenta
            // 
            listRegistrarVenta.FormattingEnabled = true;
            listRegistrarVenta.Location = new Point(29, 261);
            listRegistrarVenta.Name = "listRegistrarVenta";
            listRegistrarVenta.Size = new Size(660, 324);
            listRegistrarVenta.TabIndex = 53;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(817, 203);
            button2.Name = "button2";
            button2.Size = new Size(37, 31);
            button2.TabIndex = 52;
            button2.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(666, 205);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(145, 27);
            txtCantidad.TabIndex = 51;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(666, 182);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 50;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(499, 205);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(145, 27);
            txtPrecioVenta.TabIndex = 49;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(499, 182);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(94, 20);
            lblPrecioVenta.TabIndex = 48;
            lblPrecioVenta.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(348, 207);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(145, 27);
            txtPrecioCompra.TabIndex = 47;
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(348, 184);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(110, 20);
            lblPrecioCompra.TabIndex = 46;
            lblPrecioCompra.Text = "Precio Compra:";
            lblPrecioCompra.Click += lblPrecioCompra_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(148, 205);
            button1.Name = "button1";
            button1.Size = new Size(25, 29);
            button1.TabIndex = 45;
            button1.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(187, 207);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 27);
            txtNombre.TabIndex = 44;
            // 
            // lblNombredelProducto
            // 
            lblNombredelProducto.AutoSize = true;
            lblNombredelProducto.Location = new Point(187, 184);
            lblNombredelProducto.Name = "lblNombredelProducto";
            lblNombredelProducto.Size = new Size(157, 20);
            lblNombredelProducto.TabIndex = 43;
            lblNombredelProducto.Text = "Nombre del producto:";
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(18, 207);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(125, 27);
            txtIDProducto.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 184);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 41;
            label2.Text = "ID del producto:";
            // 
            // lvlTipodeDocumento
            // 
            lvlTipodeDocumento.AutoSize = true;
            lvlTipodeDocumento.Location = new Point(499, 74);
            lvlTipodeDocumento.Name = "lvlTipodeDocumento";
            lvlTipodeDocumento.Size = new Size(0, 20);
            lvlTipodeDocumento.TabIndex = 39;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(358, 97);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(185, 27);
            txtIDCliente.TabIndex = 38;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(358, 74);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 37;
            lblID.Text = "ID:";
            // 
            // lblInfoProveedor
            // 
            lblInfoProveedor.AutoSize = true;
            lblInfoProveedor.Location = new Point(353, 47);
            lblInfoProveedor.Name = "lblInfoProveedor";
            lblInfoProveedor.Size = new Size(190, 20);
            lblInfoProveedor.TabIndex = 36;
            lblInfoProveedor.Text = "Información del proveedor:";
            lblInfoProveedor.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(159, 97);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(145, 27);
            txtDocumento.TabIndex = 35;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(159, 74);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(145, 20);
            lblTipo.TabIndex = 34;
            lblTipo.Text = "Tipo de Documento:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(18, 97);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(125, 27);
            txtFecha.TabIndex = 33;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(18, 74);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 32;
            lblFecha.Text = "Fecha:";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(13, 47);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(184, 20);
            lblInfo.TabIndex = 31;
            lblInfo.Text = "Información de la compra:";
            lblInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRegistrarCenta
            // 
            lblRegistrarCenta.AutoSize = true;
            lblRegistrarCenta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrarCenta.Location = new Point(4, 5);
            lblRegistrarCenta.Name = "lblRegistrarCenta";
            lblRegistrarCenta.Size = new Size(202, 31);
            lblRegistrarCenta.TabIndex = 30;
            lblRegistrarCenta.Text = "Registrar Compras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 164);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 59;
            label4.Text = "Información del producto:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(943, 628);
            Controls.Add(label4);
            Controls.Add(btnCompletarVenta);
            Controls.Add(txtTotalPagar);
            Controls.Add(lblTotalPagar);
            Controls.Add(listRegistrarVenta);
            Controls.Add(button2);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtPrecioVenta);
            Controls.Add(lblPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(lblPrecioCompra);
            Controls.Add(button1);
            Controls.Add(txtNombre);
            Controls.Add(lblNombredelProducto);
            Controls.Add(txtIDProducto);
            Controls.Add(label2);
            Controls.Add(lvlTipodeDocumento);
            Controls.Add(txtIDCliente);
            Controls.Add(lblID);
            Controls.Add(lblInfoProveedor);
            Controls.Add(txtDocumento);
            Controls.Add(lblTipo);
            Controls.Add(txtFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblInfo);
            Controls.Add(lblRegistrarCenta);
            Name = "frmCompras";
            Text = "Compras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCompletarVenta;
        private TextBox textBox2;
        private Label lblCambio;
        private TextBox txtTotalPagar;
        private Label lblTotalPagar;
        private ListBox listRegistrarVenta;
        private Button button2;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private TextBox txtPrecioVenta;
        private Label lblPrecioVenta;
        private TextBox txtPrecioCompra;
        private Label lblPrecioCompra;
        private Button button1;
        private TextBox txtNombre;
        private Label lblNombredelProducto;
        private TextBox txtIDProducto;
        private Label label2;
        private Label lvlTipodeDocumento;
        private TextBox txtIDCliente;
        private Label lblID;
        private Label lblInfoProveedor;
        private TextBox txtDocumento;
        private Label lblTipo;
        private TextBox txtFecha;
        private Label lblFecha;
        private Label lblInfo;
        private Label lblRegistrarCenta;
        private Label label4;
    }
}