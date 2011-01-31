using System.Collections.Generic;
using System.Linq;
using N2.Collections;
using N2.Integrity;
using N2.Web.Mvc;
using N2.Definitions;

namespace N2Presentation.Models.Pages
{
	[N2.PageDefinition("News Container",
		Description = "A list of news. News items can be added to this page.",
		SortOrder = 150,
		IconUrl = "~/Content/Img/newspaper_link.png")]
	[RestrictParents(typeof(IStructuralPage))]
	[SortChildren(SortBy.PublishedDescending)]
	public class NewsContainer : ContentPageBase
	{
		public IList<News> NewsItems
		{
			get { return GetChildren(new TypeFilter(typeof(News))).OfType<News>().ToList(); }
		}
	}
}