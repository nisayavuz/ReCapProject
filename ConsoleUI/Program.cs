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
            //CarManager carManager = new CarManager( new InMemoryCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.DailyPrice);
            //}
            Car newCar = new Car
            {
                DailyPrice = 100,
                BrandId = 3,
                CarName = "Audi",
                ColorId = 4,
                Description = "Audi description",
                ModelYear = 2000,
            };
            CarManager carManager = new CarManager( new EfCarDal());

            carManager.Add(newCar);

            //foreach (var car in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine(car.Description);
            //}
        }
    }
}