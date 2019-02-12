using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private IRestaurantData _restaurantData;

        [BindProperty]
        public Restaurant CurrentRestaurant { get; set; }

        public EditModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult OnGet(int id)
        {
            CurrentRestaurant = _restaurantData.Get(id);
            if (CurrentRestaurant == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _restaurantData.Update(CurrentRestaurant);
                return RedirectToAction("Details", "Home", new { id = CurrentRestaurant.Id });
            }
            return Page();
        }
    }
}