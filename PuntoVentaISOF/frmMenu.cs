using System.ComponentModel;

namespace Pantallas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios objUsuarios = new frmUsuarios();
            objUsuarios.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes objClientes = new frmClientes();
            objClientes.Show();
        }
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmMenu));
            btnUsuarios = new Button();
            btnMantener = new Button();
            btnVentas = new Button();
            btnCompras = new Button();
            btnClientes = new Button();
            btnProveedores = new Button();
            btnEstadisticas = new Button();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSize = true;
            btnUsuarios.Font = new Font("Microsoft Sans Serif", 12F);
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.TopCenter;
            btnUsuarios.Location = new Point(41, 36);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(99, 99);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.BottomCenter;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnMantener
            // 
            btnMantener.AutoSize = true;
            btnMantener.Font = new Font("Microsoft Sans Serif", 12F);
            btnMantener.Image = (Image)resources.GetObject("btnMantener.Image");
            btnMantener.ImageAlign = ContentAlignment.TopCenter;
            btnMantener.Location = new Point(41, 171);
            btnMantener.Name = "btnMantener";
            btnMantener.Size = new Size(105, 99);
            btnMantener.TabIndex = 1;
            btnMantener.Text = "Mantener";
            btnMantener.TextAlign = ContentAlignment.BottomCenter;
            btnMantener.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMantener.UseVisualStyleBackColor = true;
            btnMantener.Click += btnMantener_Click;
            // 
            // btnVentas
            // 
            btnVentas.AutoSize = true;
            btnVentas.Font = new Font("Microsoft Sans Serif", 12F);
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.TopCenter;
            btnVentas.Location = new Point(168, 36);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(96, 99);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.BottomCenter;
            btnVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnCompras
            // 
            btnCompras.AutoSize = true;
            btnCompras.Font = new Font("Microsoft Sans Serif", 12F);
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.ImageAlign = ContentAlignment.TopCenter;
            btnCompras.Location = new Point(168, 171);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(102, 99);
            btnCompras.TabIndex = 3;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.BottomCenter;
            btnCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnClientes
            // 
            btnClientes.AutoSize = true;
            btnClientes.Font = new Font("Microsoft Sans Serif", 12F);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.TopCenter;
            btnClientes.Location = new Point(308, 36);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(93, 99);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.BottomCenter;
            btnClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.AutoSize = true;
            btnProveedores.Font = new Font("Microsoft Sans Serif", 12F);
            btnProveedores.Image = (Image)resources.GetObject("btnProveedores.Image");
            btnProveedores.ImageAlign = ContentAlignment.TopCenter;
            btnProveedores.Location = new Point(156, 294);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(133, 99);
            btnProveedores.TabIndex = 5;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.BottomCenter;
            btnProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.AutoSize = true;
            btnEstadisticas.Font = new Font("Microsoft Sans Serif", 12F);
            btnEstadisticas.Image = (Image)resources.GetObject("btnEstadisticas.Image");
            btnEstadisticas.ImageAlign = ContentAlignment.TopCenter;
            btnEstadisticas.Location = new Point(295, 171);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(126, 99);
            btnEstadisticas.TabIndex = 6;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.TextAlign = ContentAlignment.BottomCenter;
            btnEstadisticas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // frmMenu
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(445, 428);
            Controls.Add(btnEstadisticas);
            Controls.Add(btnProveedores);
            Controls.Add(btnClientes);
            Controls.Add(btnCompras);
            Controls.Add(btnVentas);
            Controls.Add(btnMantener);
            Controls.Add(btnUsuarios);
            Name = "frmMenu";
            Text = "Menú Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnUsuarios;
        private Button btnMantener;
        private Button btnVentas;
        private Button btnCompras;
        private Button btnClientes;
        private Button btnProveedores;
        private Button btnEstadisticas;

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas objVentas = new frmVentas();
            objVentas.Show();
        }

        private void btnMantener_Click(object sender, EventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras objCompras = new frmCompras();
            objCompras.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores objProveedores = new frmProveedores();
            objProveedores.Show();
        }
    }
}
