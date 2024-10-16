﻿using KioskoInformaticoServices.Interfaces;
using KioskoInformaticoServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using KioskoInformaticoServices.Class;

namespace KioskoInformaticoServices.Services
{
        public class ClienteService : GenericService<Cliente>, IClienteService
        {
            public async Task<List<Cliente>?> GetAllAsync(string? filtro)
            {
                var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
                var content = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    throw new ApplicationException(content?.ToString());
                }
                return JsonSerializer.Deserialize<List<Cliente>>(content, options); ;
            }

        }

    
}
