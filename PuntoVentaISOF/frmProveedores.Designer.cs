namespace PuntoVentaISOF
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            lblListClientes = new Label();
            listProveedores = new ListBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            lblProveedores = new Label();
            txtRol = new TextBox();
            lblCelular = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtIDProveedor = new TextBox();
            lblIDProveedor = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(650, 137);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 48);
            btnBuscar.TabIndex = 77;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(479, 148);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(165, 27);
            txtBuscar.TabIndex = 76;
            txtBuscar.Text = "ID del Proveedor";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(391, 151);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(82, 20);
            lblBuscar.TabIndex = 75;
            lblBuscar.Text = "Buscar por:";
            // 
            // lblListClientes
            // 
            lblListClientes.AutoSize = true;
            lblListClientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListClientes.Location = new Point(32, 142);
            lblListClientes.Name = "lblListClientes";
            lblListClientes.Size = new Size(230, 31);
            lblListClientes.TabIndex = 74;
            lblListClientes.Text = "Lista de Proveedores:";
            // 
            // listProveedores
            // 
            listProveedores.FormattingEnabled = true;
            listProveedores.Location = new Point(42, 199);
            listProveedores.Name = "listProveedores";
            listProveedores.Size = new Size(723, 264);
            listProveedores.TabIndex = 73;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(694, 100);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 72;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(694, 54);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 71;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(694, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 70;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblProveedores
            // 
            lblProveedores.AutoSize = true;
            lblProveedores.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProveedores.Location = new Point(3, 3);
            lblProveedores.Name = "lblProveedores";
            lblProveedores.Size = new Size(140, 31);
            lblProveedores.TabIndex = 61;
            lblProveedores.Text = "Proveedores";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(479, 87);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(173, 27);
            txtRol.TabIndex = 69;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(415, 87);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(58, 20);
            lblCelular.TabIndex = 68;
            lblCelular.Text = "Celular:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(92, 84);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(293, 27);
            txtCorreo.TabIndex = 67;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(19, 87);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 66;
            lblCorreo.Text = "Correo:";
            // 
            // txtIDProveedor
            // 
            txtIDProveedor.Location = new Point(149, 47);
            txtIDProveedor.Name = "txtIDProveedor";
            txtIDProveedor.Size = new Size(158, 27);
            txtIDProveedor.TabIndex = 63;
            // 
            // lblIDProveedor
            // 
            lblIDProveedor.AutoSize = true;
            lblIDProveedor.Location = new Point(19, 54);
            lblIDProveedor.Name = "lblIDProveedor";
            lblIDProveedor.Size = new Size(124, 20);
            lblIDProveedor.TabIndex = 62;
            lblIDProveedor.Text = "ID del Proveedor:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(391, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(261, 27);
            txtNombre.TabIndex = 79;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(318, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 78;
            lblNombre.Text = "Nombre:";
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(798, 492);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblListClientes);
            Controls.Add(listProveedores);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(lblProveedores);
            Controls.Add(txtRol);
            Controls.Add(lblCelular);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtIDProveedor);
            Controls.Add(lblIDProveedor);
            Name = "frmProveedores";
            Text = "Proveedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Label lblListClientes;
        private ListBox listProveedores;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Label lblProveedores;
        private TextBox txtRol;
        private Label lblCelular;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtIDProveedor;
        private Label lblIDProveedor;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}