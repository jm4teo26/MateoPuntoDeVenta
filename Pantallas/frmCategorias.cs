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
            using (var context = new SqLiteDbContext())
            {
                dgvCategorias.DataSource = context.Categorias.ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la categoría es obligatorio.", "Advertencia");
                return;
            }

            using (var context = new SqLiteDbContext())
            {
                var nuevaCategoria = new Categoria
                {
                    Nombre = txtNombre.Text.Trim()
                };

                context.Categorias.Add(nuevaCategoria);
                context.SaveChanges();
            }

            MessageBox.Show("Categoría agregada correctamente.");
            txtNombre.Clear();
            CargarCategorias();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para actualizar.", "Advertencia");
                return;
            }

            int idCategoria = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["Id"].Value);

            using (var context = new SqLiteDbContext())
            {
                var categoria = context.Categorias.Find(idCategoria);
                if (categoria != null)
                {
                    categoria.Nombre = txtNombre.Text.Trim();
                    context.SaveChanges();

                    MessageBox.Show("Categoría actualizada correctamente.");
                    txtNombre.Clear();
                    CargarCategorias();
                }
                else
                {
                    MessageBox.Show("Categoría no encontrada.", "Error");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Advertencia");
                return;
            }

            int idCategoria = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["Id"].Value);

            using (var context = new SqLiteDbContext())
            {
                var categoria = context.Categorias.Find(idCategoria);
                if (categoria != null)
                {
                    context.Categorias.Remove(categoria);
                    context.SaveChanges();

                    MessageBox.Show("Categoría eliminada correctamente.");
                    txtNombre.Clear();
                    CargarCategorias();
                }
                else
                {
                    MessageBox.Show("Categoría no encontrada.", "Error");
                }
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
                txtNombre.Text = dgvCategorias.SelectedRows[0].Cells["Nombre"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarCategorias();
            MessageBox.Show("Datos actualizados correctamente.", "Información");
        }
    }
}
