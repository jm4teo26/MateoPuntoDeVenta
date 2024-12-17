namespace Pantallas
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            lblListCategorias = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            lblProductos = new Label();
            txtNombreProducto = new TextBox();
            lblNombre = new Label();
            txtPrecioUnitario = new TextBox();
            lblPrecioUnitario = new Label();
            lblCategoria = new Label();
            btnBuscar = new Button();
            cmbCategoria = new ComboBox();
            lblStock = new Label();
            txtStock = new TextBox();
            txtPrecioCompra = new TextBox();
            lblPrecioCompra = new Label();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(608, 33);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(165, 27);
            txtBuscar.TabIndex = 19;
            txtBuscar.Text = "ID del producto";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(520, 36);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(82, 20);
            lblBuscar.TabIndex = 18;
            lblBuscar.Text = "Buscar por:";
            // 
            // lblListCategorias
            // 
            lblListCategorias.AutoSize = true;
            lblListCategorias.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListCategorias.Location = new Point(213, 19);
            lblListCategorias.Name = "lblListCategorias";
            lblListCategorias.Size = new Size(207, 31);
            lblListCategorias.TabIndex = 17;
            lblListCategorias.Text = "Lista de Productos:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(48, 399);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(48, 364);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(48, 329);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductos.Location = new Point(0, -1);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(117, 31);
            lblProductos.TabIndex = 10;
            lblProductos.Text = "Productos";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(12, 61);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(165, 27);
            txtNombreProducto.TabIndex = 21;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(12, 115);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(165, 27);
            txtPrecioUnitario.TabIndex = 23;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(12, 92);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(110, 20);
            lblPrecioUnitario.TabIndex = 22;
            lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 198);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 24;
            lblCategoria.Text = "Categoria:";
            lblCategoria.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(779, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 48);
            btnBuscar.TabIndex = 26;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(12, 221);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 27;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 252);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 20);
            lblStock.TabIndex = 28;
            lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(17, 275);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(146, 27);
            txtStock.TabIndex = 29;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(12, 168);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(165, 27);
            txtPrecioCompra.TabIndex = 31;
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(12, 145);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(107, 20);
            lblPrecioCompra.TabIndex = 30;
            lblPrecioCompra.Text = "Precio Compra";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(213, 92);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(605, 320);
            dgvProductos.TabIndex = 32;
            dgvProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(849, 450);
            Controls.Add(dgvProductos);
            Controls.Add(txtPrecioCompra);
            Controls.Add(lblPrecioCompra);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(cmbCategoria);
            Controls.Add(btnBuscar);
            Controls.Add(lblCategoria);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombre);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblListCategorias);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(lblProductos);
            Name = "frmProductos";
            Text = "Productos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Label lblBuscar;
        private Label lblListCategorias;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Label lblProductos;
        private TextBox txtNombreProducto;
        private Label lblNombre;
        private TextBox txtPrecioUnitario;
        private Label lblPrecioUnitario;
        private Label lblCategoria;
        private Button btnBuscar;
        private ComboBox cmbCategoria;
        private Label lblStock;
        private TextBox txtStock;
        private TextBox txtPrecioCompra;
        private Label lblPrecioCompra;
        private DataGridView dgvProductos;
    }
}