using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Entity.Models.Course
{
    public class CreateCourseDbo : BaseCourseDbo
    {
        public string Image { get; set; }
        public string ImageFileName { get; set; }
    }
}
