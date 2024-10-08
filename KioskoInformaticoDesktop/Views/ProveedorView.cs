using KioskoInformaticoServices.Models;
using KioskoInformaticoServices.Interfaces;
using KioskoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ProveedorView : Form
    {

        IGenericService<Proveedor> proveedorService = new GenericService<Proveedor>();
        ILocalidadService localidadService = new LocalidadService();
        BindingSource ListProveedor = new BindingSource();
        List<Proveedor> ListaAFiltrar = new List<Proveedor>();
        Proveedor proveedorCurrent;
        public ProveedorView()
        {
            InitializeComponent();
            dataGridLocalidadesView.DataSource = ListProveedor;
            CargarGrilla();
            CargarCombo();
        }

        private async Task CargarCombo()
        {
            comboLocalidades.DataSource = await proveedorService.GetAllAsync();
            comboLocalidades.DisplayMember = "Nombre";
            comboLocalidades.ValueMember = "Id";
            comboLocalidades.SelectedIndex = 0;
        }

        private async Task CargarGrilla()
        {
            ListProveedor.DataSource = await proveedorService.GetAllAsync();
            ListaAFiltrar = ListProveedor.DataSource as List<Proveedor>;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControlLista.SelectTab(tabPageAgregarEditar);
        }

        private void bntModificar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = (Proveedor)ListProveedor.Current;
            txtNombre.Text = proveedorCurrent.Nombre;
            txtDireccion.Text = proveedorCurrent.Direccion;
            txtTelefono.Text = proveedorCurrent.Telefonos;
            txtCBU.Text = proveedorCurrent.Cbu;
            comboLocalidades.SelectedValue = proveedorCurrent.LocalidadId;
            tabControlLista.SelectTab(tabPageAgregarEditar);
        }

        private async void bntElimiar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea eliminar el proveedor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                proveedorCurrent = ListProveedor.Current as Proveedor;
                if (proveedorCurrent != null)
                {
                    await proveedorService.DeleteAsync(proveedorCurrent.Id);
                    await CargarGrilla();
                }
            }
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void FiltrarProveedor()
        {
            var ProveedorFiltrados = ListaAFiltrar.Where(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).ToList();
            ListProveedor.DataSource = ProveedorFiltrados;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {


            if (proveedorCurrent != null)
            {
                proveedorCurrent.Nombre = txtNombre.Text;
                proveedorCurrent.Direccion = txtDireccion.Text;
                proveedorCurrent.Telefonos = txtTelefono.Text;
                proveedorCurrent.LocalidadId = (int)comboLocalidades.SelectedValue;
                proveedorCurrent.Cbu = txtCBU.Text;

            }
            else
            {
                var proveedor = new Proveedor
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefonos = txtTelefono.Text,
                    LocalidadId = (int)comboLocalidades.SelectedValue,
                    Cbu = txtCBU.Text


                };
                await proveedorService.AddAsync(proveedor);
            }

            await CargarGrilla();

            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCBU.Text = string.Empty;
            

            tabControlLista.SelectTab(tabPageLista);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {


            proveedorCurrent = null;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCBU.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            tabControlLista.SelectTab(tabPageLista);

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            FiltrarProveedor();
        }
    }
}
