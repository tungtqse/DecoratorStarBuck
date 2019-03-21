using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarbuck.DataAccess.Repository
{
    public interface IEntityRepository<T>
      where T : class
    {
        void CommitChanges();
        void DeleteOnCommit(T entity);
        T Get(int key);
        IQueryable<T> GetAll();
        T InsertOnCommit(T entity);
        T Get(string key);
        T Reload(T entity);
    }
}
