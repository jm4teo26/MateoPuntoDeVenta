namespace Pantallas
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblAlias = new Label();
            lblContraseña = new Label();
            txtAlias = new TextBox();
            txtContrasenia = new TextBox();
            btnEntrar = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.BackColor = Color.Transparent;
            lblAlias.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlias.Location = new Point(94, 232);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(63, 31);
            lblAlias.TabIndex = 1;
            lblAlias.Text = "Alias";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(85, 296);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(134, 31);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtAlias
            // 
            txtAlias.Location = new Point(94, 266);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(173, 27);
            txtAlias.TabIndex = 3;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(94, 330);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(173, 27);
            txtContrasenia.TabIndex = 4;
            txtContrasenia.TextChanged += txtContrasena_TextChanged;
            txtContrasenia.KeyPress += txtContrasena_KeyPress;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(94, 384);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(173, 42);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(94, 444);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(173, 42);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(386, 510);
            Controls.Add(btnSalir);
            Controls.Add(btnEntrar);
            Controls.Add(txtContrasenia);
            Controls.Add(txtAlias);
            Controls.Add(lblContraseña);
            Controls.Add(lblAlias);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAlias;
        private Label lblContraseña;
        private TextBox txtAlias;
        private TextBox txtContrasenia;
        private Button btnEntrar;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}
