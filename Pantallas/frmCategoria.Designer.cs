namespace Pantallas
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            lblCategoria = new Label();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblListCategorias = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            txtNuevaCategoria = new TextBox();
            lblNombreCategoria = new Label();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(12, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(113, 31);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(56, 225);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(56, 260);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(56, 295);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblListCategorias
            // 
            lblListCategorias.AutoSize = true;
            lblListCategorias.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListCategorias.Location = new Point(225, 29);
            lblListCategorias.Name = "lblListCategorias";
            lblListCategorias.Size = new Size(213, 31);
            lblListCategorias.TabIndex = 7;
            lblListCategorias.Text = "Lista de Categorias:";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(532, 46);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(82, 20);
            lblBuscar.TabIndex = 8;
            lblBuscar.Text = "Buscar por:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(620, 43);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(165, 27);
            txtBuscar.TabIndex = 9;
            txtBuscar.Text = "Descripción";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(791, 32);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 48);
            btnBuscar.TabIndex = 27;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNuevaCategoria
            // 
            txtNuevaCategoria.Location = new Point(12, 120);
            txtNuevaCategoria.Name = "txtNuevaCategoria";
            txtNuevaCategoria.Size = new Size(165, 27);
            txtNuevaCategoria.TabIndex = 29;
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Location = new Point(12, 97);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(67, 20);
            lblNombreCategoria.TabIndex = 28;
            lblNombreCategoria.Text = "Nombre:";
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(225, 97);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(605, 309);
            dgvCategorias.TabIndex = 30;
            dgvCategorias.CellContentClick += dvgCategorias_CellContentClick;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(878, 450);
            Controls.Add(dgvCategorias);
            Controls.Add(txtNuevaCategoria);
            Controls.Add(lblNombreCategoria);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblListCategorias);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(lblCategoria);
            Name = "frmCategoria";
            Text = "Mantener - Categoria";
            Load += frmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoria;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblListCategorias;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private TextBox txtNuevaCategoria;
        private Label lblNombreCategoria;
        private DataGridView dgvCategorias;
    }
}