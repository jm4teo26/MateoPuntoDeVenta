namespace Pantallas
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
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            lblId = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblCorreo = new Label();
            lblTelefono = new Label();
            dgvClientes = new DataGridView();
            txtBuscar = new TextBox();
            btnRefrescar = new Button();
            lblEliminar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(44, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(133, 27);
            txtId.TabIndex = 0;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(256, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(178, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(515, 31);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(205, 27);
            txtApellido.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(187, 71);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(234, 27);
            txtCorreo.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(503, 71);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(155, 27);
            txtTelefono.TabIndex = 4;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(142, 117);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(132, 31);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(287, 117);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(136, 31);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(658, 402);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 33);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(634, 152);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(63, 33);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 20);
            lblId.TabIndex = 11;
            lblId.Text = "ID:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(183, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(440, 33);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 13;
            lblApellido.Text = "Apellido:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(124, 74);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 14;
            lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(427, 74);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 15;
            lblTelefono.Text = "Telefono:";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(53, 191);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(680, 205);
            dgvClientes.TabIndex = 16;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(489, 155);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(139, 27);
            txtBuscar.TabIndex = 17;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Image = (Image)resources.GetObject("btnRefrescar.Image");
            btnRefrescar.Location = new Point(703, 152);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(30, 33);
            btnRefrescar.TabIndex = 18;
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // lblEliminar
            // 
            lblEliminar.AutoSize = true;
            lblEliminar.Location = new Point(53, 406);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new Size(599, 20);
            lblEliminar.TabIndex = 19;
            lblEliminar.Text = "Si desea eliminar un cliente, seleccióne la fila del cliente desde la columna y presione -->\r\n";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEliminar);
            Controls.Add(btnRefrescar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvClientes);
            Controls.Add(lblTelefono);
            Controls.Add(lblCorreo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Name = "frmClientes";
            Text = "Clientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Label lblId;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblCorreo;
        private Label lblTelefono;
        private DataGridView dgvClientes;
        private TextBox txtBuscar;
        private Button btnRefrescar;
        private Label lblEliminar;
    }
}