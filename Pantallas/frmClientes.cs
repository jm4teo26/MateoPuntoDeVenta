using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pantallas
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            txtId.ReadOnly = true;
            CargarClientes();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
        }

        private void CargarClientes()
        {
            using (var context = new SqLiteDbContext())
            {
                var clientes = context.Clientes.ToList();
                if (clientes != null && clientes.Count > 0)
                {
                    dgvClientes.DataSource = clientes;
                    dgvClientes.AutoGenerateColumns = true;
                }
                else
                {
                    MessageBox.Show("No hay clientes en la base de datos.");
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Id = string.IsNullOrEmpty(txtId.Text) ? 0 : int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text
            };

            if (cliente.Id == 0)
            {
                Cliente.AgregarCliente(cliente);
            }
            else
            {
                Cliente.ActualizarCliente(cliente);
            }

            CargarClientes();
            MessageBox.Show("Cliente guardado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int clienteId = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);
                Cliente.EliminarCliente(clienteId);
                CargarClientes();
                MessageBox.Show("Cliente eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cliente para eliminar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var context = new SqLiteDbContext())
            {
                // Obtén el texto del TextBox de búsqueda
                var criterio = txtBuscar.Text.Trim();

                // Lista de clientes que coinciden con la búsqueda
                List<Cliente> clientes;

                // Verifica si el criterio es un número (para buscar por Id)
                if (int.TryParse(criterio, out int id))
                {
                    // Buscar por Id
                    clientes = context.Clientes
                        .Where(c => c.Id == id)
                        .ToList();
                }
                else
                {
                    // Buscar por Nombre o Apellido
                    clientes = context.Clientes
                        .Where(c => c.Nombre.Contains(criterio) || c.Apellido.Contains(criterio))
                        .ToList();
                }

                // Actualiza el DataGridView con los resultados
                dgvClientes.DataSource = clientes;

                // Muestra un mensaje si no se encontraron resultados
                if (clientes.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes que coincidan con la búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cliente = dgvClientes.Rows[e.RowIndex].DataBoundItem as Cliente;
                if (cliente != null)
                {
                    txtId.Text = cliente.Id.ToString();
                    txtNombre.Text = cliente.Nombre;
                    txtApellido.Text = cliente.Apellido;
                    txtCorreo.Text = cliente.Correo;
                    txtTelefono.Text = cliente.Telefono;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarClientes(); // Vuelve a cargar los datos desde la base de datos
            MessageBox.Show("Datos actualizados.", "Refrescar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
