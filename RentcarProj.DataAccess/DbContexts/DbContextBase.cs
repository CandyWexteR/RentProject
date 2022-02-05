using Microsoft.EntityFrameworkCore;

namespace RentcarProj.DataAccess.DbContexts;

public class DbContextBase<T>:DbContext where T:class
{
    public DbContextBase(DbContextOptions options):base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<T> Table { get; }
}