using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssesment.Model
{
    public class StudentDetails
    {
        public int student_id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
        public int class_id { get; set; }
        public string date_of_birth { get; set; }
        public string country_name { get; set; }
        public string class_name { get; set; }
    }
}
