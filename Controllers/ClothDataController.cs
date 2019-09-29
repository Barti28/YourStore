using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourStore.Data.interfaces;
using YourStore.Data.Models;
using YourStore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YourStore.Controllers
{
    [Route("api/[controller]")]
    public class ClothDataController : Controller
    {
        private readonly IClothRepository _clothRepository;

        public ClothDataController(IClothRepository clothRepository)
        {
            _clothRepository = clothRepository;
        }

        [HttpGet]
        public IEnumerable<ClothViewModel> LoadMoreDrinks()
        {
            IEnumerable<Clothes> dbClothes = null;

            dbClothes = _clothRepository.Clothes.OrderBy(p => p.ClothesId).Take(10);

            List<ClothViewModel> clothes = new List<ClothViewModel>();

            foreach (var dbCloth in dbClothes)
            {
                clothes.Add(MapDbClothToClothViewModel(dbCloth));
            }
            return clothes;
        }

        private ClothViewModel MapDbClothToClothViewModel(Clothes dbCloth) => new ClothViewModel()
        {
            ClothId = dbCloth.ClothesId,
            Name = dbCloth.Name,
            Price = dbCloth.Price,
            ShortDescription = dbCloth.ShortDescription,
            ImageThumbnailUrl = dbCloth.ImageThumbnailUrl
        };

    }
}
