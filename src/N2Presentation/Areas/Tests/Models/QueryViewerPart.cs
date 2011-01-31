#if DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace N2Presentation.Areas.Tests.Models
{
	[N2.PartDefinition("Query viewer", TemplateUrl = "~/Addons/UITests/UI/QueryViewer.ascx", SortOrder = 20000)]
	public class QueryViewerPart : TestItemBase
	{
	}
}
#endif