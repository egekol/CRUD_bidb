using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,CarGalContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (CarGalContext context = new CarGalContext())
            {
                var result = from c in context.Cars
                    join color  in context.Colors on c.ColorId equals color.ColorId
                    join b in context.Brands on c.BrandId equals b.BrandId
                    
                    select new CarDetailDto()
                    {
                        Description = c.Description,
                        BrandName = b.BrandName,
                        DailyPrice = c.DailyPrice,
                        ColorName = color.ColorName
                    };
                return result.ToList();
            }
        }
    }
}