using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TS.WebApp.Models;

namespace TS.WebApp.Data
{
    public class CarStore
    {
        public TSContext Context { get; set; }
        public CarStore(TSContext context)
        {
            Context = context;
        }

        internal void EditCar(Car car)
        {
            Car currentComputer = GetCarById(car.Id);
            currentComputer.Brand = car.Brand;
            currentComputer.Model = car.Model;
            currentComputer.Year = car.Year;
            currentComputer.CustomerId = car.CustomerId;

            Context.Car.Update(currentComputer);
            Context.SaveChanges();
        }
        internal Car GetCarById(Guid id)
        {
            return Context.Car.FirstOrDefault(x => x.Id == id);
        }
        internal void AddCar(Car car)
        {
            Context.Car.Add(car);
            Context.SaveChanges();
        }
        internal void DeleteCar(Guid id)
        {
            var car = Context.Car.FirstOrDefault(x => x.Id == id);
            Context.Car.Remove(car);
            Context.SaveChanges();
        }

        

        internal List<Car> GetCars()
        {
            return Context.Car.ToList();
        }

        
    }
}
