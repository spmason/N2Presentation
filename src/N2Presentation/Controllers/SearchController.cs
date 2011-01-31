using System;
using System.Web.Mvc;
using N2;
using N2Presentation.Models.Pages;
using N2Presentation.Models;
using N2.Web;
using N2.Web.Mvc;

namespace N2Presentation.Controllers
{
	[Controls(typeof(SearchBase))]
	public class SearchController : ContentController<SearchBase>
	{
		private const int PAGE_SIZE = 10;

		[NonAction]
		public override ActionResult Index()
		{
			return Index(null, null);
		}

		public ActionResult Index(string q, int? p)
		{
			if (String.IsNullOrEmpty(q))
				return View(new SearchModel(new ContentItem[0]));

			int totalRecords;
			var hits = CurrentItem.Search(q, p ?? 0, PAGE_SIZE, out totalRecords);

			return View(new SearchModel(hits) { SearchTerm = q, TotalResults = totalRecords, PageSize = PAGE_SIZE, PageNumber = p ?? 0 });
		}
	}
}