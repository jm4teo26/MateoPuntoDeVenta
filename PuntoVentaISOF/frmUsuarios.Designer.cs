namespace PuntoVentaISOF
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            lblUsuarios = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            lblApellidos = new Label();
            lblRol = new Label();
            txtRol = new TextBox();
            txtConfContrasena = new TextBox();
            lblConfContraseña = new Label();
            txtContrasena = new TextBox();
            label2 = new Label();
            listUsuarios = new ListBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblListCategorias = new Label();
            btnBuscar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            SuspendLayout();
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuarios.Location = new Point(12, 5);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(102, 31);
            lblUsuarios.TabIndex = 0;
            lblUsuarios.Text = "Usuarios";
            lblUsuarios.Click += lblUsuarios_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 27);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(321, 39);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(300, 27);
            txtApellidos.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(85, 72);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(293, 27);
            txtCorreo.TabIndex = 6;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(12, 75);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(248, 42);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(75, 20);
            lblApellidos.TabIndex = 3;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(408, 75);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(34, 20);
            lblRol.TabIndex = 8;
            lblRol.Text = "Rol:";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(448, 72);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(173, 27);
            txtRol.TabIndex = 9;
            // 
            // txtConfContrasena
            // 
            txtConfContrasena.Location = new Point(448, 113);
            txtConfContrasena.Name = "txtConfContrasena";
            txtConfContrasena.Size = new Size(173, 27);
            txtConfContrasena.TabIndex = 13;
            // 
            // lblConfContraseña
            // 
            lblConfContraseña.AutoSize = true;
            lblConfContraseña.Location = new Point(286, 113);
            lblConfContraseña.Name = "lblConfContraseña";
            lblConfContraseña.Size = new Size(156, 20);
            lblConfContraseña.TabIndex = 12;
            lblConfContraseña.Text = "Confirmar Contraseña:";
            lblConfContraseña.Click += label1_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(101, 110);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(173, 27);
            txtContrasena.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 10;
            label2.Text = "Contraseña:";
            // 
            // listUsuarios
            // 
            listUsuarios.FormattingEnabled = true;
            listUsuarios.Location = new Point(24, 257);
            listUsuarios.Name = "listUsuarios";
            listUsuarios.Size = new Size(563, 164);
            listUsuarios.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(140, 153);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(256, 153);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(381, 153);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblListCategorias
            // 
            lblListCategorias.AutoSize = true;
            lblListCategorias.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListCategorias.Location = new Point(12, 204);
            lblListCategorias.Name = "lblListCategorias";
            lblListCategorias.Size = new Size(192, 31);
            lblListCategorias.TabIndex = 28;
            lblListCategorias.Text = "Lista de Usuarios:";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(578, 207);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 48);
            btnBuscar.TabIndex = 31;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(319, 221);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(82, 20);
            lblBuscar.TabIndex = 29;
            lblBuscar.Text = "Buscar por:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(407, 218);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(165, 27);
            txtBuscar.TabIndex = 30;
            txtBuscar.Text = "ID del Usuario";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(643, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblListCategorias);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(listUsuarios);
            Controls.Add(txtConfContrasena);
            Controls.Add(lblConfContraseña);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(txtRol);
            Controls.Add(lblRol);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtApellidos);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblUsuarios);
            Name = "frmUsuarios";
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarios;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Label lblApellidos;
        private Label lblRol;
        private TextBox txtRol;
        private TextBox txtConfContrasena;
        private Label lblConfContraseña;
        private TextBox txtContrasena;
        private Label label2;
        private ListBox listUsuarios;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblListCategorias;
        private Button btnBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
    }
}