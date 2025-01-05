using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pantallas
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            CargarUsuarios(); // Cargar los usuarios al iniciar el formulario
        }

        private void CargarUsuarios()
        {
            using (var context = new SqLiteDbContext())
            {
                var usuarios = context.Usuarios.ToList();
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.AutoGenerateColumns = true;
            CargarUsuarios(); // Llamada al método de carga de usuarios

            // Cargar los roles al ComboBox
            cmbRol.DataSource = Enum.GetValues(typeof(Rol));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos(); // Limpiar los campos
            txtAlias.Focus(); // Foco en el campo Alias
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtAlias.Clear();
            txtCorreo.Clear();
            txtContrasenia.Clear();
            cmbRol.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Id = string.IsNullOrEmpty(txtId.Text) ? 0 : int.Parse(txtId.Text),
                Alias = txtAlias.Text,
                Correo = txtCorreo.Text,
                Contrasenia = txtContrasenia.Text,
                Rol = (Rol)cmbRol.SelectedItem
            };

            if (usuario.Id == 0)
            {
                Usuario.AgregarUsuario(usuario); // Agregar nuevo usuario
            }
            else
            {
                Usuario.ActualizarUsuario(usuario); // Actualizar usuario existente
            }

            CargarUsuarios(); // Actualizar el DataGridView
            MessageBox.Show("Usuario guardado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int usuarioId = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells[0].Value);
                Usuario.EliminarUsuario(usuarioId);
                CargarUsuarios(); // Actualizar el DataGridView
                MessageBox.Show("Usuario eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor seleccione un usuario para eliminar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text; // Obtiene el texto ingresado en el TextBox de búsqueda.

            // Verificar si el campo de búsqueda está vacío
            if (string.IsNullOrEmpty(criterio))
            {
                // Si no hay texto, mostramos todos los usuarios (sin filtro)
                CargarUsuarios();
            }
            else
            {
                // Llamar al método estático que realiza la búsqueda
                var usuarios = Usuario.BuscarUsuarios(criterio.ToLower()); // Convertir el criterio a minúsculas

                // Verifica si la lista de usuarios no es nula ni vacía
                if (usuarios != null && usuarios.Count > 0)
                {
                    dgvUsuarios.DataSource = usuarios; // Asigna la lista de usuarios al DataGridView
                }
                else
                {
                    MessageBox.Show("No se encontraron usuarios que coincidan con el criterio de búsqueda.");
                    dgvUsuarios.DataSource = null; // Si no hay resultados, limpiamos el DataGridView
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener el objeto Usuario asociado con la fila seleccionada
                var usuario = dgvUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;

                // Asignar los valores del usuario a los controles (TextBoxes y ComboBox)
                txtId.Text = usuario.Id.ToString();
                txtAlias.Text = usuario.Alias;
                txtCorreo.Text = usuario.Correo;
                txtContrasenia.Text = usuario.Contrasenia;
                cmbRol.SelectedItem = usuario.Rol;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text;
            var usuarios = Usuario.BuscarUsuarios(criterio.ToLower()); // Convertir el criterio a minúsculas

            // Limpia el DataGridView antes de mostrar los resultados de la búsqueda
            dgvUsuarios.DataSource = null;

            if (usuarios != null && usuarios.Count > 0)
            {
                dgvUsuarios.DataSource = usuarios;
            }
            else
            {
                dgvUsuarios.DataSource = null;
            }
        }
    }
}
