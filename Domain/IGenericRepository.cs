using System.Threading.Tasks;
using System.Collections.Generic;

namespace Domain
{
    public interface IGenericRepository<T> where T : class
    {
         Task<T> Get(int id);
         Task<IEnumerable<T>> GetAll();
         Task Add(T entity);
         void Delete(T entity);
         void Update(T entity);
         
    }
}