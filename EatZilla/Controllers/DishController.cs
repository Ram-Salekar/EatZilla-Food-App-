using EatZilla.Models.CoreClasses;
using EatZilla.Models.DataConnection;
using Microsoft.AspNetCore.Mvc;

namespace EatZilla.Controllers
{
    public class DishController : Controller


    {
        private readonly ApplicationDatabaseContext data;

        public DishController(ApplicationDatabaseContext db) {
        
        data = db;
        }


        public IActionResult Index()
        {
            List<Dish> dish = data.dishes.ToList();
            return View(dish);
        }
    }
}
