using System;
using System.Collections.Generic;
using N2;

namespace N2Presentation.Models
{
	public class SubMenuModel
	{
		public SubMenuModel()
		{
			Visible = true;
			Items = new List<ContentItem>();
		}

		public string Text { get; set; }

		public bool Visible { get; set; }

		public IEnumerable<ContentItem> Items { get; set; }

		public ContentItem CurrentItem { get; set; }

		public ContentItem BranchRoot { get; set; }
	}
}