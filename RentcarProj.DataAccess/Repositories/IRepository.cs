using System.Linq.Expressions;

namespace RentcarProj.DataAccess.Repositories;

public interface IRepository<T>
{
    /// <summary>
    /// Получить запись
    /// </summary>
    /// <param name="id">Идентификатор записи</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Запись, если существует, иначе - null</returns>
    public Task<T?> Get(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Добавить запись
    /// </summary>
    /// <param name="entity">Объект сущности базы данных</param>
    /// <param name="cancellationToken"></param>
    public Task Add(T entity, CancellationToken cancellationToken);

    /// <summary>
    /// Удалить запись
    /// </summary>
    /// <param name="id">идентификатор записи</param>
    /// <param name="cancellationToken"></param>
    public Task Remove(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Обновить запись
    /// </summary>
    /// <param name="entity">Обновлённая запись</param>
    /// <param name="cancellationToken"></param>
    public Task Update(T entity, CancellationToken cancellationToken);

    /// <summary>
    /// Получить список неотслеживаемых записей по условию
    /// </summary>
    /// <param name="predicate">Условие выборки</param>
    /// <returns><see cref="Queryable"/> с текущими элементами, подходящими под условие</returns>
    public Task<IQueryable<T>> GetAllAsNoTracking(Expression<Func<T?, bool>>? predicate = null);
}