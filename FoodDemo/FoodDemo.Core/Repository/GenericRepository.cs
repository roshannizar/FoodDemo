using FoodDemo.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDemo.Core.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        private readonly FoodDbContext db;

        public GenericRepository(FoodDbContext db)
        {
            this.db = db;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public void Create(T t)
        {
            db.Set<T>().Add(t);
        }

        public T Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            return db.Set<T>();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public T GetByName(string name)
        {
            return db.Set<T>().Find(name);
        }
    }
}
