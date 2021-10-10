using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRecord.Models
{
    public class schoolAdminssion
    {

        public int id { get; set; } // studebnt id 

        [Display(Name = "Name")] // student name lebal 

        public string Name { get; set; } // name of student 

        [Display(Name = "Father Name")] // lebal for father name 
        public string fatherName { get; set; } // father name of the student 

        [Display(Name = "Contact")] // contact6 lebal
        public string Contact { get; set; } //  student  contact 

        [Display(Name = "Class")] // class lebal
        public schoolClass schoolClass { get; set; }  // class name 
        public int SchoolClassID { get; set; }  // class name  pich as dropdown from school class
    }
}
