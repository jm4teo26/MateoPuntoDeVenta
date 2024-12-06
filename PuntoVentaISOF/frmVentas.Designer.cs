namespace Pantallas
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            lblRegistrarVenta = new Label();
            lblInfo = new Label();
            lblFecha = new Label();
            txtFecha = new TextBox();
            txtDocumento = new TextBox();
            lblTipo = new Label();
            txtTipodeDocumento = new TextBox();
            lvlTipodeDocumento = new Label();
            txtIDCliente = new TextBox();
            lblID = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            lblNombredelProducto = new Label();
            txtIDProducto = new TextBox();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            txtPrecioCompra = new TextBox();
            lblPrecioCompra = new Label();
            txtPrecioVenta = new TextBox();
            lblPrecioVenta = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            button2 = new Button();
            listRegistrarVenta = new ListBox();
            txtTotalPagar = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            lblCambio = new Label();
            btnCompletarVenta = new Button();
            SuspendLayout();
            // 
            // lblRegistrarVenta
            // 
            lblRegistrarVenta.AutoSize = true;
            lblRegistrarVenta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrarVenta.Location = new Point(2, 0);
            lblRegistrarVenta.Name = "lblRegistrarVenta";
            lblRegistrarVenta.Size = new Size(169, 31);
            lblRegistrarVenta.TabIndex = 0;
            lblRegistrarVenta.Text = "Registrar Venta";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(11, 42);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(169, 20);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Información de la venta:";
            lblInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(16, 69);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(16, 92);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(125, 27);
            txtFecha.TabIndex = 3;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(157, 92);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(145, 27);
            txtDocumento.TabIndex = 5;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(157, 69);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(145, 20);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo de Documento:";
            // 
            // txtTipodeDocumento
            // 
            txtTipodeDocumento.Location = new Point(497, 92);
            txtTipodeDocumento.Name = "txtTipodeDocumento";
            txtTipodeDocumento.Size = new Size(145, 27);
            txtTipodeDocumento.TabIndex = 10;
            // 
            // lvlTipodeDocumento
            // 
            lvlTipodeDocumento.AutoSize = true;
            lvlTipodeDocumento.Location = new Point(497, 69);
            lvlTipodeDocumento.Name = "lvlTipodeDocumento";
            lvlTipodeDocumento.Size = new Size(145, 20);
            lvlTipodeDocumento.TabIndex = 9;
            lvlTipodeDocumento.Text = "Tipo de Documento:";
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(356, 92);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(125, 27);
            txtIDCliente.TabIndex = 8;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(356, 69);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 7;
            lblID.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 42);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 6;
            label3.Text = "Información del cliente:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(185, 202);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 27);
            txtNombre.TabIndex = 15;
            // 
            // lblNombredelProducto
            // 
            lblNombredelProducto.AutoSize = true;
            lblNombredelProducto.Location = new Point(185, 179);
            lblNombredelProducto.Name = "lblNombredelProducto";
            lblNombredelProducto.Size = new Size(67, 20);
            lblNombredelProducto.TabIndex = 14;
            lblNombredelProducto.Text = "Nombre:";
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(16, 202);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(125, 27);
            txtIDProducto.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 179);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 12;
            label2.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 152);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 11;
            label4.Text = "Información del producto:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(146, 200);
            button1.Name = "button1";
            button1.Size = new Size(25, 29);
            button1.TabIndex = 16;
            button1.UseVisualStyleBackColor = true;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(336, 200);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(145, 27);
            txtPrecioCompra.TabIndex = 18;
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(336, 177);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(107, 20);
            lblPrecioCompra.TabIndex = 17;
            lblPrecioCompra.Text = "Precio Compra";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(497, 200);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(145, 27);
            txtPrecioVenta.TabIndex = 20;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(497, 177);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(94, 20);
            lblPrecioVenta.TabIndex = 19;
            lblPrecioVenta.Text = "Precio Venta:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(664, 200);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(145, 27);
            txtCantidad.TabIndex = 22;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(664, 177);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 21;
            lblCantidad.Text = "Cantidad:";
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(815, 198);
            button2.Name = "button2";
            button2.Size = new Size(37, 31);
            button2.TabIndex = 23;
            button2.UseVisualStyleBackColor = true;
            // 
            // listRegistrarVenta
            // 
            listRegistrarVenta.FormattingEnabled = true;
            listRegistrarVenta.Location = new Point(27, 256);
            listRegistrarVenta.Name = "listRegistrarVenta";
            listRegistrarVenta.Size = new Size(660, 324);
            listRegistrarVenta.TabIndex = 24;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(693, 489);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(145, 27);
            txtTotalPagar.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(693, 466);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 25;
            label1.Text = "Total a pagar:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(693, 553);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 27);
            textBox2.TabIndex = 28;
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Location = new Point(693, 530);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(64, 20);
            lblCambio.TabIndex = 27;
            lblCambio.Text = "Cambio:";
            // 
            // btnCompletarVenta
            // 
            btnCompletarVenta.Image = (Image)resources.GetObject("btnCompletarVenta.Image");
            btnCompletarVenta.Location = new Point(862, 503);
            btnCompletarVenta.Name = "btnCompletarVenta";
            btnCompletarVenta.Size = new Size(53, 47);
            btnCompletarVenta.TabIndex = 29;
            btnCompletarVenta.UseVisualStyleBackColor = true;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(927, 623);
            Controls.Add(btnCompletarVenta);
            Controls.Add(textBox2);
            Controls.Add(lblCambio);
            Controls.Add(txtTotalPagar);
            Controls.Add(label1);
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
            Controls.Add(label4);
            Controls.Add(txtTipodeDocumento);
            Controls.Add(lvlTipodeDocumento);
            Controls.Add(txtIDCliente);
            Controls.Add(lblID);
            Controls.Add(label3);
            Controls.Add(txtDocumento);
            Controls.Add(lblTipo);
            Controls.Add(txtFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblInfo);
            Controls.Add(lblRegistrarVenta);
            Name = "frmVentas";
            Text = "Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTipodeDocumento;
        private Label lvlTipodeDocumento;
        private TextBox txtIDCliente;
        private Label lblID;
        private Label label3;
        private TextBox txtDocumento;
        private Label lblTipo;
        private TextBox txtFecha;
        private Label lblFecha;
        private Label lblInfo;
        private Label lblRegistrarVenta;
        private Button button1;
        private TextBox txtNombre;
        private Label lblNombredelProducto;
        private TextBox txtIDProducto;
        private Label label2;
        private Label label4;
        private TextBox txtPrecioVenta;
        private Label lblPrecioVenta;
        private TextBox txtPrecioCompra;
        private Label lblPrecioCompra;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Button button2;
        private Button btnCompletarVenta;
        private TextBox textBox2;
        private Label lblCambio;
        private TextBox txtTotalPagar;
        private Label label1;
        private ListBox listRegistrarVenta;
    }
}