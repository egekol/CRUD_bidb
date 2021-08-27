using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace CosnoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Description+"\n");
            }

            Console.WriteLine("----------------------------------");
            carManager.Add(new Car
            {
                Id = 4,
                BrandId = 2,
                ColorId = -1,
                ModelYear = 2020,
                DailyPrice = 230000,
                Description = "White Renault, 2020 Model"
            });

             carManager.Update(new Car
             {
                 Id = 1,
                 BrandId = 3,
                 ColorId = -1,
                 ModelYear = 2021,
                 DailyPrice = 320000,
                 Description = "White Ford, 2021 Model"
             });

             Console.WriteLine("---------------------------------");
             foreach (var cars in carManager.GetAll())
             {
                 Console.WriteLine(cars.Description + "\n");
             }

             Console.WriteLine("-----------------------------------");

             foreach (var car in carManager.GetByBrandId(2))
             {
                 Console.WriteLine(car.Description+" : " + car.BrandId+"\n");
             }
        }
    }
}
