using N2.Definitions;
using N2.Edit.Trash;
using N2.Integrity;
using N2Presentation.Models.Pages;

namespace N2Presentation.Models.Parts
{
	[Disable] // This item is added by the CommentInput thus it's disabled
	[Throwable(AllowInTrash.No)]
	[Versionable(AllowVersions.No)]
	[N2.PartDefinition("Comment List",
		IconUrl = "~/Content/Img/comments.png")]
	[RestrictParents(typeof(ICommentable))]
	public class CommentList : PartBase
	{
	}
}