using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using KioskoInformaticoServices.Models;
using KioskoInformaticoServices.Services;
using KioskoInformaticoServices.Interfaces;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ClienteView : Form
    {
        IClienteService clienteService = new ClienteService();
        ILocalidadService localidadService = new LocalidadService();
        BindingSource ListClientes = new BindingSource();
        Cliente clienteCurrent;
        public ClienteView()
        {
            InitializeComponent();
            dataGridClientesView.DataSource = ListClientes;
            CargarGrilla();
            CargarCombo();
        }

        private async Task CargarCombo()
        {
            comboLocalidades.DataSource = await localidadService.GetAllAsync();
            comboLocalidades.DisplayMember = "Nombre";
            comboLocalidades.ValueMember = "Id";
            comboLocalidades.SelectedIndex = 0;
        }

        private async Task CargarGrilla()
        {
            ListClientes.DataSource = await clienteService.GetAllAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControlLista.SelectTab(tabPageAgregarEditar);

        }

        private void bntModificar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)ListClientes.Current;
            txtNombre.Text = clienteCurrent.Nombre;
            lblDireccion.Text = clienteCurrent.Direccion;
            lblTelefono.Text = clienteCurrent.Telefonos;
            comboLocalidades.SelectedValue = clienteCurrent.LocalidadId;
            tabControlLista.SelectedTab = (tabPageAgregarEditar);
        }

        private async void bntElimiar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)ListClientes.Current;

            if (clienteCurrent == null)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var result = MessageBox.Show($"¿Está seguro que desea eliminar el cliente {clienteCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                clienteCurrent = (Cliente)ListClientes.Current;
                if (clienteCurrent != null)
                {
                    await clienteService.DeleteAsync(clienteCurrent.Id);
                    await CargarGrilla();
                }
            }
            clienteCurrent = null;
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FiltrarCliente()
        {
           ListClientes.DataSource = await clienteService.GetAllAsync(txtFiltro.Text);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FiltrarCliente();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {


            if (clienteCurrent != null)
            {
                clienteCurrent.Nombre = txtNombre.Text;
                clienteCurrent.Direccion = txtDireccion.Text;
                clienteCurrent.Telefonos = txtTelefono.Text;
                clienteCurrent.LocalidadId = (int)comboLocalidades.SelectedValue;
                await clienteService.UpdateAsync(clienteCurrent);
                clienteCurrent = null;
            }
            else
            {
                var cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefonos = txtTelefono.Text,
                    LocalidadId = (int)comboLocalidades.SelectedValue
                };
                await clienteService.AddAsync(cliente);
            }

            await CargarGrilla();

            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            tabControlLista.SelectTab(tabPageLista);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteCurrent = null;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            comboLocalidades.SelectedIndex = 0;
            tabControlLista.SelectTab(tabPageLista);
        }


    }
}




