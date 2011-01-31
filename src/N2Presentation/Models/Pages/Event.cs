using System;
using System.Web.UI.WebControls;
using N2.Definitions;
using N2.Details;
using N2.Integrity;
using N2Presentation.Services;
using N2.Web.Mvc;
using N2.Persistence;

namespace N2Presentation.Models.Pages
{
	[N2.PageDefinition("Event",
		Description = "An event in the event calendar.",
		SortOrder = 110,
		IconUrl = "~/Content/Img/calendar_view_day.png")]
	[RestrictParents(typeof(Calendar))]
	public class Event : ContentPageBase, ISyndicatable
	{
		public Event()
		{
			Visible = false;
		}

		[EditableDate("Event date", 22, ContainerName = Tabs.Content)]
		public virtual DateTime? EventDate
		{
			get { return (DateTime?)GetDetail("EventDate"); }
			set { SetDetail("EventDate", value); }
		}

		[DisplayableLiteral]
		public virtual string EventDateString
		{
			get
			{
				if (!EventDate.HasValue) return null;
				if (EventDate.Value.TimeOfDay.TotalSeconds == 0) return EventDate.Value.ToShortDateString();

				return EventDate.Value.ToString();
			}
		}

		[EditableTextBox("Introduction", 90, ContainerName = Tabs.Content, TextMode = TextBoxMode.MultiLine, Rows = 4,
			Columns = 80)]
		public virtual string Introduction
		{
			get { return (string)(GetDetail("Introduction") ?? string.Empty); }
			set { SetDetail("Introduction", value, string.Empty); }
		}

		string ISyndicatable.Summary
		{
			get { return Introduction; }
		}

		[Persistable(PersistAs = PropertyPersistenceLocation.Detail)]
		public virtual bool Syndicate { get; set; }
	}
}