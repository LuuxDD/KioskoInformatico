using KioscoInformaticoApp.Utils;
using KioskoInformaticoServices.Models;
using KioskoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
    public class ProductosViewModel : ObjectNotification
    {
        private GenericService<Producto> productoService= new GenericService<Producto>();
        private string filterProducts;

        public string FilterProducts
        {
            get { return filterProducts; }
            set { filterProducts = value; OnPropertyChanged();
                                         _ = FiltrarProductos();     
            }
        }
        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;

            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Producto> productos;

        public ObservableCollection<Producto> Productos

        {
            get { return productos; }
            set { productos = value; OnPropertyChanged(); }
        }

        public Command ObtenerProductosCommand { get; set; }
        public Command FiltrarProductosCommand { get; set; }

        private List<Producto>? productosListToFilter;

        private bool activityStart;
        public bool ActivityStart
        {
            get { return activityStart; }
            set { activityStart = value; OnPropertyChanged(); }
        }

        public ProductosViewModel()
        {
            ObtenerProductosCommand = new Command(async () => await ObtenerProductos());
            FiltrarProductosCommand = new Command(async () => await FilterProductsList());
        }

        private async Task FilterProductsList()
        {
            var productosFiltrados = productosListToFilter.Where(p => p.Nombre.Contains(FilterProducts));
            Productos = new ObservableCollection<Producto>(productosFiltrados); 
        }

        private async Task ObtenerProductos()
        {
            ActivityStart = true;
            productosListToFilter = await productoService.GetAllAsync();
            Productos = new ObservableCollection<Producto>(productosListToFilter);
            ActivityStart = false;

        }
    }
}
