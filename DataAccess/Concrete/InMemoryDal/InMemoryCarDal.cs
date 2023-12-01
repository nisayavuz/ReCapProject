using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id= 1, ModelYear = 2019, BrandId = 1 , ColorId = 1, DailyPrice = 20000, Description = "Black Car"},
                new Car {Id= 2, ModelYear = 2023, BrandId = 2 , ColorId = 1, DailyPrice = 50000, Description = "Black Car"},
                new Car {Id= 3, ModelYear = 2022, BrandId = 2 , ColorId = 3, DailyPrice = 90000, Description = "Red Car"},
                new Car {Id= 4, ModelYear = 2021, BrandId = 1 , ColorId = 4, DailyPrice = 70000, Description = "Green Car"}
            };  
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return GetAll(c => c.ColorId == 2);
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.SingleOrDefault(c => c.Id == car.Id);

            car.Id = updatedCar.Id;
            car.BrandId = updatedCar.BrandId;
            car.ColorId = updatedCar.ColorId;
            car.DailyPrice = updatedCar.DailyPrice;
            car.Description = updatedCar.Description;
        }
    }
}
