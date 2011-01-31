using N2Presentation.Models.Pages;
using N2Presentation.Services;
using N2.Web;
using N2.Web.Mvc;
using System.Web.Mvc;

namespace N2Presentation.Controllers
{
	[Controls(typeof(RssFeed))]
	public class RssFeedController : ContentController<RssFeed>
	{
		public override ActionResult Index()
		{
			Response.ContentType = "text/xml";
			Engine.Resolve<RssWriter>().Write(Response.Output, CurrentItem);
			Response.End();

			return Content("");
		}

		public ActionResult Preview()
		{

			return View(CurrentItem);
		}
	}
}