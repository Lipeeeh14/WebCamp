using WebCamp.Data.Repositories.Interfaces;
using WebCamp.Domain.Services.Interfaces;
using WebCamp.DTOs;
using WebCamp.ViewModels;

namespace WebCamp.Domain.Services
{
	public class CampeonatoService : ICampeonatoService
	{
		private readonly ICampeonatoRepository _repository;

		public CampeonatoService(ICampeonatoRepository repository)
		{
			_repository = repository;
		}

		public Task<CampeonatoViewModel> ObterCampeonatoPorId(long id)
		{
			throw new NotImplementedException();
		}

		public Task<CampeonatoViewModel> CadastrarCampeonato(CampeonatoDTO campeonatoDTO)
		{
			throw new NotImplementedException();
		}

		public Task<CampeonatoViewModel> AtualizarCampeonato(CampeonatoDTO campeonatoDTO)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DeletarCampeonato(long id)
		{
			throw new NotImplementedException();
		}
	}
}
