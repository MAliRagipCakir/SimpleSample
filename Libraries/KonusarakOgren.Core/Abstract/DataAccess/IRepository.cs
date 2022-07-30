using KonusarakOgren.Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Core.Abstract.DataAccess
{
    public interface IRepository<T,Key> where T : class, IBaseEntity
    {
        Task<bool> Add(T entity);
        Task<bool> Any(Expression<Func<T, bool>> expression);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAll();
        Task<List<T>> GetAll(Expression<Func<T, bool>> expression);
        Task<T> Get(Expression<Func<T, bool>> expression);
        Task<T> GetById(Key id);
        Task<int> Save();
    }
}
