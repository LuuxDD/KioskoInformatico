﻿using KioskoInformaticoServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskoInformaticoServices.Interfaces
{
    internal interface IClienteService
    {
        public interface IClienteService : IGenericService<Cliente>

        {
            public Task<List<Cliente>?> GetAllAsync(string? filtro);
        }
    }
}
