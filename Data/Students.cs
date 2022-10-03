using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssesment.Data
{
    public class Students
    {
        public int id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
        public int class_id { get; set; }
        public DateTime date_of_birth { get; set; }
    }
}
