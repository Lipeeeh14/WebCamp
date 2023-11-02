using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCamp.Domain.Services.Interfaces;
using WebCamp.DTOs;

namespace WebCamp.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class CampeonatoController : ControllerBase
	{
		/* TODO: Implementar classe genérica para padronizar os retornos: https://www.youtube.com/watch?v=LghxA6lPfBA */

		private readonly ICampeonatoService _campeonatoService;

		public CampeonatoController(ICampeonatoService campeonatoService)
		{
			_campeonatoService = campeonatoService;
		}

		[HttpGet]
		[Route("tipos")]
		public IActionResult ObterTiposCampeonato() =>
			Ok(_campeonatoService.ObterTiposCampeonato());

		[HttpGet]
		public async Task<IActionResult> ConsultarCampeonatos()
		{
			try
			{
				return Ok(await _campeonatoService.ConsultarCampeonatos());
			}
			catch (Exception)
			{
				return BadRequest("Erro ao consultar os campeonatos!");
			}
		}

		[HttpGet]
		[Route("{id}")]
		public async Task<IActionResult> ObterCampeonatoPorId(long id) 
		{
			try
			{
				var result = await _campeonatoService.ObterCampeonatoPorId(id);

				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception)
			{
				return BadRequest("Erro ao consultar o campeonato!");
			}
		}

		[HttpPost]
		public async Task<IActionResult> CadastrarCampeonato(CampeonatoDTO campeonatoDTO)
		{
			try
			{
				var result = await _campeonatoService.CadastrarCampeonato(campeonatoDTO);

				return Ok(result);
			}
			catch (Exception)
			{
				return BadRequest("Erro ao cadastrar o campeonato!");
			}
		}

		[HttpPut]
		public async Task<IActionResult> AtualizarCampeonato(CampeonatoDTO campeonatoDTO)
		{
			try
			{
				var result = await _campeonatoService.AtualizarCampeonato(campeonatoDTO);

				return Ok(result);
			}
			catch (Exception)
			{
				return BadRequest("Erro ao atualizar o campeonato!");
			}
		}

		[HttpDelete]
		[Route("{id}")]
		public async Task<IActionResult> DeletarCampeonato(long id)
		{
			try
			{
				var result = await _campeonatoService.DeletarCampeonato(id);

				if (!result)
					return BadRequest("Erro ao deletar o campeonato!");

				return Ok(result);
			}
			catch (Exception)
			{
				return BadRequest("Erro ao deletar o campeonato!");
			}
		}

		[HttpPatch]
		[Route("{id}/finalizar")]
		public async Task<IActionResult> FinalizarCampeonato(long id) 
		{
			try
			{
				var result = await _campeonatoService.FinalizarCampeonato(id);

				return Ok(result);
			}
			catch (Exception)
			{
				return BadRequest("Erro ao finalizar o campeonato!");
			}
		}
	}
}
