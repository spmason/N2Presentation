using N2.Integrity;

namespace N2Presentation.Models.Parts
{
	[N2.PartDefinition("Two column container",
		IconUrl = "~/Content/Img/text_columns.png")]
	[AvailableZone("Left", "ColumnLeft"), AvailableZone("Right", "ColumnRight")]
	[AllowedZones("Content")]
	public class Columns : PartBase
	{
	}
}