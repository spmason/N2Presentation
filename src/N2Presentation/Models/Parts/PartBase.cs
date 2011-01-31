using System;
using N2;

namespace N2Presentation.Models.Parts
{
	/// <summary>
	/// A base class for item parts in the templates project.
	/// </summary>
	public abstract class PartBase : ContentItem
	{
	}

	[Obsolete("Use PartBase and [N2.PartDefinition]")]
	public abstract class AbstractItem : PartBase
	{
		public override bool IsPage
		{
			get { return false; }
		}
	}
}