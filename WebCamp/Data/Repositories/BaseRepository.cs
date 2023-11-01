using WebCamp.Data.Repositories.Interfaces;

namespace WebCamp.Data.Repositories
{
	public class BaseRepository<T> : IBaseRepository<T>
	{
		protected readonly WebCampContext _context;

		public BaseRepository(WebCampContext context)
		{
			_context = context;
		}

		public async Task SaveChangesAsync()
		{
			await _context.SaveChangesAsync();
		}

		public async Task Add(T entity)
		{
			await Task.Run(() => _context.Add(entity));
		}

		public async Task Update(T entity)
		{
			await Task.Run(() => _context.Update(entity));
		}

		public async Task Delete(T entity)
		{
			await Task.Run(() => _context.Remove(entity));
		}
	}
}
