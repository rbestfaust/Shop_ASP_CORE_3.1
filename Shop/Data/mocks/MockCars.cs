using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars

    {
        

        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car> {
                    new Car {
                        name = "Tesla" ,
                        shortDesc = "For men",
                        longDesc = "",
                        img = "/img/tesla.jpg",
                        price = 35000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First() } ,
                    new Car {
                        name = "Opel" ,
                        shortDesc = "For Women",
                        longDesc = "",
                        img = "/img/opel.jpg",
                        price = 20000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last() }
                };
                
            }
        }
        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }

        
    }
}
