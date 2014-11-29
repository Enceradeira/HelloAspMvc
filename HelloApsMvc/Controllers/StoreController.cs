using System;
using System.Web;
using System.Web.Mvc;

using HelloApsMvc.Models.Store;

namespace HelloApsMvc.Controllers
{
	public class StoreController : Controller
	{
		// GET: Store

		public string Browse(string genre)
		{
			var msg = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
			return msg;
		}

		public string Details(int id)
		{
			return "Hello from Store.Details ID = " + id;
		}

		public ActionResult Index()
		{
			var albums = new[]
			{
				new Album { Title = "Timeless" },
				new Album { Title = "Somthing gonna give" }
			};
			ViewBag.Model = albums;
			return View(albums);
		}
	}
}