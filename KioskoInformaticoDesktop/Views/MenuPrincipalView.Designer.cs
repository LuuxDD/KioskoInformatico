﻿namespace KioskoInformaticoService
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            MenuItemPrincipal = new FontAwesome.Sharp.IconMenuItem();
            MenuItemBases = new FontAwesome.Sharp.IconMenuItem();
            MenuItemLocalidades = new FontAwesome.Sharp.IconMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            provedoresToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            MenuItemSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemPrincipal, MenuItemBases, iconMenuItem2, iconMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemPrincipal
            // 
            MenuItemPrincipal.IconChar = FontAwesome.Sharp.IconChar.House;
            MenuItemPrincipal.IconColor = Color.Black;
            MenuItemPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemPrincipal.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemPrincipal.Name = "MenuItemPrincipal";
            MenuItemPrincipal.Size = new Size(128, 52);
            MenuItemPrincipal.Text = "Principal";
            // 
            // MenuItemBases
            // 
            MenuItemBases.DropDownItems.AddRange(new ToolStripItem[] { MenuItemLocalidades, productosToolStripMenuItem, clientesToolStripMenuItem, provedoresToolStripMenuItem });
            MenuItemBases.IconChar = FontAwesome.Sharp.IconChar.Database;
            MenuItemBases.IconColor = Color.Black;
            MenuItemBases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemBases.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemBases.Name = "MenuItemBases";
            MenuItemBases.Size = new Size(108, 52);
            MenuItemBases.Text = "Bases";
            // 
            // MenuItemLocalidades
            // 
            MenuItemLocalidades.IconChar = FontAwesome.Sharp.IconChar.LocationPin;
            MenuItemLocalidades.IconColor = Color.Black;
            MenuItemLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemLocalidades.IconSize = 28;
            MenuItemLocalidades.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemLocalidades.Name = "MenuItemLocalidades";
            MenuItemLocalidades.Size = new Size(179, 34);
            MenuItemLocalidades.Text = "Localidades";
            MenuItemLocalidades.Click += MenuItemLocalidades_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(179, 34);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(179, 34);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // provedoresToolStripMenuItem
            // 
            provedoresToolStripMenuItem.Name = "provedoresToolStripMenuItem";
            provedoresToolStripMenuItem.Size = new Size(179, 34);
            provedoresToolStripMenuItem.Text = "Provedores";
            provedoresToolStripMenuItem.Click += provedoresToolStripMenuItem_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { MenuItemSalirDelSistema });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(100, 52);
            iconMenuItem2.Text = "Salir";
            // 
            // MenuItemSalirDelSistema
            // 
            MenuItemSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            MenuItemSalirDelSistema.IconColor = Color.Black;
            MenuItemSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemSalirDelSistema.IconSize = 32;
            MenuItemSalirDelSistema.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemSalirDelSistema.Name = "MenuItemSalirDelSistema";
            MenuItemSalirDelSistema.Size = new Size(214, 38);
            MenuItemSalirDelSistema.Text = "Salir del Sistema";
            MenuItemSalirDelSistema.Click += MenuItemSalirDelSistema_Click;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem3 });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(97, 52);
            iconMenuItem1.Text = "Listados";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(224, 26);
            iconMenuItem3.Text = "Localidades";
            iconMenuItem3.Click += iconMenuItem3_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kiosco Informatico Desktop";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuItemPrincipal;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem MenuItemBases;
        private FontAwesome.Sharp.IconMenuItem MenuItemSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem MenuItemLocalidades;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem provedoresToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
    }
}
