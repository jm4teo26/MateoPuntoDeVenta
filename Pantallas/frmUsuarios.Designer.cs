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
            txtId = new TextBox();
            lblId = new Label();
            lblAlias = new Label();
            txtAlias = new TextBox();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            lblContresenia = new Label();
            txtContrasenia = new TextBox();
            cmbRol = new ComboBox();
            lblRol = new Label();
            dgvUsuarios = new DataGridView();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(45, 17);
            txtId.Name = "txtId";
            txtId.Size = new Size(75, 27);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.Location = new Point(129, 20);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(44, 20);
            lblAlias.TabIndex = 2;
            lblAlias.Text = "Alias:";
            // 
            // txtAlias
            // 
            txtAlias.Location = new Point(179, 17);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(175, 27);
            txtAlias.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(423, 17);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(202, 27);
            txtCorreo.TabIndex = 4;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(363, 20);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo:";
            // 
            // lblContresenia
            // 
            lblContresenia.AutoSize = true;
            lblContresenia.Location = new Point(209, 57);
            lblContresenia.Name = "lblContresenia";
            lblContresenia.Size = new Size(86, 20);
            lblContresenia.TabIndex = 6;
            lblContresenia.Text = "Contraseña:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(295, 54);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(158, 27);
            txtContrasenia.TabIndex = 7;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(52, 54);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(151, 28);
            cmbRol.TabIndex = 8;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(12, 57);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(34, 20);
            lblRol.TabIndex = 9;
            lblRol.Text = "Rol:";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(30, 152);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(678, 251);
            dgvUsuarios.TabIndex = 10;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(646, 17);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(646, 52);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(600, 409);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(600, 117);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(469, 117);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 15;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblRol);
            Controls.Add(cmbRol);
            Controls.Add(txtContrasenia);
            Controls.Add(lblContresenia);
            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(txtAlias);
            Controls.Add(lblAlias);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Name = "frmUsuarios";
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private Label lblAlias;
        private TextBox txtAlias;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Label lblContresenia;
        private TextBox txtContrasenia;
        private ComboBox cmbRol;
        private Label lblRol;
        private DataGridView dgvUsuarios;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnBuscar;
        private TextBox txtBuscar;
    }
}