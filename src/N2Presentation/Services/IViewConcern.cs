using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using N2;

namespace N2Presentation.Services
{
	public interface IViewConcern
	{
		void Apply(ContentItem item, Page page);
	}
}
