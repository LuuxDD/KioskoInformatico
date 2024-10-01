using KioskoInformaticoServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskoInformaticoServices.Interfaces
{
    public interface IProveedorService : IGenericService<Proveedor>
    {
        public Task<List<Proveedor>?> GetAllAsync(string? filtro);
    }
   
}
