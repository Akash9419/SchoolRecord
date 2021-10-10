using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRecord.Models
{
    public class Query  // query class for contact us page  anyone can contact us 
    {

        public int id { get; set; } // queru id 

        [Display(Name = "Name")] // name lebal
        public string Name { get; set; } // name of student , teacher or anyone who make query 

        [Display(Name = "Email")]  // email lebal
        public string Email { get; set; } // email address 

        [Display(Name = "Message")] // meassgae  lebal
        public string Message { get; set; } // meassge what type of query 

        [Display(Name = "Date")] // dtae label
        public DateTime dTime { get; set; } // date 

    }
}
