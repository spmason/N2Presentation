using N2.Integrity;
using N2Presentation.Models.Pages;
using N2.Definitions;

namespace N2Presentation.Models.Parts
{
	[N2.PartDefinition("Comment Input Form",
		IconUrl = "~/Content/Img/comment_add.png")]
	[RestrictParents(typeof(ICommentable))]
	[AllowedZones(Zones.Content, Zones.RecursiveBelow)]
	public class CommentInput : PartBase
	{
	}
}