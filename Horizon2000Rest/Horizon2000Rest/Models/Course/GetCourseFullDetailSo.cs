using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon2000.Rest.Models.Course
{
	public class GetCourseFullDetailSo
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int NormalHour { get; set; }

		public decimal NormalPrice { get; set; }

		public int RapidHour { get; set; }
		public decimal RapidPrice { get; set; }

		public string Description { get; set; }

		public int ParentCourseId { get; set; }
	}
}