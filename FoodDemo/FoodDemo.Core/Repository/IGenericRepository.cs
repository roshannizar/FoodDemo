using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDemo.Core.Repository
{
    public interface IGenericRepository<T> where T: class
    {
        void Create(T t);
        int Commit();
        T Delete(int id);
        IEnumerable<T> Get();
        T GetById(int id);
        T GetByName(string name);
    }
}
