using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ItemsController : Controller
    {
        public readonly MyAppContext _context;
        public ItemsController(MyAppContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var item = await _context.Items.ToListAsync();
            return View();
        }
        public IActionResult Edit (int itemId)
        {
            return Content("id = " + itemId);
        }
    }
}
