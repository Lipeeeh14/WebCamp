using AutoMapper;
using WebCamp.Data.Repositories.Interfaces;
using WebCamp.Domain.Enums;
using WebCamp.Domain.Models;
using WebCamp.Domain.Services.Interfaces;
using WebCamp.DTOs;
using WebCamp.ViewModels;

namespace WebCamp.Domain.Services
{
	public class CampeonatoService : ICampeonatoService
	{
		private readonly ICampeonatoRepository _repository;
		private readonly IMapper _mapper;

		public CampeonatoService(ICampeonatoRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public IEnumerable<TipoCampeonatoViewModel> ObterTiposCampeonato()
		{
			return _mapper.Map<IEnumerable<TipoCampeonatoViewModel>>(
				Enumeration.GetAll<TipoCampeonatoEnum>());
		}

		public async Task<IEnumerable<CampeonatoViewModel>> ConsultarCampeonatos()
		{
			var campeonatos = await _repository.ConsultarCampeonatos();
			return _mapper.Map<IEnumerable<CampeonatoViewModel>>(campeonatos);
		}

		public async Task<CampeonatoViewModel> ObterCampeonatoPorId(long id)
		{
			var campeonato = await _repository.ObterCampeonatoPorId(id);
			return _mapper.Map<CampeonatoViewModel>(campeonato);
		}

		public async Task<CampeonatoViewModel> CadastrarCampeonato(CampeonatoDTO campeonatoDTO)
		{
			var campeonato = _mapper.Map<Campeonato>(campeonatoDTO);

			await _repository.Add(campeonato);
			await _repository.SaveChangesAsync();

			return _mapper.Map<CampeonatoViewModel>(campeonato);
		}

		public async Task<CampeonatoViewModel> AtualizarCampeonato(CampeonatoDTO campeonatoDTO)
		{
			var campeonato = await _repository.ObterCampeonatoPorId(campeonatoDTO.Id) ?? throw new Exception("Campeonato inválido.");

			campeonato.AtualizarCampeonato(campeonatoDTO.Nome, campeonatoDTO.Ativo, campeonatoDTO.TipoCampeonatoId);
		
			await _repository.Update(campeonato);
			await _repository.SaveChangesAsync();

			return _mapper.Map<CampeonatoViewModel>(campeonato);
		}

		public async Task<bool> DeletarCampeonato(long id)
		{
			var campeonato = await _repository.ObterCampeonatoPorId(id);

			if (campeonato == null) return false;
			
			await _repository.Delete(campeonato);
			await _repository.SaveChangesAsync();

			return true;
		}

		public async Task<CampeonatoViewModel> FinalizarCampeonato(long id)
		{
			var campeonato = await _repository.ObterCampeonatoPorId(id) ?? throw new Exception("Campeonato inválido.");

			campeonato.FinalizarCampeonato();

			await _repository.Update(campeonato);
			await _repository.SaveChangesAsync();

			return _mapper.Map<CampeonatoViewModel>(campeonato);
		}
	}
}
