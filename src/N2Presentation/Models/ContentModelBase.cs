﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using N2;

namespace N2Presentation.Models
{
	public class ContentModelBase<T>
		where T : ContentItem
	{
		public virtual T CurrentItem { get; set; }
	}
}