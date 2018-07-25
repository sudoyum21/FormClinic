using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime VisitDTS { get; set; }
    }
}
