using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    BrandId = 1,
                    ColorId = 16777215,
                    ModelYear = 2004,
                    DailyPrice = 200000,
                    Description = "Black Opel Corsa, 2004 Model"
                },
                new Car
                {
                    Id = 2,
                    BrandId = 1,
                    ColorId = 16777215,
                    ModelYear = 2011,
                    DailyPrice = 350000,
                    Description = "Black Opel Corsa, 2011 Model"
                },
                new Car
                {
                    Id = 3,
                    BrandId = 2,
                    ColorId = 8087790,
                    ModelYear = 2004,
                    DailyPrice = 150000,
                    Description = "Soft Slate Blue Renault, 2004 Model"
                },

            };
        }

        public Car GetBy(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {

            _cars.Add(car);
        }

        public void Update(Car car)
        {

            Car toUpdateCar = _cars.SingleOrDefault(p => p.Id == car.Id);
            toUpdateCar.Id = car.Id;
            toUpdateCar.BrandId = car.BrandId;
            toUpdateCar.ColorId = car.ColorId;
            toUpdateCar.DailyPrice = car.DailyPrice;
            toUpdateCar.ModelYear = car.ModelYear;
            toUpdateCar.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car toDeleteCar = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(toDeleteCar);
        }

        public List<Car> GetAllCars(Expression<Func<Car, bool>> filter = null)
        {
            //DOLDUR!!!!!!!!!!!!!!!
            return _cars;
        }

        /*public List<Car> GetAllCars()
        {
            return _cars;
        }

        public List<Car> GetByBrandIdCars(int brandId)
        {

            return _cars.Where(p => p.BrandId == brandId).ToList();
        }*/
    }
}
