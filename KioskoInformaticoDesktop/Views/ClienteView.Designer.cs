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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            bntBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtFiltro = new TextBox();
            dataGridLocalidadesView = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            bntModificar = new FontAwesome.Sharp.IconButton();
            bntElimiar = new FontAwesome.Sharp.IconButton();
            bntSalir = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tabControlLista.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidadesView).BeginInit();
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
            tabControlLista.Location = new Point(51, 107);
            tabControlLista.Margin = new Padding(4);
            tabControlLista.Name = "tabControlLista";
            tabControlLista.SelectedIndex = 0;
            tabControlLista.Size = new Size(727, 369);
            tabControlLista.TabIndex = 5;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(iconButton1);
            tabPageLista.Controls.Add(bntBuscar);
            tabPageLista.Controls.Add(label3);
            tabPageLista.Controls.Add(txtFiltro);
            tabPageLista.Controls.Add(dataGridLocalidadesView);
            tabPageLista.Location = new Point(4, 29);
            tabPageLista.Margin = new Padding(4);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(4);
            tabPageLista.Size = new Size(719, 336);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(592, 35);
            iconButton1.Margin = new Padding(4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(107, 47);
            iconButton1.TabIndex = 9;
            iconButton1.Text = "&Buscar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // bntBuscar
            // 
            bntBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            bntBuscar.IconColor = Color.Black;
            bntBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            bntBuscar.Location = new Point(1107, 39);
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
            dataGridLocalidadesView.Size = new Size(657, 214);
            dataGridLocalidadesView.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 29);
            tabPageAgregarEditar.Margin = new Padding(4);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(4);
            tabPageAgregarEditar.Size = new Size(719, 336);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
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
            txtNombre.Location = new Point(320, 130);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 27);
            txtNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(818, 133);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(124, 59);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "&Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // bntModificar
            // 
            bntModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntModificar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            bntModificar.IconColor = Color.Black;
            bntModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntModificar.ImageAlign = ContentAlignment.MiddleLeft;
            bntModificar.Location = new Point(818, 226);
            bntModificar.Margin = new Padding(4);
            bntModificar.Name = "bntModificar";
            bntModificar.Size = new Size(124, 59);
            bntModificar.TabIndex = 7;
            bntModificar.Text = "&Modificar";
            bntModificar.TextAlign = ContentAlignment.MiddleRight;
            bntModificar.UseVisualStyleBackColor = true;
            bntModificar.Click += bntModificar_Click;
            // 
            // bntElimiar
            // 
            bntElimiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntElimiar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            bntElimiar.IconColor = Color.Black;
            bntElimiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntElimiar.ImageAlign = ContentAlignment.MiddleLeft;
            bntElimiar.Location = new Point(818, 317);
            bntElimiar.Margin = new Padding(4);
            bntElimiar.Name = "bntElimiar";
            bntElimiar.Size = new Size(124, 59);
            bntElimiar.TabIndex = 8;
            bntElimiar.Text = "&Eliminar";
            bntElimiar.TextAlign = ContentAlignment.MiddleRight;
            bntElimiar.UseVisualStyleBackColor = true;
            bntElimiar.Click += bntElimiar_Click;
            // 
            // bntSalir
            // 
            bntSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            bntSalir.IconColor = Color.Black;
            bntSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntSalir.ImageAlign = ContentAlignment.MiddleLeft;
            bntSalir.Location = new Point(818, 400);
            bntSalir.Margin = new Padding(4);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(124, 60);
            bntSalir.TabIndex = 9;
            bntSalir.Text = "&Salir";
            bntSalir.TextAlign = ContentAlignment.MiddleRight;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // ClienteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 515);
            Controls.Add(bntSalir);
            Controls.Add(bntElimiar);
            Controls.Add(bntModificar);
            Controls.Add(btnAgregar);
            Controls.Add(tabControlLista);
            Controls.Add(panel1);
            Name = "ClienteView";
            Text = "ClienteView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlLista.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidadesView).EndInit();
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
        private DataGridView dataGridLocalidadesView;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton bntModificar;
        private FontAwesome.Sharp.IconButton bntElimiar;
        private FontAwesome.Sharp.IconButton bntSalir;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}