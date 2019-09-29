using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourStore.Data.interfaces;
using YourStore.Data.Models;

namespace YourStore.Data.mocks
{
    
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "Men", Description = "All men clothes" },
                         new Category { CategoryName = "Women", Description = "All women clothes" }
                     };
            }
        }

      
    }
}