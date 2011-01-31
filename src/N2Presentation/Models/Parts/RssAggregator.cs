using N2;
using N2.Details;
using N2.Integrity;
using System.Web.UI.WebControls;

namespace N2Presentation.Models.Parts
{
	[N2.PartDefinition("Rss List",
		Name = "RssAggregatorItem",
		Description = "A list of news items retrieved from an rss source.",
		SortOrder = 165,
		IconUrl = "~/Content/Img/rss.png")]
	[WithEditableTitle("Title", 10, Required = false)]
	public class RssAggregator : PartBase
	{
		[EditableFreeTextArea("Text", 100)]
		public virtual string Text
		{
			get { return (string)(GetDetail("Text") ?? string.Empty); }
			set { SetDetail("Text", value, string.Empty); }
		}

		[EditableTextBox("Rss Urls", 120, Rows = 3, TextMode = TextBoxMode.MultiLine)]
		public virtual string RssUrls
		{
			get { return GetDetail("RssUrls", GetDetail("RssUrl", "")); }
			set { SetDetail("RssUrls", value, string.Empty); }
		}

		[EditableTextBox("Max Count", 130)]
		public virtual int MaxCount
		{
			get { return (int)(GetDetail("MaxCount") ?? 5); }
			set { SetDetail("MaxCount", value, 5); }
		}
	}
}