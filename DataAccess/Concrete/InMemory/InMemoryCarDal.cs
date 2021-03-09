using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=2,ModelYear="2020",DailyPrice=250,Description="Toyota Yaris"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear="2019",DailyPrice=200,Description="Hyundai Accent"},
                new Car{Id=3,BrandId=2,ColorId=1,ModelYear="2018",DailyPrice=175,Description="Renault Clio"},
                new Car{Id=4,BrandId=3,ColorId=3,ModelYear="2021",DailyPrice=350,Description="Ford Focus"},
                new Car{Id=5,BrandId=4,ColorId=4,ModelYear="2020",DailyPrice=400,Description="Volkswagen Caddy"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.Description + " " + "is added.");
        }

        public void Delete(Car car)
        {
            Car deleteToCar;
            deleteToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deleteToCar);
            Console.WriteLine(car.Description + " " + "is deleted.");
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetById(Car car)
        {
            Car getId;
            getId = _cars.SingleOrDefault(c => c.Id == car.Id);
            Console.WriteLine(getId.Description);
        }

        public void Update(Car car)
        {
            Car updateCar;
            updateCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updateCar.ModelYear = car.ModelYear;
            updateCar.DailyPrice = car.DailyPrice;
            updateCar.ColorId = car.ColorId;
            updateCar.BrandId = car.BrandId;
            updateCar.Id = car.Id;
            updateCar.Description = car.Description;
            Console.WriteLine(car.Description + " " + "is new car.");
        }
    }
}
