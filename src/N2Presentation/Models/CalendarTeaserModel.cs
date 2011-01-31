using System.Collections.Generic;
using N2;
using N2Presentation.Models.Parts;
using N2Presentation.Models.Pages;
using N2.Web.Mvc;
using N2.Web.UI;

namespace N2Presentation.Models
{
	public class CalendarTeaserModel : IItemContainer<CalendarTeaser>
	{
		public CalendarTeaserModel(CalendarTeaser currentItem, ICollection<Event> results)
		{
			CurrentItem = currentItem;
			Events = results;
		}

		/// <summary>Gets the item associated with the item container.</summary>
		ContentItem IItemContainer.CurrentItem
		{
			get { return CurrentItem; }
		}

		public CalendarTeaser CurrentItem { get; private set; }
		public ICollection<Event> Events { get; private set; }
	}
}