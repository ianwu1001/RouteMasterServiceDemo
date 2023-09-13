using Microsoft.AspNetCore.Mvc;
using RouteMasterFrontend.Models;

namespace RouteMasterFrontend.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly RouteMasterContext _context;


        public ActivitiesController(RouteMasterContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.ActivityId = id;
            return View();
        }
    }
}
