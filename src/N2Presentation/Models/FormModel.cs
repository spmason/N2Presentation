using System;
using System.Collections.Generic;
using N2;
using N2Presentation.Details;
using N2Presentation.Models.Parts;
using N2.Web.Mvc;
using N2.Web.UI;

namespace N2Presentation.Models
{
	public class FormModel : IItemContainer<Form>
	{
		public FormModel(Form currentItem, IEnumerable<IQuestion> elements)
		{
			CurrentItem = currentItem;
			Elements = elements;
		}

		/// <summary>Gets the item associated with the item container.</summary>
		ContentItem IItemContainer.CurrentItem
		{
			get { return CurrentItem; }
		}

		public Form CurrentItem { get; private set; }

		public IEnumerable<IQuestion> Elements { get; private set; }

		public bool FormSubmitted { get; set; }
	}
}