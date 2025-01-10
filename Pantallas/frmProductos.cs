using Datos;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            CargarCategorias();
            CargarProductos();
        }
        private async void CargarProductos()
        {
            var productos = await Producto.ObtenerProductosAsync();
            dgvProductos.DataSource = productos.Select(p => new
            {
                p.Id,
                p.Nombre,
                Categoria = p.Categoria != null ? p.Categoria.Nombre : "Sin Categoría",
                p.PrecioUnitario,
                p.PrecioCompra,
                p.Stock
            }).ToList();
        }
        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow != null)
                {
                    var producto = new Producto
                    {
                        Id = int.Parse(dgvProductos.CurrentRow.Cells["Id"].Value.ToString()),
                        Nombre = txtNombre.Text,
                        CategoriaId = int.Parse(cmbCategoria.SelectedValue.ToString()),
                        PrecioUnitario = decimal.Parse(txtPrecioUni.Text),
                        PrecioCompra = decimal.Parse(txtPrecioCo.Text),
                        Stock = int.Parse(txtStock.Text)
                    };
                    await Producto.ActualizarProductoAsync(producto);
                    MessageBox.Show("Producto actualizado correctamente.");
                    CargarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoProducto = new Producto
                {
                    Nombre = txtNombre.Text,
                    CategoriaId = int.Parse(cmbCategoria.SelectedValue.ToString()),
                    PrecioUnitario = decimal.Parse(txtPrecioUni.Text),
                    PrecioCompra = decimal.Parse(txtPrecioCo.Text),
                    Stock = int.Parse(txtStock.Text)
                };
                await Producto.CrearProductoAsync(nuevoProducto);
                MessageBox.Show("Producto agregado correctamente.");
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow != null)
                {
                    int id = int.Parse(dgvProductos.CurrentRow.Cells["Id"].Value.ToString());
                    await Producto.EliminarProductoAsync(id);
                    MessageBox.Show("Producto eliminado correctamente.");
                    CargarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecioUni.Clear();
            txtPrecioCo.Clear();
            txtStock.Clear();
            cmbCategoria.SelectedIndex = -1;
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProductos.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtPrecioUni.Text = row.Cells["PrecioUnitario"].Value.ToString();
                txtPrecioCo.Text = row.Cells["PrecioCompra"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                cmbCategoria.Text = row.Cells["Categoria"].Value.ToString();
            }
        }
        private async void CargarCategorias()
        {
            using var context = new SqLiteDbContext();
            var categorias = await context.Categorias.ToListAsync();

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre"; // Campo que se muestra en el ComboBox
            cmbCategoria.ValueMember = "Id"; // Campo que representa el valor de la categoría
            cmbCategoria.SelectedIndex = -1; // Para que no seleccione ninguna por defecto
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
