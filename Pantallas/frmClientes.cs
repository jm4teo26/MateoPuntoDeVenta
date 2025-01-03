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
            InitializeComponent(); // Asegúrate de que InitializeComponent esté primero
            CargarClientes(); // Mueve CargarClientes después de InitializeComponent
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar algo si es necesario
        }

        private void CargarClientes()
        {
            using (var context = new SqLiteDbContext())
            {
                var clientes = context.Clientes.ToList();
                if (clientes != null && clientes.Count > 0)
                {
                    dgvClientes.DataSource = clientes;
                    dgvClientes.AutoGenerateColumns = true; // Esto asegura que las columnas se generen correctamente
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

            CargarClientes(); // Actualizar el DataGridView
            MessageBox.Show("Cliente guardado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int clienteId = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);
                Cliente.EliminarCliente(clienteId);
                CargarClientes(); // Actualizar el DataGridView
                MessageBox.Show("Cliente eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cliente para eliminar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var criterio = txtNombre.Text;
            var clientes = Cliente.BuscarClientes(criterio);
            dgvClientes.DataSource = clientes;
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
    }
}
