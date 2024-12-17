using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas
{
    public partial class frmRestablecerContrasenia : Form
    {
        public frmRestablecerContrasenia()
        {
            InitializeComponent();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos del formulario
                string alias = txtAlias.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string nuevaContrasenia = txtContra.Text.Trim();
                string confirmarContrasenia = txtConfirmarContra.Text.Trim();

                // Validar campos
                if (string.IsNullOrEmpty(alias) || string.IsNullOrEmpty(correo) ||
                    string.IsNullOrEmpty(nuevaContrasenia) || string.IsNullOrEmpty(confirmarContrasenia))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que las contraseñas coincidan
                if (nuevaContrasenia != confirmarContrasenia)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamar al método para restablecer la contraseña
                Usuario.RestablecerContrasenia(alias, correo, nuevaContrasenia);

                // Mostrar mensaje de éxito
                MessageBox.Show("Contraseña restablecida exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario
                this.Close();
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
