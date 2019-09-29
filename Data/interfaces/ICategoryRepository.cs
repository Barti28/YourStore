using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourStore.Data.Models;

namespace YourStore.Data.interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category>Categories {get;}
    }
}
