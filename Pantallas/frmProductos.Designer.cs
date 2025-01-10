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
            lblNombre = new Label();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            lblPrecioUni = new Label();
            txtPrecioUni = new TextBox();
            lblPrecioCo = new Label();
            txtPrecioCo = new TextBox();
            txtStock = new TextBox();
            lblStock = new Label();
            dgvProductos = new DataGridView();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(28, 375);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(299, 21);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 3;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(216, 24);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria:";
            // 
            // lblPrecioUni
            // 
            lblPrecioUni.AutoSize = true;
            lblPrecioUni.Location = new Point(12, 61);
            lblPrecioUni.Name = "lblPrecioUni";
            lblPrecioUni.Size = new Size(110, 20);
            lblPrecioUni.TabIndex = 5;
            lblPrecioUni.Text = "Precio Unitario:";
            // 
            // txtPrecioUni
            // 
            txtPrecioUni.Location = new Point(128, 61);
            txtPrecioUni.Name = "txtPrecioUni";
            txtPrecioUni.Size = new Size(125, 27);
            txtPrecioUni.TabIndex = 6;
            // 
            // lblPrecioCo
            // 
            lblPrecioCo.AutoSize = true;
            lblPrecioCo.Location = new Point(12, 97);
            lblPrecioCo.Name = "lblPrecioCo";
            lblPrecioCo.Size = new Size(110, 20);
            lblPrecioCo.TabIndex = 7;
            lblPrecioCo.Text = "Precio Compra:";
            // 
            // txtPrecioCo
            // 
            txtPrecioCo.Location = new Point(128, 94);
            txtPrecioCo.Name = "txtPrecioCo";
            txtPrecioCo.Size = new Size(125, 27);
            txtPrecioCo.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(128, 127);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 9;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 134);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 20);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock:";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 160);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(566, 209);
            dgvProductos.TabIndex = 11;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(128, 375);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(228, 375);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(328, 375);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvProductos);
            Controls.Add(lblStock);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioCo);
            Controls.Add(lblPrecioCo);
            Controls.Add(txtPrecioUni);
            Controls.Add(lblPrecioUni);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(lblNombre);
            Name = "frmProductos";
            Text = "Productos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Button btnAgregar;
        private TextBox txtNombre;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private Label lblPrecioUni;
        private TextBox txtPrecioUni;
        private Label lblPrecioCo;
        private TextBox txtPrecioCo;
        private TextBox txtStock;
        private Label lblStock;
        private DataGridView dgvProductos;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}