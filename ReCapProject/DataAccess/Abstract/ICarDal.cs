using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        void Add(Car car);

        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAllCars();
        List<Car> GetByBrandIdCars(int brandId);
    }
}
