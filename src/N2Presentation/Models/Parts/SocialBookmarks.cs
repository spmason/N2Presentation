using N2;
using N2.Details;
using N2.Integrity;
using N2Presentation.Models.Pages;
using N2.Web.UI.WebControls;

namespace N2Presentation.Models.Parts
{
	[N2.PartDefinition("Social bookmarks",
		IconUrl = "~/Content/Img/digg.png")]
	[RestrictParents(typeof(ContentPageBase))]
	[WithEditableTitle("Title", 90)]
	public class SocialBookmarks : PartBase
	{
		[DisplayableHeading(4)]
		public override string Title
		{
			get { return base.Title; }
			set { base.Title = value; }
		}

		[EditableCheckBox("Show text", 100)]
		public virtual bool ShowText
		{
			get { return (bool)(GetDetail("ShowText") ?? true); }
			set { SetDetail("ShowText", value, true); }
		}
	}
}