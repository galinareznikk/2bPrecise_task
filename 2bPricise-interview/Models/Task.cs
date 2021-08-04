using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2bPricise_interview.Models
{
    public class Task
    {
        public int taskID {get; set;}
        public string text {get; set;}
        public string assign_date { get; set; }
        public string due_date { get; set; }
        public int EmployeeID{ get; set; }
        
    }
 
}