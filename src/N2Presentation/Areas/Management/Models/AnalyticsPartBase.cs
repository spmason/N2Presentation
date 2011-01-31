using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace N2Presentation.Areas.Management.Models
{
	public abstract class AnalyticsPartBase : N2Presentation.Models.Parts.PartBase
	{
		public override bool IsPage
		{
			get { return false; }
		}
	}
}
