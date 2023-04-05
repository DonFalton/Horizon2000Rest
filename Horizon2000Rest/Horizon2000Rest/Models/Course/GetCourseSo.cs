using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon2000.Rest.Models.Course
{
	public class GetCourseSo
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public byte[] Image { get; set; }

		public string FileType { get; set; }
	}
}