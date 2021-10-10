using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRecord.Models
{
    public class schoolTeacher
    {
        public int id { get; set; } // techer id 

        [Display(Name = "Name")] // lebal name of teacher 
        [Required]
        public string Name { get; set; } // teacher name 


        [Display(Name = "Contact")] // lebal of contact 
        public string Contact { get; set; } // teacher ontact 


        [Display(Name = "Experience")] // lebal of experince 
        public string Experience { get; set; } // experienece 


        [Display(Name = "Subject ")] // lebal for teacehr 
        public string Subject { get; set; } // which subject teacher will teach student 
         
        [Display(Name = "Email")] // lebal for emial 
        public string Email { get; set; } // email address of teacher 

    }
}
