using Microsoft.AspNetCore.Mvc;
using RouteMasterFrontend.Models;
using System.Security.Claims;

namespace RouteMasterFrontend.Views.Shared.Components.MemberArea
{
	public class MemberAreaViewComponent:ViewComponent
	{
		private readonly RouteMasterContext _context;
		public MemberAreaViewComponent(RouteMasterContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke(int pagecase = 5)
		{



			switch (pagecase)
			{
				case 0:
					return View("MemEdit");
				case 1:
					return View("MemOrder");
				case 2:
					return View("EditPassword");
				case 3:
					return View("_MessageNonVue");
				case 4:
					return View("_FavoriteAtt");
				case 5:
					return View("_SchduleTable");

			}

			return View("EditPassword");
		}

	}
}
