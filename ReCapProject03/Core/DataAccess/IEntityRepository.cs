using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class , IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        void Add(T product);
        void Update(T product);
        void Delete(T product);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}