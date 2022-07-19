using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoList.MODEL.Entities;

namespace ToDoList.BLL.RepositoryPattern.Interfaces
{
    public interface IRepository<T> where T: BaseEntity
    {
        List<T> GetByActives();
        T GetById(int id);

        void Delete(int id);
        void Update(T item);
        void Add(T item);

        List<T> GetByFilter(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
    }
}
