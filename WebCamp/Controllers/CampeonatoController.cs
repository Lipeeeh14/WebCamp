using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCamp.Domain.Model.Campeonato;
using WebCamp.Infra.Data;

namespace WebCamp.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CampeonatoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CampeonatoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultarCampeonatos()
        {
            return Ok(await _context.Campeonatos.ToListAsync());
        }
        
        [HttpGet]
        [Route("{campeonatoId}")]
        public async Task<IActionResult> ConsultarCampeonato(long campeonatoId)
        {
            var result = await _context.Campeonatos
                .Where(m => m.Id == campeonatoId)
                .FirstOrDefaultAsync();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarCampeonato(Campeonato campeonato)
        {
            await _context.AddAsync(campeonato);
            await _context.SaveChangesAsync();

            return Ok(campeonato);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarCampeonato(Campeonato campeonato)
        {
            var result = await _context.Campeonatos
                .Where(m => m.Id == campeonato.Id)
                .FirstOrDefaultAsync();

            if (campeonato == null)
                return NotFound();

            result = campeonato;

            await Task.Run(() => _context.Campeonatos.Update(result));

            return Ok(campeonato);
        }

        [HttpDelete]
        [Route("{campeonatoId}")]
        public async Task<IActionResult> Delete(long campeonatoId)
        {
            var campeonato = await _context.Campeonatos
                .FirstOrDefaultAsync(m => m.Id == campeonatoId);

            if (campeonato == null)
                return NotFound();

            await Task.Run(() => _context.Campeonatos.Remove(campeonato));

            return Ok(campeonato);
        }
    }
}
