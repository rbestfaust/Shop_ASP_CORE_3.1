using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;


        public IEnumerable<Car> Cars => throw new NotImplementedException();

        public IEnumerable<Car> getFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
