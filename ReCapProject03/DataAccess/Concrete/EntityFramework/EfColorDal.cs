using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal:IColorDal
    {
        public Color GetBy(Expression<Func<Color, bool>> filter)
        {
            using (CarGalContext context = new CarGalContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public void Add(Color color)
        {
            using (CarGalContext context = new CarGalContext())
            {
                var addedEntity = context.Entry(color);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Color color)
        {
            using (CarGalContext context = new CarGalContext())
            {
                var updatedEntity = context.Entry(color);
                updatedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color color)
        {
            using (CarGalContext context = new CarGalContext())
            {
                var deletedEntity = context.Entry(color);
                deletedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarGalContext context = new CarGalContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }
    }
}