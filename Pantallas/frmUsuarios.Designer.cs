namespace Pantallas
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
            lblAlias = new Label();
            txtAlias = new TextBox();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            lblRol = new Label();
            txtConfContrasena = new TextBox();
            lblConfContraseña = new Label();
            txtContrasenia = new TextBox();
            label2 = new Label();
            listUsuarios = new ListBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblListCategorias = new Label();
            btnBuscar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            cmbRol = new ComboBox();
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
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.Location = new Point(12, 42);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(44, 20);
            lblAlias.TabIndex = 1;
            lblAlias.Text = "Alias:";
            // 
            // txtAlias
            // 
            txtAlias.Location = new Point(85, 39);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(158, 27);
            txtAlias.TabIndex = 2;
            txtAlias.TextChanged += txtNombre_TextChanged;
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
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(408, 75);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(34, 20);
            lblRol.TabIndex = 8;
            lblRol.Text = "Rol:";
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
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(101, 110);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(173, 27);
            txtContrasenia.TabIndex = 11;
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
            btnGuardar.Click += btnGuardar_Click;
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
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(448, 75);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(151, 28);
            cmbRol.TabIndex = 32;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(643, 450);
            Controls.Add(cmbRol);
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
            Controls.Add(txtContrasenia);
            Controls.Add(label2);
            Controls.Add(lblRol);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtAlias);
            Controls.Add(lblAlias);
            Controls.Add(lblUsuarios);
            Name = "frmUsuarios";
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarios;
        private Label lblAlias;
        private TextBox txtAlias;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Label lblRol;
        private TextBox txtConfContrasena;
        private Label lblConfContraseña;
        private TextBox txtContrasenia;
        private Label label2;
        private ListBox listUsuarios;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblListCategorias;
        private Button btnBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private ComboBox cmbRol;
    }
}