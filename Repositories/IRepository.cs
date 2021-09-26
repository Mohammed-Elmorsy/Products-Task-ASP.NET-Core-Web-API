using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsTaskWebAPI_MohammedElmorsy.Repositories
{
    interface IRepository<TEntity>
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Add(TEntity Entity);
        bool Remove(int id);
        TEntity Update(TEntity Entity);
    }
}
