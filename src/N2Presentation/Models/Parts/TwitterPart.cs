using System;
using N2;
using N2.Details;
using N2Presentation.Details;

namespace N2Presentation.Models.Parts
{
	[PartDefinition("Twitter", SortOrder = 10, IconUrl = "~/Content/img/SocialBookmarks/Twitter_16x16.png")]
	public class TwitterPart : PartBase
	{
		[EditableTextBox("Username @", 20)]
		//[EditableTwitterUserName("Username @", 20)]
		public virtual string UserName { get; set; }
	}
}