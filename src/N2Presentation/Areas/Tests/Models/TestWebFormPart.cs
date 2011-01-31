#if DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using N2;

namespace N2Presentation.Areas.Tests.Models
{
	[N2.PartDefinition("Test WebForm", TemplateUrl = "~/Areas/Tests/Views/Forms/TestWebFormPart.ascx", SortOrder = 21002)]
	public class TestWebFormPart : ContentItem
	{
	}
}
#endif