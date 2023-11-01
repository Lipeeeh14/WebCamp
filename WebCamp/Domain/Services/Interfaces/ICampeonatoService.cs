using WebCamp.DTOs;
using WebCamp.ViewModels;

namespace WebCamp.Domain.Services.Interfaces
{
	public interface ICampeonatoService
	{
		Task<CampeonatoViewModel> ObterCampeonatoPorId(long id);
		Task<CampeonatoViewModel> CadastrarCampeonato(CampeonatoDTO campeonatoDTO);
		Task<CampeonatoViewModel> AtualizarCampeonato(CampeonatoDTO campeonatoDTO);
		Task<bool> DeletarCampeonato(long id);
	}
}
