﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KioscoInformaticoBackend.DataContext;
using KioskoInformaticoServices;
using KioskoInformaticoServices.Models;

namespace KioscoInformaticoBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedoresController : ControllerBase
    {
        private readonly KioscoContext _context;

        public ProveedoresController(KioscoContext context)
        {
            _context = context;
        }

        // GET: api/Proveedores
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Proveedor>>> GetProveedores([FromQuery] string? filtro)
        {
            if (filtro != null)
            {
                return await _context.Proveedores.Include(p => p.Localidad).Where(p => p.Nombre.ToUpper().Contains(filtro.ToUpper())).ToListAsync();
            }
            return await _context.Proveedores.Include(p => p.Localidad).ToListAsync();
        }

        // GET: api/Proveedores/5
        [HttpGet("{id}")]
        
        public async Task<ActionResult<Proveedor>> GetProveedor(int id)
        {
            var proveedor = await _context.Proveedores.FindAsync(id);

            if (proveedor == null)
            {
                return NotFound();
            }

            return proveedor;
        }

        // PUT: api/Proveedores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProveedor(int id, Proveedor proveedor)
        {
            if (id != proveedor.Id)
            {
                return BadRequest();
            }

            _context.Entry(proveedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProveedorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Proveedores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Proveedor>> PostProveedor(Proveedor proveedor)
        {
            _context.Proveedores.Add(proveedor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProveedor", new { id = proveedor.Id }, proveedor);
        }

        // DELETE: api/Proveedores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProveedor(int id)
        {
            var proveedor = await _context.Proveedores.FindAsync(id);
            if (proveedor == null)
            {
                return NotFound();
            }

            proveedor.Eliminado = true;
            _context.Proveedores.Update(proveedor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProveedorExists(int id)
        {
            return _context.Proveedores.Any(e => e.Id == id);
        }
    }
}
