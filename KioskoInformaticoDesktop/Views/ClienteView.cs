﻿using System;
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
        BindingSource ListClientes = new BindingSource();
        Cliente clienteCurrent;
        public ClienteView()
        {
            InitializeComponent();
            dataGridClientesView.DataSourse = ListClientes;
            CargarGrilla();
        }


        private async Task CargarGrilla()
        {
            ListClientes.DataSource = await clienteService.GetAllAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);

        }

        private void bntModificar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)ListClientes.Current;
            txtNombre.Text = clienteCurrent.Nombre;
            tabControl.SelectedTab = (tabPageAgregarEditar);
        }

        private async void bntElimiar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)ListClientes.Current;

            if (clienteCurrent == null)
            {
                MessageBox.Show("Debe seleecionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FiltrarCliente();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre del cliente es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clienteCurrent != null)
            {
                clienteCurrent.Nombre = txtNombre.Text;
                await clienteService.UpdateAsync(clienteCurrent);
                clienteCurrent = null;
            }
            else
            {
                var localidad = new Localidad
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
            tabControl.SelectTab(tabPageLista);
        }
    }
}




