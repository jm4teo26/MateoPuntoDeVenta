using Datos;
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

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos de los controles del formulario
                string nombre = txtNombreProducto.Text;
                decimal precioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                decimal precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                int categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);  // Asumiendo que cmbCategoria tiene los datos correctos

                // Llamar al método GuardarProducto de la clase Producto
                Producto.GuardarProducto(nombre, precioUnitario, precioCompra, stock, categoriaId);

                // Limpiar los campos del formulario después de guardar
                LimpiarCampos();

                // Mostrar un mensaje de éxito
                MessageBox.Show("Producto guardado correctamente.");
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtPrecioUnitario.Clear();
            txtPrecioCompra.Clear();
            txtStock.Clear();
            cmbCategoria.SelectedIndex = -1;  // Resetea el ComboBox
        }
    }
}
