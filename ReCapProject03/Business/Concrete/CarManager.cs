using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private ICarDal _carDal;
        //private Brand _brandDal;

        public CarManager(ICarDal carDal)
        {
            this._carDal = carDal;
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("List of all cars: ");
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            if (car.Description.Length >2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("New car added: {0}\n",car.Description);
            }
            else
            {
                Console.WriteLine("Car could not added to the database: fill the information correctly.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car has been deleted.\n");
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Car '{0}' updated.\n",car.Id);
        }


        public List<Car> GetByBrandId(int brandId)
        {
            Console.WriteLine("List of cars filtered with {0} Id: ", brandId);
            //return _carDal.GetByBrandIdCars(brandId);
            return _carDal.GetAll(c => c.BrandId == brandId);
            
        }

        public List<Car> GetByUnityPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            Console.WriteLine("List of cars filtered with '{0}' color Id: ",colorId);
            return _carDal.GetAll(c => c.ColorId == colorId);
        }
    }
}
