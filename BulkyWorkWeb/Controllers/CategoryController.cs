using BulkyWorkWeb.Data;
using BulkyWorkWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWorkWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly WorkDbContext _db;

        public CategoryController(WorkDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
