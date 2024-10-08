namespace KioscoInformaticoDesktop.Views
{
    partial class ProveedorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlLista = new TabControl();
            tabPageLista = new TabPage();
            bntSalir = new FontAwesome.Sharp.IconButton();
            bntElimiar = new FontAwesome.Sharp.IconButton();
            bntModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            bntBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtFiltro = new TextBox();
            dataGridLocalidadesView = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            txtCBU = new TextBox();
            label1 = new Label();
            comboLocalidades = new ComboBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            tabControlLista.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidadesView).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlLista
            // 
            tabControlLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlLista.Controls.Add(tabPageLista);
            tabControlLista.Controls.Add(tabPageAgregarEditar);
            tabControlLista.Location = new Point(31, 110);
            tabControlLista.Margin = new Padding(4);
            tabControlLista.Name = "tabControlLista";
            tabControlLista.SelectedIndex = 0;
            tabControlLista.Size = new Size(910, 384);
            tabControlLista.TabIndex = 5;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(bntSalir);
            tabPageLista.Controls.Add(bntElimiar);
            tabPageLista.Controls.Add(bntModificar);
            tabPageLista.Controls.Add(btnAgregar);
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(bntBuscar);
            tabPageLista.Controls.Add(label3);
            tabPageLista.Controls.Add(txtFiltro);
            tabPageLista.Controls.Add(dataGridLocalidadesView);
            tabPageLista.Location = new Point(4, 29);
            tabPageLista.Margin = new Padding(4);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(4);
            tabPageLista.Size = new Size(902, 351);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // bntSalir
            // 
            bntSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            bntSalir.IconColor = Color.Black;
            bntSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntSalir.ImageAlign = ContentAlignment.MiddleLeft;
            bntSalir.Location = new Point(736, 278);
            bntSalir.Margin = new Padding(4);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(124, 60);
            bntSalir.TabIndex = 12;
            bntSalir.Text = "&Salir";
            bntSalir.TextAlign = ContentAlignment.MiddleRight;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // bntElimiar
            // 
            bntElimiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntElimiar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            bntElimiar.IconColor = Color.Black;
            bntElimiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntElimiar.ImageAlign = ContentAlignment.MiddleLeft;
            bntElimiar.Location = new Point(736, 193);
            bntElimiar.Margin = new Padding(4);
            bntElimiar.Name = "bntElimiar";
            bntElimiar.Size = new Size(124, 59);
            bntElimiar.TabIndex = 11;
            bntElimiar.Text = "&Eliminar";
            bntElimiar.TextAlign = ContentAlignment.MiddleRight;
            bntElimiar.UseVisualStyleBackColor = true;
            bntElimiar.Click += bntElimiar_Click;
            // 
            // bntModificar
            // 
            bntModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntModificar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            bntModificar.IconColor = Color.Black;
            bntModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntModificar.ImageAlign = ContentAlignment.MiddleLeft;
            bntModificar.Location = new Point(736, 110);
            bntModificar.Margin = new Padding(4);
            bntModificar.Name = "bntModificar";
            bntModificar.Size = new Size(124, 59);
            bntModificar.TabIndex = 10;
            bntModificar.Text = "&Modificar";
            bntModificar.TextAlign = ContentAlignment.MiddleRight;
            bntModificar.UseVisualStyleBackColor = true;
            bntModificar.Click += bntModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(736, 23);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(124, 59);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "&Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(591, 35);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 47);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // bntBuscar
            // 
            bntBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            bntBuscar.IconColor = Color.Black;
            bntBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            bntBuscar.Location = new Point(1290, 39);
            bntBuscar.Margin = new Padding(4);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(107, 47);
            bntBuscar.TabIndex = 7;
            bntBuscar.Text = "&Buscar";
            bntBuscar.TextAlign = ContentAlignment.MiddleRight;
            bntBuscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 16);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "Buscar Producto:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(33, 45);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(552, 27);
            txtFiltro.TabIndex = 1;
            // 
            // dataGridLocalidadesView
            // 
            dataGridLocalidadesView.AllowUserToAddRows = false;
            dataGridLocalidadesView.AllowUserToDeleteRows = false;
            dataGridLocalidadesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLocalidadesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLocalidadesView.Location = new Point(33, 90);
            dataGridLocalidadesView.Margin = new Padding(4);
            dataGridLocalidadesView.Name = "dataGridLocalidadesView";
            dataGridLocalidadesView.ReadOnly = true;
            dataGridLocalidadesView.RowHeadersWidth = 51;
            dataGridLocalidadesView.Size = new Size(666, 221);
            dataGridLocalidadesView.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(txtCBU);
            tabPageAgregarEditar.Controls.Add(label1);
            tabPageAgregarEditar.Controls.Add(comboLocalidades);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(txtTelefono);
            tabPageAgregarEditar.Controls.Add(lblTelefono);
            tabPageAgregarEditar.Controls.Add(txtDireccion);
            tabPageAgregarEditar.Controls.Add(lblDireccion);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 29);
            tabPageAgregarEditar.Margin = new Padding(4);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(4);
            tabPageAgregarEditar.Size = new Size(902, 351);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // txtCBU
            // 
            txtCBU.Location = new Point(316, 155);
            txtCBU.Margin = new Padding(4);
            txtCBU.Name = "txtCBU";
            txtCBU.Size = new Size(224, 27);
            txtCBU.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 162);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 19;
            label1.Text = "Cbu:";
            // 
            // comboLocalidades
            // 
            comboLocalidades.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLocalidades.FormattingEnabled = true;
            comboLocalidades.Location = new Point(316, 205);
            comboLocalidades.Name = "comboLocalidades";
            comboLocalidades.Size = new Size(224, 28);
            comboLocalidades.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 205);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 17;
            label4.Text = "Localidad:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(316, 113);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(224, 27);
            txtTelefono.TabIndex = 16;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(216, 120);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 15;
            lblTelefono.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(316, 76);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(224, 27);
            txtDireccion.TabIndex = 14;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(211, 83);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 13;
            lblDireccion.Text = "Direccion:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(572, 243);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 64);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(73, 243);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 59);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(316, 39);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 27);
            txtNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 78);
            panel1.TabIndex = 6;
            // 
            // ProveedorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 534);
            Controls.Add(panel1);
            Controls.Add(tabControlLista);
            Name = "ProveedorView";
            Text = "Proveedores";
            tabControlLista.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidadesView).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlLista;
        private TabPage tabPageLista;
        private FontAwesome.Sharp.IconButton bntBuscar;
        private Label label3;
        private TextBox txtFiltro;
        private DataGridView dataGridLocalidadesView;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton bntModificar;
        private FontAwesome.Sharp.IconButton bntElimiar;
        private FontAwesome.Sharp.IconButton bntSalir;
        private Panel panel1;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label label4;
        private ComboBox comboLocalidades;
        private TextBox txtCBU;
        private Label label1;
    }
}