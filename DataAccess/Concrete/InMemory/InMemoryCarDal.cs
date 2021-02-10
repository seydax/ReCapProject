using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{ Id=1, BrandId=2, ColorId=12, ModelYear=2000, DailyPrice=250, Description="sıfır"},
            new Car{ Id=2, BrandId=2, ColorId=15, ModelYear=2010, DailyPrice=250, Description="takla"},
            new Car{ Id=3, BrandId=1, ColorId=10, ModelYear=2015, DailyPrice=250, Description="motor"},
            new Car{ Id=4, BrandId=1, ColorId=22, ModelYear=1995, DailyPrice=250, Description="aynalar"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==c.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.Id = 3;
            carToUpdate.ColorId = 112;
            carToUpdate.BrandId = 321;
            carToUpdate.ModelYear = 2004;
            carToUpdate.DailyPrice = 215;
            carToUpdate.Description = "eklendi.";
        }

    }
}
