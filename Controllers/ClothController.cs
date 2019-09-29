using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourStore.Data.interfaces;
using YourStore.Data.Models;
using YourStore.ViewModels;

namespace YourStore.Controllers
{
    public class ClothController : Controller
    {

        private readonly IClothRepository _clothRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ClothController(IClothRepository clothRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _clothRepository = clothRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Clothes> clothes;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                clothes = _clothRepository.Clothes.OrderBy(n => n.ClothesId);
                currentCategory = "All clothes";
            }
            else
            {
                if (string.Equals("Men", _category, StringComparison.OrdinalIgnoreCase))
                {
                    clothes = _clothRepository.Clothes.Where(p => p.Category.CategoryName.Equals("Men")).OrderBy(p => p.Name);
                }
                else
                    clothes = _clothRepository.Clothes.Where(p => p.Category.CategoryName.Equals("Women")).OrderBy(p => p.Name);

                currentCategory = _category;
            }
            return View(new ClothListViewModel
            {
                Clothes = clothes,
                CurrentCategory = currentCategory
            });
        }
        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Clothes> drinks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                drinks = _clothRepository.Clothes.OrderBy(p => p.ClothesId);
            }
            else
            {
                drinks = _clothRepository.Clothes.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Cloth/List.cshtml", new ClothListViewModel { Clothes = drinks, CurrentCategory = "All clothes" });
        }

        public ViewResult Details(int clothId)
        {
            var cloth = _clothRepository.Clothes.FirstOrDefault(d => d.ClothesId == clothId);
            if (cloth == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(cloth);
        }
    }
}



 