using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : IInMemoryDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Brandld="Bmw", Id=1, Colorld="Black", ModelYear=2000, DailyPrice=500000, Description="Birinci El"},
                new Car{Brandld="Audi", Id=2, Colorld="White", ModelYear=2005, DailyPrice=550000, Description="Birinci El"},
                new Car{Brandld="Renault", Id=3, Colorld="Blue", ModelYear=2010, DailyPrice=300000, Description="Birinci El"}
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByid(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Brandld = car.Brandld;
            carToUpdate.Colorld = car.Colorld;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
