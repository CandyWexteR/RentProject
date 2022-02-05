using System.Linq.Expressions;

namespace RentcarProj.DataAccess.Repositories;

public interface IRepository<T>
{
    public Task<T?> Get(Guid id, CancellationToken cancellationToken);
    public Task Add(T entity, CancellationToken cancellationToken);
    public Task Remove(Guid id, CancellationToken cancellationToken);
    public Task Update(T entity, CancellationToken cancellationToken);
    public Task<IQueryable<T>> GetAllAsNoTracking(Expression<Func<T?, bool>> predicate);
}