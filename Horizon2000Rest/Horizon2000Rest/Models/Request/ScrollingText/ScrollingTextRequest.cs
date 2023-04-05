using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon2000.Rest.Models.Request.ScrollingText
{
	public class ScrollingTextRequest: BaseRequest
	{
		public string Text { get; set; }
	}
}