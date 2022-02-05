using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RentcarProj.DataAccess.DbContexts;

namespace RentcarProj.DataAccess.Repositories;

public class Repository<T>:IRepository<T> where T:class
{
    private DbContextBase<T?> _context;
    public Repository(DbContextBase<T?> context)
    {
        _context = context;
    }

    public async Task<T?> Get(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Table.FindAsync(id);
    }

    public async Task Add(T entity, CancellationToken cancellationToken)
    {
        await _context.AddAsync(entity, cancellationToken);
    }

    public async Task Remove(Guid id, CancellationToken cancellationToken)
    {
        var item = await _context.Table.FindAsync(id, cancellationToken);
        if (item is not null && !cancellationToken.IsCancellationRequested)
            _context.Remove(item);
    }

    public async Task Update(T entity, CancellationToken cancellationToken)
    {
        if (!cancellationToken.IsCancellationRequested)
            _context.Table.Update(entity);
    }

    public async Task<IQueryable<T>> GetAllAsNoTracking(Expression<Func<T?, bool>> predicate)
    {
        return _context.Table.Where(predicate).AsNoTracking();
    }
}