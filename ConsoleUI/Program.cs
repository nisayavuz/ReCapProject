using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryDal;
using Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddNewCar();
            //GetCarsByBrandId();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var cars in carManager.GetCarDetails())
            {
                Console.WriteLine( cars.CarName + " - " + cars.BrandName);
            }

        }

        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void AddNewCar()
        {
            Car newCar = new Car
            {
                DailyPrice = 100,
                BrandId = 3,
                CarName = "Audi",
                ColorId = 4,
                Description = "Audi description",
                ModelYear = 2000,
            };
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(newCar);
        }
    }
}