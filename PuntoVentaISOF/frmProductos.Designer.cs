namespace PuntoVentaISOF
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
            listProducto = new ListBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            txtID = new TextBox();
            lblID = new Label();
            lblProductos = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtDescriipción = new TextBox();
            lblDescripcion = new Label();
            txtCategoria = new TextBox();
            lblCategoria = new Label();
            btnBuscar = new Button();
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
            // listProducto
            // 
            listProducto.FormattingEnabled = true;
            listProducto.Location = new Point(223, 110);
            listProducto.Name = "listProducto";
            listProducto.Size = new Size(586, 284);
            listProducto.TabIndex = 16;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(40, 326);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(40, 291);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(40, 256);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 53);
            txtID.Name = "txtID";
            txtID.Size = new Size(165, 27);
            txtID.TabIndex = 12;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 30);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 11;
            lblID.Text = "ID:";
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
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 27);
            txtNombre.TabIndex = 21;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre";
            // 
            // txtDescriipción
            // 
            txtDescriipción.Location = new Point(12, 164);
            txtDescriipción.Name = "txtDescriipción";
            txtDescriipción.Size = new Size(165, 27);
            txtDescriipción.TabIndex = 23;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 141);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 22;
            lblDescripcion.Text = "Descripción";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(12, 214);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(165, 27);
            txtCategoria.TabIndex = 25;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 191);
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
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(849, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtDescriipción);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblListCategorias);
            Controls.Add(listProducto);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(lblProductos);
            Name = "frmProductos";
            Text = "Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Label lblBuscar;
        private Label lblListCategorias;
        private ListBox listProducto;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private TextBox txtID;
        private Label lblID;
        private Label lblProductos;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDescriipción;
        private Label lblDescripcion;
        private TextBox txtCategoria;
        private Label lblCategoria;
        private Button btnBuscar;
    }
}