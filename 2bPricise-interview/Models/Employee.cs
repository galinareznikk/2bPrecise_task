using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2bPricise_interview.Models
{
    public class Employee
    {
        public int PKID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public int manager { get; set; }

        public string profile_pic { get; set; }
    }
}