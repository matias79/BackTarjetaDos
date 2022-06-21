using BackTarjeta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackTarjeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tarjetaController : ControllerBase
    {
        private readonly apiDbContext _context;
        public tarjetaController(apiDbContext context)
        {
            _context = context;

        }
        // GET: api/<tarjetaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listTarjetas = await _context.CreditoTarjeta.ToListAsync();
                return Ok(listTarjetas);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // POST api/<tarjetaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] tarjetaCredito tarjeta)
        {
            try
            {
                _context.Add(tarjeta);
                await _context.SaveChangesAsync();
                return Ok(tarjeta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<tarjetaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] tarjetaCredito tarjeta)
        {
            try
            {
                if(id != tarjeta.Id)
                {
                    return NotFound();
                }
                _context.Update(tarjeta);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Datos actualizados correctamente"});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<tarjetaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var tarjeta = await _context.CreditoTarjeta.FindAsync(id);
                if(tarjeta == null)
                {
                    return NotFound();
                }
                _context.CreditoTarjeta.Remove(tarjeta);
                await _context.SaveChangesAsync();
                return Ok(new { message = "la tarjeta se elimino correctamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
