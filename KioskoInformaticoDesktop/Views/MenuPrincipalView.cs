using KioscoInformaticoDesktop.Views;
using KioskoInformaticoService.Views;

namespace KioskoInformaticoService
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void MenuItemSalirDelSistema_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir del sistema?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MenuItemLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesView localidadesView = new LocalidadesView();
            localidadesView.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoView productoView = new ProductoView();
            productoView.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteView clienteView = new ClienteView();
            clienteView.ShowDialog();
        }

        private void provedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ProveedorView proveedorView = new ProveedorView();
                proveedorView.ShowDialog();  
        }
    }
}
