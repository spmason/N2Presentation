#if DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using N2.Details;
using N2.Integrity;
using N2Presentation.Models.Pages;

namespace N2Presentation.Areas.Tests.Models
{
	[N2.PageDefinition(SortOrder = int.MaxValue, Description = "Release compile the project to remove this test")]
	[RestrictParents(typeof(StartPage))]
	[WithEditableTitle]
	public class TestPage : TestItemBase
	{
	}
}
#endif
