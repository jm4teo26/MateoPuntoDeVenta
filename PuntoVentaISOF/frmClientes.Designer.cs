namespace PuntoVentaISOF
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            lblListClientes = new Label();
            listClientes = new ListBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtApellidos = new TextBox();
            lblApellidos = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblTelefono = new Label();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(650, 143);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 48);
            btnBuscar.TabIndex = 76;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(479, 154);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(165, 27);
            txtBuscar.TabIndex = 75;
            txtBuscar.Text = "ID de Cliente";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(391, 157);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(82, 20);
            lblBuscar.TabIndex = 74;
            lblBuscar.Text = "Buscar por:";
            // 
            // lblListClientes
            // 
            lblListClientes.AutoSize = true;
            lblListClientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListClientes.Location = new Point(32, 148);
            lblListClientes.Name = "lblListClientes";
            lblListClientes.Size = new Size(185, 31);
            lblListClientes.TabIndex = 73;
            lblListClientes.Text = "Lista de Clientes:";
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.Location = new Point(42, 205);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(723, 264);
            listClientes.TabIndex = 72;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(694, 106);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 71;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(694, 60);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 70;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MintCream;
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(694, 21);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 69;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 61;
            label1.Text = "Clientes";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(479, 93);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(173, 27);
            txtTelefono.TabIndex = 68;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(92, 90);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(293, 27);
            txtCorreo.TabIndex = 67;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(19, 93);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 66;
            lblCorreo.Text = "Correo:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(328, 57);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(300, 27);
            txtApellidos.TabIndex = 65;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(255, 60);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(75, 20);
            lblApellidos.TabIndex = 64;
            lblApellidos.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 27);
            txtNombre.TabIndex = 63;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 62;
            lblNombre.Text = "Nombre:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(403, 97);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 77;
            lblTelefono.Text = "Telefono:";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(807, 482);
            Controls.Add(lblTelefono);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblListClientes);
            Controls.Add(listClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtApellidos);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "frmClientes";
            Text = "Clientes";
            Load += frmClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Label lblListClientes;
        private ListBox listClientes;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtApellidos;
        private Label lblApellidos;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblTelefono;
    }
}