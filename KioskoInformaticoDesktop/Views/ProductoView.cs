using KioskoInformaticoServices.Interfaces;
using KioskoInformaticoServices.Models;
using KioskoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ProductoView : Form

    {
        IGenericService<Producto> productoService = new GenericService<Producto>();
        BindingSource ListProductos = new BindingSource();
        List<Producto> ListaAFiltrar = new List<Producto>();
        Producto productoCurrent;

        public ProductoView()
        {
            InitializeComponent();
            dataGridLocalidadesView.DataSource = ListProductos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            ListProductos.DataSource = await productoService.GetAllAsync();
            ListaAFiltrar = ListProductos.DataSource as List<Producto>;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private void bntModificar_Click(object sender, EventArgs e)
        {
            productoCurrent = (Producto)ListProductos.Current;
            txtNombre.Text = productoCurrent.Nombre;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void bntElimiar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productoCurrent = ListProductos.Current as Producto;
                if (productoCurrent != null)
                {
                    await productoService.DeleteAsync(productoCurrent.Id);
                    await CargarGrilla();
                }
            }
        }

        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (productoCurrent != null)
            {
                productoCurrent.Nombre = txtNombre.Text;
                await productoService.UpdateAsync(productoCurrent);
                productoCurrent = null;
            }
            else
            {
                var producto = new Producto
                {
                    Nombre = txtNombre.Text
                };
            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void FiltrarProductos()
        {
            var ProductosFiltrados = ListaAFiltrar.Where(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).ToList();
            ListProductos.DataSource = ProductosFiltrados;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }
    }
}
