using Microsoft.EntityFrameworkCore;
using WebCamp.Data.Repositories.Interfaces;
using WebCamp.Domain.Models;

namespace WebCamp.Data.Repositories
{
	public class CampeonatoRepository : BaseRepository<Campeonato>, ICampeonatoRepository 
	{
		public CampeonatoRepository(WebCampContext context) : base(context)
		{
		}

		public async Task<Campeonato?> ObterCampeonatoPorId(long id)
		{
			return await _context.Campeonato
				.Include(x => x.Times)
				.FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}
