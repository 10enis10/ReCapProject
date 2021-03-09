using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Id = 1, BrandId = 5, ColorId = 3, DailyPrice = 320, ModelYear = "2018", Description = "Ford Fiesta" };
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            //inMemoryCarDal.Add(car);
            //inMemoryCarDal.Delete(car);
            inMemoryCarDal.Update(car);
            inMemoryCarDal.GetById(car);
        }
    }
}
