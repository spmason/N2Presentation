using N2Presentation.Models.Parts;
using N2Presentation.Models;
using N2.Web;
using N2.Web.Mvc;

namespace N2Presentation.Controllers
{
	[Controls(typeof(Tracking))]
	public class TrackingController : ContentController<Tracking>
	{
		public override System.Web.Mvc.ActionResult Index()
		{
			bool showTracking = CurrentItem.Enabled
				&& !string.IsNullOrEmpty(CurrentItem.UACCT)
				&& (CurrentItem.TrackEditors || !Engine.SecurityManager.IsEditor(User));

			if (showTracking)
				return View(CurrentItem);
			else
				return Content("");
		}
	}
}