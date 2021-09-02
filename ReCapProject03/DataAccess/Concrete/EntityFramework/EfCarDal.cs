using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:ICarDal
    {
        public Car GetBy(Expression<Func<Car, bool>> filter)
        {
            using (CarGalContext context = new CarGalContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public void Add(Car car)
        {
            using (CarGalContext context = new CarGalContext())
            {
                var addedEntity = context.Entry(car);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Car car)
        {
            using (CarGalContext context = new CarGalContext())
            {
                var updatedEntity = context.Entry(car);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Car car)
        {
            using (CarGalContext context = new CarGalContext())
            {
                var deletedEntity = context.Entry(car);
                deletedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarGalContext context = new CarGalContext())
            {
                return filter == null ? context.Cars.ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }
    }
}