using N2.Integrity;
using N2.Web.Mvc;
using N2.Definitions;

namespace N2Presentation.Models.Pages
{
	[N2.PageDefinition("Site Map",
		Description = "Displays all pages",
		SortOrder = 420,
		IconUrl = "~/Content/Img/sitemap.png")]
	[RestrictParents(typeof(IStructuralPage))]
	public class SiteMap : ContentPageBase, IStructuralPage
	{
	}
}