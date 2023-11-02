using WebCamp.DTOs;
using WebCamp.ViewModels;

namespace WebCamp.Domain.Services.Interfaces
{
	public interface ICampeonatoService
	{
		IEnumerable<TipoCampeonatoViewModel> ObterTiposCampeonato();
		Task<IEnumerable<CampeonatoViewModel>> ConsultarCampeonatos();
		Task<CampeonatoViewModel> ObterCampeonatoPorId(long id);
		Task<CampeonatoViewModel> CadastrarCampeonato(CampeonatoDTO campeonatoDTO);
		Task<CampeonatoViewModel> AtualizarCampeonato(CampeonatoDTO campeonatoDTO);
		Task<bool> DeletarCampeonato(long id);
		Task<CampeonatoViewModel> FinalizarCampeonato(long id);
	}
}
