namespace Pantallas
{
    partial class frmRestablecerContrasenia
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
            lblTitulo = new Label();
            lblAlias = new Label();
            txtAlias = new TextBox();
            txtContra = new TextBox();
            lblNuevaContra = new Label();
            btnRestablecer = new Button();
            txtConfirmarContra = new TextBox();
            lblConfirmContra = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(239, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Restablecer Contraseña:";
            // 
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.Location = new Point(41, 57);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(111, 20);
            lblAlias.TabIndex = 1;
            lblAlias.Text = "Ingresa tu alias:";
            // 
            // txtAlias
            // 
            txtAlias.Location = new Point(41, 80);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(196, 27);
            txtAlias.TabIndex = 2;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(41, 142);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(196, 27);
            txtContra.TabIndex = 3;
            // 
            // lblNuevaContra
            // 
            lblNuevaContra.AutoSize = true;
            lblNuevaContra.Location = new Point(41, 119);
            lblNuevaContra.Name = "lblNuevaContra";
            lblNuevaContra.Size = new Size(196, 20);
            lblNuevaContra.TabIndex = 4;
            lblNuevaContra.Text = "Ingresa tu nueva contraseña:";
            // 
            // btnRestablecer
            // 
            btnRestablecer.Location = new Point(148, 196);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(194, 54);
            btnRestablecer.TabIndex = 5;
            btnRestablecer.Text = "Restablecer";
            btnRestablecer.UseVisualStyleBackColor = true;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Location = new Point(253, 142);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.Size = new Size(196, 27);
            txtConfirmarContra.TabIndex = 6;
            // 
            // lblConfirmContra
            // 
            lblConfirmContra.AutoSize = true;
            lblConfirmContra.Location = new Point(253, 119);
            lblConfirmContra.Name = "lblConfirmContra";
            lblConfirmContra.Size = new Size(153, 20);
            lblConfirmContra.TabIndex = 7;
            lblConfirmContra.Text = "Confirmar Contraseña";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(253, 80);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(196, 27);
            txtCorreo.TabIndex = 8;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(253, 57);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(124, 20);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "Ingresa tu correo:";
            // 
            // frmRestablecerContrasenia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(481, 415);
            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(lblConfirmContra);
            Controls.Add(txtConfirmarContra);
            Controls.Add(btnRestablecer);
            Controls.Add(lblNuevaContra);
            Controls.Add(txtContra);
            Controls.Add(txtAlias);
            Controls.Add(lblAlias);
            Controls.Add(lblTitulo);
            Name = "frmRestablecerContrasenia";
            Text = "Restablecer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAlias;
        private TextBox txtAlias;
        private TextBox txtContra;
        private Label lblNuevaContra;
        private Button btnRestablecer;
        private TextBox txtConfirmarContra;
        private Label lblConfirmContra;
        private TextBox txtCorreo;
        private Label lblCorreo;
    }
}