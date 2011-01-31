using System;
using System.Collections.Generic;
using N2;

namespace N2Presentation.Models
{
	public class TopMenuModel
	{
		public TopMenuModel(IEnumerable<Translation> translations, ContentItem currentItem, IEnumerable<ContentItem> menuItems)
		{
			Translations = translations;
			CurrentItem = currentItem;
			MenuItems = menuItems;
		}

		public IEnumerable<Translation> Translations { get; private set; }

		public ContentItem CurrentItem { get; private set; }

		public IEnumerable<ContentItem> MenuItems { get; private set; }
	}
}