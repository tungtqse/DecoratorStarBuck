using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DecoratorStarbuck.DataAccess.Repository
{
    public interface IDbRepository : IDisposable
    {
        int SaveChanges();
        DbSet<T> Set<T>() where T : class;
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
    }
}
