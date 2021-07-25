using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;


        public CarsController (IAllCars iCars , ICarsCategory iCategory)
        {
            _allCars = iCars;
            _allCategories = iCategory;
        }

        public ViewResult ListProducts()
        {
            ViewBag.Title = "Page with Cars";
            CarListViewModel obj = new CarListViewModel();
            obj.getAllCars = _allCars.Cars;
            obj.currCategory = "zzzzzz";
            
           
            return View(obj);
        }
    }
}
