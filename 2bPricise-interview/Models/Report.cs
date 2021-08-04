using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2bPricise_interview.Models
{
    public class Report
    {
        public int reportID { get; set; }
        public string text { get; set; }
        public string date {get; set;}
        public int mangerID { get; set; }
        public int authorID { get; set; }
    }
}