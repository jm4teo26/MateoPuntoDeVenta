using Datos;
using Microsoft.EntityFrameworkCore;
namespace Pantallas
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // Cargar las categorías en el ComboBox al cargar el formulario
            CargarCategorias();
            CargarProductos();
        }
        // Método para cargar las categorías en el ComboBox
        private void CargarCategorias()
        {
            try
            {
                // Obtener todas las categorías desde la base de datos
                var categorias = Categoria.CargarCategorias();

                // Asignar las categorías al ComboBox
                cmbCategoria.DataSource = categorias; // Establecer la lista de categorías
                cmbCategoria.DisplayMember = "Nombre"; // Mostrar el nombre de la categoría en el ComboBox
                cmbCategoria.ValueMember = "Id"; // Asociar el Id de la categoría con el valor seleccionado
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre alguna excepción
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}");
            }
        }
        // Método para cargar los productos en el DataGridView
        private void CargarProductos()
        {
            try
            {
                using (var context = new SqLiteDbContext())
                {
                    // Obtener todos los productos desde la base de datos
                    var productos = context.Productos.Include(p => p.Categoria).ToList();

                    // Asignar la lista de productos al DataGridView
                    dgvProductos.DataSource = productos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los campos del formulario
                string nombre = txtNombreProducto.Text;
                decimal precioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                decimal precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                int stock = Convert.ToInt32(txtStock.Text);

                // Obtener el Id de la categoría seleccionada del ComboBox
                int categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);

                // Llamar al método GuardarProducto de la clase Producto
                Producto.GuardarProducto(nombre, precioUnitario, precioCompra, stock, categoriaId);

                // Limpiar los campos del formulario después de guardar
                LimpiarCampos();

                // Mostrar mensaje de éxito
                MessageBox.Show("Producto guardado correctamente.");
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre alguna excepción
                MessageBox.Show($"Error al guardar el producto: {ex.Message}");
            }
        }
        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtPrecioUnitario.Clear();
            txtPrecioCompra.Clear();
            txtStock.Clear();
            cmbCategoria.SelectedIndex = -1;  // Limpiar la selección en el ComboBox
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
