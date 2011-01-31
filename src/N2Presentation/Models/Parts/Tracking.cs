using N2.Details;
using N2.Integrity;
using N2Presentation.Models.Pages;

namespace N2Presentation.Models.Parts
{
	[N2.PartDefinition("Tracking script",
		IconUrl = "~/Content/Img/google.png",
		SortOrder = 2000)]
	[RestrictParents(typeof(LanguageRoot))]
	[AllowedZones(Zones.SiteRight)]
	public class Tracking : PartBase
	{
		[EditableCheckBox("Enabled", 100)]
		public virtual bool Enabled
		{
			get { return (bool)(GetDetail("Enabled") ?? true); }
			set { SetDetail("Enabled", value, true); }
		}

		[EditableCheckBox("Track authenticated editors", 100)]
		public virtual bool TrackEditors
		{
			get { return (bool)(GetDetail("TrackEditors") ?? false); }
			set { SetDetail("TrackEditors", value, false); }
		}

		[EditableTextBox("UACCT code", 100)]
		public virtual string UACCT
		{
			get { return (string)(GetDetail("UACCT") ?? string.Empty); }
			set { SetDetail("UACCT", value, string.Empty); }
		}
	}
}