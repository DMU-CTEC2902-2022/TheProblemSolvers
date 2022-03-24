using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Information_and_technology_college.Models
{
    public class student
    {
        public virtual int Studentid { get; set; }
        public virtual int Courseid { get; set; }
        
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime dob { get; set; }
        public virtual string Address { get; set; }
        public virtual string emailaddress { get; set; }
    }
}