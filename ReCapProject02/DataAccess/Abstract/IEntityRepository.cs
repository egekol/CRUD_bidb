
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        T GetBy(Expression<Func<T, bool>> filter);
        void Add(T car);
        void Update(T car);
        void Delete(T car);
        List<T> GetAllCars(Expression<Func<T,bool>>filter =null);
        //List<T> GetByBrandIdCars(int brandId);
    }
}