using N2.Collections;
using N2Presentation.Models.Pages;
using N2Presentation.Models;
using N2.Web;
using N2.Web.Mvc;

namespace N2Presentation.Controllers
{
	[Controls(typeof(ImageGallery))]
	public class ImageGalleryController : ContentController<ImageGallery>
	{
		public override System.Web.Mvc.ActionResult Index()
		{
			var galleryItems = CurrentItem.GetChildren(new AccessFilter(), new TypeFilter(typeof(GalleryItem)))
				.Cast<GalleryItem>();

			return View(new ImageGalleryModel(CurrentItem, galleryItems));
		}
	}
}