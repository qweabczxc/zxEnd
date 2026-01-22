using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstraction
{
    public interface IBaseRepository<T>
    {
        T? GetById(int id);
        List<T> GetAll();
        T? Add(T entity);
        T? Update(T entity);
        void Delete(int id);
    }
}
