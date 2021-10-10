using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRecord.Models
{
    public class schoolClass
    {
        public int id { get; set; } // class id 

  
        [Required] 
        public string Name { get; set; } // name of class 
         public string Contact { get; set; } // contact number for class


      
        public int Fees{ get; set; } // fess for student in this class 

        public schoolTeacher schoolTeacher { get; set; }  // Teacher name 
        public int schoolTeacherID { get; set; }

    }
}
