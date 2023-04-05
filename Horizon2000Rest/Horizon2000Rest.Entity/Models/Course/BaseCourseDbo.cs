using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Entity.Models.Course
{
    public class BaseCourseDbo
    {
        public string Name { get; set; }
        public int NormalHour { get; set; }
        public decimal NormalPrice { get; set; }
        public int RapidHour { get; set; }
        public decimal RapidPrice { get; set; }
        public string Description { get; set; }
        public int ParentCourseId { get; set; }
    }
}
