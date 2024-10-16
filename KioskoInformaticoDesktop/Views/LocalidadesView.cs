﻿using KioskoInformaticoServices.Interfaces;
using KioskoInformaticoServices.Models;
using KioskoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskoInformaticoService.Views
{
    public partial class LocalidadesView : Form
    {
        ILocalidadService localidadService = new LocalidadService();
        BindingSource ListLocalidades = new BindingSource();
        Localidad localidadCurrent;
        public LocalidadesView()
        {
            InitializeComponent();
            dataGridLocalidadesView.DataSource = ListLocalidades;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            ListLocalidades.DataSource = await localidadService.GetAllAsync();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la localidad es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (localidadCurrent != null)
            {
                localidadCurrent.Nombre = txtNombre.Text;
                await localidadService.UpdateAsync(localidadCurrent);
                localidadCurrent = null;
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


        private void bntModificar_Click(object sender, EventArgs e)
        {
            localidadCurrent = (Localidad)ListLocalidades.Current;
            txtNombre.Text = localidadCurrent.Nombre;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void bntElimiar_Click(object sender, EventArgs e)
        {
            localidadCurrent = (Localidad)ListLocalidades.Current;
            var result = MessageBox.Show($"¿Está seguro que desea eliminar la localidad? {localidadCurrent.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                localidadCurrent = (Localidad)ListLocalidades.Current;
                localidadService.DeleteAsync(localidadCurrent.Id);
                CargarGrilla();
            }
            localidadCurrent = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageLista);
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            FiltrarLocalidades();
        }

        private async void FiltrarLocalidades()
        {
            ListLocalidades.DataSource = await localidadService.GetAllAsync(txtFiltro.Text);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalidades();
        }

        
    }
}
