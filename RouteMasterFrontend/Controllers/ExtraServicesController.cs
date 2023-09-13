using Microsoft.AspNetCore.Mvc;
using RouteMasterFrontend.Models;

namespace RouteMasterFrontend.Controllers
{
    public class ExtraServicesController : Controller
    {
        private readonly RouteMasterContext _context;

        public ExtraServicesController(RouteMasterContext context)
        {
            _context = context;            
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Details(int? id)
        {

            ViewBag.ExtraServiceId = id;

            return View();
        }
    }
}
