using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourStore.Data.interfaces;
using YourStore.Data.Models;
using YourStore.ViewModels;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YourStore.Controllers
{
    public class ShoppingCartController : Controller
    {


        private readonly IClothRepository _clothRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IClothRepository clothRepository, ShoppingCart shoppingCart)
        {
            _clothRepository = clothRepository;
            _shoppingCart = shoppingCart;
        }

        [Authorize]
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        [Authorize]
        public RedirectToActionResult AddToShoppingCart(int clothid)
        {
            var selectedCloth = _clothRepository.Clothes.FirstOrDefault(p => p.ClothesId == clothid);
            if (selectedCloth != null)
            {
                _shoppingCart.AddToCart(selectedCloth, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int clothId)
        {
            var selectedCloth = _clothRepository.Clothes.FirstOrDefault(p => p.ClothesId == clothId);
            if (selectedCloth != null)
            {
                _shoppingCart.RemoveFromCart(selectedCloth);
            }
            return RedirectToAction("Index");
        }

    }
 }
