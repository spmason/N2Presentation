using System.Web.Mvc;
using N2Presentation.Models.Parts;
using N2Presentation.Models;
using N2.Web;

namespace N2Presentation.Controllers
{
	[Controls(typeof(SocialBookmarks))]
	public class SocialBookmarksController : TemplatesControllerBase<SocialBookmarks>
	{
		public override ActionResult Index()
		{
			return PartialView(new SocialBookmarksModel(CurrentItem));
		}
	}
}