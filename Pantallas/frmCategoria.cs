using Datos;
namespace Pantallas
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();

        }
        private void CargarCategorias()
        {
            // Llamar al método estático CargarCategorias de la clase Categoria
            var categorias = Categoria.CargarCategorias();

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre";  // Mostrar el nombre de la categoría
            cmbCategoria.ValueMember = "Id";  // Establecer el valor asociado (Id)
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
