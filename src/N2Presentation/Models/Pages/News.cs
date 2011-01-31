using System.Web.UI.WebControls;
using N2.Definitions;
using N2.Details;
using N2.Integrity;
using N2Presentation.Services;
using N2.Web.Mvc;
using N2.Persistence;

namespace N2Presentation.Models.Pages
{
	[N2.PageDefinition("News", Description = "A news page.", SortOrder = 155,
		IconUrl = "~/Content/Img/newspaper.png")]
	[RestrictParents(typeof(NewsContainer))]
	public class News : ContentPageBase, ISyndicatable
	{
		public News()
		{
			Visible = false;
			Syndicate = true;
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