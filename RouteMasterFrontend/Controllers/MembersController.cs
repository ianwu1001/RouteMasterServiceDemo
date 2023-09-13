using Microsoft.AspNetCore.Mvc;

namespace RouteMasterFrontend.Controllers
{
    public class MembersController : Controller
    {
   
        public IActionResult MemberArea()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult MembersNavbar([FromBody] Page dto)
        {
            var page = dto.pagecase;
            return ViewComponent("MemberArea", page);
        }

        public class Page
        {
            public int pagecase { get; set; } 
        }
    }
}
