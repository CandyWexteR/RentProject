using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RentcarProj.DataAccess.DbContexts;

namespace RentcarProj.DataAccess.Repositories;

public class Repository<T>:IRepository<T> where T:class
{
    private DbContextBase<T> _context;
    public Repository(DbContextBase<T> context)
    {
        _context = context;
    }
    
    /// <inheritdoc/>
    public async Task<T?> Get(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Table.FindAsync(id);
    }

    /// <inheritdoc/>
    public async Task Add(T entity, CancellationToken cancellationToken)
    {
        await _context.AddAsync(entity, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task Remove(Guid id, CancellationToken cancellationToken)
    {
        var item = await _context.Table.FindAsync(id, cancellationToken);
        if (item is not null && !cancellationToken.IsCancellationRequested)
            _context.Remove(item);
    }

    /// <inheritdoc/>
    public async Task Update(T entity, CancellationToken cancellationToken)
    {
        if (!cancellationToken.IsCancellationRequested)
            _context.Table.Update(entity);
    }

    /// <inheritdoc/>
    public async Task<IQueryable<T>> GetAllAsNoTracking(Expression<Func<T?, bool>>? predicate)
    {
        return predicate is not null ? _context.Table.Where(predicate).AsNoTracking() : _context.Table.AsNoTracking();
    }
}