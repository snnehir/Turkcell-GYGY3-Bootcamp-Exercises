using Gardens.Entitiy;

namespace Gardens.Data.Repositories
{
    // loosely coupled
    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

        Task<IList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);


    }
}
