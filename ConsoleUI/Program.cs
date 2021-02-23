using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }

            //carManager.Add(new Car { Id = 6, BrandId = 7, ColorId = 8, ModelYear = 2001, DailyPrice = 250, Description = "1. El Araba", CarName = "Opel" });
            //carManager.Update(new Car { Id = 7, BrandId = 7, ColorId = 7 });
            //carManager.Delete(new Car { Id = 7 });

            foreach (var car in carManager.GetCarsByBrandId(5))
            {
                Console.WriteLine(car.CarName);
            }

            foreach (var car in carManager.GetCarsByColorId(5))
            {
                Console.WriteLine(car.CarName);
            }


            foreach (var car in carManager.GetProductDetails())
            {
                Console.WriteLine(car.CarName + "/" + car.CName + "/" + car.BName);
            }

            Console.ReadKey();
           
        }
        
    }
}
