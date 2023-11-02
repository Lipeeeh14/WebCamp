using WebCamp.Domain.Models;

namespace WebCamp.Data.Repositories.Interfaces
{
	public interface ICampeonatoRepository : IBaseRepository<Campeonato>
	{
		Task<IEnumerable<Campeonato>> ConsultarCampeonatos();
		Task<Campeonato?> ObterCampeonatoPorId(long id);		
	}
}
