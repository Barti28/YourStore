using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourStore.Data.Models;

namespace YourStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Clothes> PreferredClothes { get; set; }
    }
}
