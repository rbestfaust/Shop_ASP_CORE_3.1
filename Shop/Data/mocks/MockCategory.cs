using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    
                    new Category {categoryName = "ElectroCars", desc = "Super new cars"  },
                    new Category {categoryName = "ClassicCars", desc = "Simple classic  new cars"}
                };
            }
        }
    }
}
