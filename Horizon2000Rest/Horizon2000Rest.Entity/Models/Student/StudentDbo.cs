using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Entity.Models.Student
{
    public class StudentDbo
    {
        public string IdCard { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string Email { get; set; }

        public string ContactNo { get; set; }


        public string DateOfBirth { get; set; }
    }
}
