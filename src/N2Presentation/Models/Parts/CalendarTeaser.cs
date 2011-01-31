using N2.Details;
using N2.Integrity;
using N2Presentation.Models.Pages;

namespace N2Presentation.Models.Parts
{
	[N2.PartDefinition("Calendar Teaser",
		IconUrl = "~/Content/Img/calendar_view_month.png")]
	public class CalendarTeaser : SidebarItem
	{
		[EditableLink("Calendar container", 100)]
		public virtual Calendar Container
		{
			get { return (Calendar)GetDetail("Container"); }
			set { SetDetail("Container", value); }
		}
	}
}