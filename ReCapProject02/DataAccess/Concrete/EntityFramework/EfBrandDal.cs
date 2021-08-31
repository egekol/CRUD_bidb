using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal:IBrandDal
    {

        public Brand GetBy(Expression<Func<Brand, bool>> filter)
        {
            using (CarGalContext context = new CarGalContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }        }

        public void Add(Brand brand)
        {
            using (CarGalContext context = new CarGalContext())
            {
                var addedEntity = context.Entry(brand);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }        }

        public void Update(Brand brand)
        {
            using (CarGalContext context = new CarGalContext())
            {
                var updatedEntity = context.Entry(brand);
                updatedEntity.State = EntityState.Added;
                context.SaveChanges();
            }        }

        public void Delete(Brand brand)
        {
            using (CarGalContext context = new CarGalContext())
            {
                var deletedEntity = context.Entry(brand);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (CarGalContext context = new CarGalContext())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }
    }
}