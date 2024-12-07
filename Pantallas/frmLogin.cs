using Datos;

namespace Pantallas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos ingresados por el usuario
                string alias = txtAlias.Text.Trim();
                string contrasenia = txtContrasenia.Text.Trim();

                // Validar campos
                if (string.IsNullOrEmpty(alias) || string.IsNullOrEmpty(contrasenia))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al método de inicio de sesión
                Usuario usuario = Usuario.IniciarSesion(alias, contrasenia);

                // Mostrar mensaje de éxito
                MessageBox.Show($"Bienvenido, {usuario.Alias}.", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Aquí puedes abrir el formulario principal del sistema
                var frmMenuvar = new frmMenu();
                frmMenuvar.Show();

                // Cerrar el formulario de login
                this.Hide();
            }
            catch (Exception ex)
            {
                // Manejar errores de inicio de sesión
                MessageBox.Show($"Error: {ex.Message}", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
