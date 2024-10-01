namespace KioscoInformaticoDesktop.Views
{
    partial class ClienteView
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
            panel1 = new Panel();
            label1 = new Label();
            tabControlLista = new TabControl();
            tabPageLista = new TabPage();
            bntSalir = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            bntElimiar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            bntModificar = new FontAwesome.Sharp.IconButton();
            txtFiltro = new TextBox();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dataGridClientesView = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            label6 = new Label();
            dateTimeFechaNacimiento = new DateTimePicker();
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
            panel1.SuspendLayout();
            tabControlLista.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientesView).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 13);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 70);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 41);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // tabControlLista
            // 
            tabControlLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlLista.Controls.Add(tabPageLista);
            tabControlLista.Controls.Add(tabPageAgregarEditar);
            tabControlLista.Location = new Point(13, 91);
            tabControlLista.Margin = new Padding(4);
            tabControlLista.Name = "tabControlLista";
            tabControlLista.SelectedIndex = 0;
            tabControlLista.Size = new Size(958, 411);
            tabControlLista.TabIndex = 0;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(bntSalir);
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(bntElimiar);
            tabPageLista.Controls.Add(label3);
            tabPageLista.Controls.Add(bntModificar);
            tabPageLista.Controls.Add(txtFiltro);
            tabPageLista.Controls.Add(btnAgregar);
            tabPageLista.Controls.Add(dataGridClientesView);
            tabPageLista.Location = new Point(4, 29);
            tabPageLista.Margin = new Padding(4);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(4);
            tabPageLista.Size = new Size(950, 378);
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
            bntSalir.Location = new Point(801, 284);
            bntSalir.Margin = new Padding(4);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(124, 60);
            bntSalir.TabIndex = 9;
            bntSalir.Text = "&Salir";
            bntSalir.TextAlign = ContentAlignment.MiddleRight;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(630, 35);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 47);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += iconButton1_Click;
            // 
            // bntElimiar
            // 
            bntElimiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntElimiar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            bntElimiar.IconColor = Color.Black;
            bntElimiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntElimiar.ImageAlign = ContentAlignment.MiddleLeft;
            bntElimiar.Location = new Point(801, 202);
            bntElimiar.Margin = new Padding(4);
            bntElimiar.Name = "bntElimiar";
            bntElimiar.Size = new Size(124, 59);
            bntElimiar.TabIndex = 8;
            bntElimiar.Text = "&Eliminar";
            bntElimiar.TextAlign = ContentAlignment.MiddleRight;
            bntElimiar.UseVisualStyleBackColor = true;
            bntElimiar.Click += bntElimiar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 16);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Buscar Cliente:";
            // 
            // bntModificar
            // 
            bntModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntModificar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            bntModificar.IconColor = Color.Black;
            bntModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntModificar.ImageAlign = ContentAlignment.MiddleLeft;
            bntModificar.Location = new Point(801, 118);
            bntModificar.Margin = new Padding(4);
            bntModificar.Name = "bntModificar";
            bntModificar.Size = new Size(124, 59);
            bntModificar.TabIndex = 7;
            bntModificar.Text = "&Modificar";
            bntModificar.TextAlign = ContentAlignment.MiddleRight;
            bntModificar.UseVisualStyleBackColor = true;
            bntModificar.Click += bntModificar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(33, 45);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(552, 27);
            txtFiltro.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(801, 35);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(124, 59);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "&Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridClientesView
            // 
            dataGridClientesView.AllowUserToAddRows = false;
            dataGridClientesView.AllowUserToDeleteRows = false;
            dataGridClientesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClientesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientesView.Location = new Point(33, 90);
            dataGridClientesView.Margin = new Padding(4);
            dataGridClientesView.Name = "dataGridClientesView";
            dataGridClientesView.ReadOnly = true;
            dataGridClientesView.RowHeadersWidth = 51;
            dataGridClientesView.Size = new Size(666, 219);
            dataGridClientesView.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(dateTimeFechaNacimiento);
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
            tabPageAgregarEditar.Size = new Size(950, 378);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(217, 225);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 19;
            label6.Text = "Fecha de Nacimiento:";
            // 
            // dateTimeFechaNacimiento
            // 
            dateTimeFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimeFechaNacimiento.Location = new Point(413, 220);
            dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            dateTimeFechaNacimiento.Size = new Size(224, 27);
            dateTimeFechaNacimiento.TabIndex = 4;
            // 
            // comboLocalidades
            // 
            comboLocalidades.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLocalidades.FormattingEnabled = true;
            comboLocalidades.Location = new Point(413, 171);
            comboLocalidades.Name = "comboLocalidades";
            comboLocalidades.Size = new Size(224, 28);
            comboLocalidades.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 179);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 16;
            label4.Text = "Localidad:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(413, 131);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(224, 27);
            txtTelefono.TabIndex = 1;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(292, 138);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(413, 92);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(224, 27);
            txtDireccion.TabIndex = 0;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(287, 99);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Direccion:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(524, 272);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 53);
            btnCancelar.TabIndex = 6;
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
            btnGuardar.Location = new Point(314, 272);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 53);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(413, 52);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 27);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // ClienteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 515);
            Controls.Add(tabControlLista);
            Controls.Add(panel1);
            Name = "ClienteView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClienteView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlLista.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientesView).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControlLista;
        private TabPage tabPageLista;
        private FontAwesome.Sharp.IconButton bntBuscar;
        private Label label3;
        private TextBox txtFiltro;
        private DataGridView dataGridClientesView;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton bntModificar;
        private FontAwesome.Sharp.IconButton bntElimiar;
        private FontAwesome.Sharp.IconButton bntSalir;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtTelefono;
        private Label label5;
        private Label lblTelefono;
        private ComboBox comboLocalidades;
        private Label label4;
        private DateTimePicker dateTimeFechaNacimiento;
        private Label label6;
    }
}