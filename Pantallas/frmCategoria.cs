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
            // Obtener las categorías desde la base de datos (método de la clase Categoria)
            var categorias = Categoria.CargarCategorias();

            // Asignar las categorías al ComboBox o a un DataGridView, según lo que necesites
            dgvCategorias.DataSource = categorias;
            dgvCategorias.Columns["Id"].Visible = false;  // No mostrar el Id en la vista
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevaCategoria = txtNuevaCategoria.Text;

                // Llamar al método estático AgregarCategoria de la clase Categoria
                Categoria.AgregarCategoria(nuevaCategoria);

                // Recargar las categorías para que la nueva se muestre
                CargarCategorias();

                // Limpiar el campo de texto
                txtNuevaCategoria.Clear();

                MessageBox.Show("Categoría agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la categoría: {ex.Message}");
            }
        }

        private void dvgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
