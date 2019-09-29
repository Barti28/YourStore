using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourStore.Data.interfaces;
using YourStore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YourStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClothRepository _clothRepository;
        public HomeController(IClothRepository clothRepository)
        {
            _clothRepository = clothRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredClothes = _clothRepository.PreferredClothes
            };

            return View(homeViewModel);
        }
    }
}
