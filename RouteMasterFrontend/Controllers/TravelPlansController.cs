using Microsoft.AspNetCore.Mvc;
using RouteMasterFrontend.Models;
using Microsoft.EntityFrameworkCore;


namespace RouteMasterFrontend.Controllers
{
    public class TravelPlansController : Controller
    {
       private readonly RouteMasterContext _context;
        public TravelPlansController(RouteMasterContext context)
        {
            _context = context;             
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult PackageTourList()
        {
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {

            ViewBag.PackageTourId = id;
            return View();
        }
    }
}
