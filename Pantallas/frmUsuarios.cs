using Datos;

namespace Pantallas
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            // Cargar roles en el ComboBox al inicializar
            cmbRol.DataSource = Enum.GetValues(typeof(Rol));
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos del formulario
                string alias = txtAlias.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string contrasenia = txtContrasenia.Text.Trim();
                Rol rolSeleccionado = (Rol)cmbRol.SelectedItem;

                // Validar campos antes de guardar
                if (string.IsNullOrEmpty(alias) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasenia))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamar al método de la clase Usuario para agregar el usuario
                Usuario.AgregarUsuario(alias, correo, contrasenia, rolSeleccionado);

                // Mostrar mensaje de éxito
                MessageBox.Show("Usuario agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos
                txtAlias.Clear();
                txtCorreo.Clear();
                txtContrasenia.Clear();
                cmbRol.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al agregar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
