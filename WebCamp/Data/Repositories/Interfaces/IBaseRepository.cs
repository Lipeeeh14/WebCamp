namespace WebCamp.Data.Repositories.Interfaces
{
	public interface IBaseRepository<T>
	{
		Task SaveChangesAsync();
		Task Add(T entity);
		Task Update(T entity);
		Task Delete(T entity);
	}
}
