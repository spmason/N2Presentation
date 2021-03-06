using N2;
using N2.Web.UI;
using N2.Engine;

namespace N2Presentation.Services.WebForms
{
	/// <summary>
	/// Applies the template defined in the n2/templates configuration section 
	/// to the page.
	/// </summary>
	[Service(typeof(ContentPageConcern))]
	public class MasterPageConcern : ContentPageConcern
	{
		string masterPageFile = "~/Views/Shared/WebForms.master";

		public override void OnPreInit(System.Web.UI.Page page, ContentItem item)
		{
			if (!string.IsNullOrEmpty(masterPageFile))
			{
				page.MasterPageFile = masterPageFile;
			}
		}
	}
}