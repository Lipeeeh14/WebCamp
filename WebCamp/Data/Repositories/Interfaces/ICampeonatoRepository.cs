using WebCamp.Domain.Models;

namespace WebCamp.Data.Repositories.Interfaces
{
	public interface ICampeonatoRepository : IBaseRepository<Campeonato>
	{
		Task<Campeonato?> ObterCampeonatoPorId(long id);
	}
}
