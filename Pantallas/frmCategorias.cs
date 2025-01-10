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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();

        }
        private void CargarCategorias()
        {
            dgvCategorias.DataSource = Categoria.ObtenerCategorias();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevaCategoria = new Categoria
            {
                Nombre = txtNombre.Text
            };

            Categoria.AgregarCategoria(nuevaCategoria);
            MessageBox.Show("Categoría agregada con éxito.");
            CargarCategorias();
            LimpiarFormulario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                var categoriaSeleccionada = (Categoria)dgvCategorias.SelectedRows[0].DataBoundItem;
                categoriaSeleccionada.Nombre = txtNombre.Text;

                Categoria.ActualizarCategoria(categoriaSeleccionada);
                MessageBox.Show("Categoría actualizada con éxito.");
                CargarCategorias();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                var categoriaSeleccionada = (Categoria)dgvCategorias.SelectedRows[0].DataBoundItem;

                Categoria.EliminarCategoria(categoriaSeleccionada.Id);
                MessageBox.Show("Categoría eliminada con éxito.");
                CargarCategorias();
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim();

            using (var context = new SqLiteDbContext())
            {
                var categoriasFiltradas = context.Categorias
                                                .Where(c => c.Nombre.Contains(criterio))
                                                .ToList();
                dgvCategorias.DataSource = categoriasFiltradas;
            }
        }
        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                var categoriaSeleccionada = (Categoria)dgvCategorias.SelectedRows[0].DataBoundItem;
                txtNombre.Text = categoriaSeleccionada.Nombre;
            }
        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            dgvCategorias.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarCategorias();
        }
    }
}
