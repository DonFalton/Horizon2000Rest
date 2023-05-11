using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Entity.Models.Schedule
{
    public class BaseScheduleDbo
    {
        public string Title { get; set; }

        public int CourseID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
