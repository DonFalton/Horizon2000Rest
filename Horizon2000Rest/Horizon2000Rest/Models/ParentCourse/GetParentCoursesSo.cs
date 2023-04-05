using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon2000.Rest.Models.ParentCourse
{
	public class GetParentCoursesSo
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public byte[] Image { get; set; }

		public string FileType { get; set; }
	}
}